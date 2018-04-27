$(() => {
    const app = Sammy('.container', function () {
        this.use('Handlebars', 'hbs');

        //GET method for the main page in app
        this.get('index.html', displayHome);
        this.get('#/home', displayHome);

        //POST method for login
        this.post('#/login', function (ctx) {
            let username = ctx.params['username-login'];
            let password = ctx.params['password-login'];

            if (username === '' || password === '') {
                notify.showError('All fields are required.')
            } else {
                authService.login(username, password)
                    .then(function (userData) {
                        authService.saveSession(userData);
                        notify.showInfo('Login successful.');
                        ctx.redirect('#/create');
                    }).catch(notify.handleError);
            }
        });

        //POST method for registration
        this.post('#/register', function (ctx) {
            let username = ctx.params['username-register'];
            let password = ctx.params['password-register'];
            let passwordCheck = ctx.params['password-register-check'];

            if (!/^.{5,}$/.test(username)) {
                notify.showError('Username must be at least five characters long!')
            } else if (password === '' || password.length === 0 || passwordCheck === '' || passwordCheck.length === 0) {
                notify.showError('Passwords input fields shouldn’t be empty.')
            } else if (password !== passwordCheck) {
                notify.showError('Password do not match.')
            } else {
                authService.register(username, password)
                    .then(function (userData) {
                        authService.saveSession(userData);
                        notify.showInfo('User registration successful.');
                        ctx.redirect('#/create');
                    }).catch(notify.handleError);
            }
        });

        //POST method for logout
        this.get('#/logout', (ctx) => {
            authService.logout()
                .then(() => {
                    sessionStorage.clear();
                    ctx.redirect('#/home');
                })
                .catch(notify.handleError);
        });

        function displayHome(ctx) {
            if (!authService.isAuth()) {
                ctx.loadPartials({
                    footer: './templates/common/footer.hbs',
                    loginForm: './templates/forms/loginForm.hbs',
                    registerForm: './templates/forms/registerForm.hbs',
                }).then(function () {
                    this.partial('./templates/welcomeView.hbs');
                })
            } else {
                ctx.redirect('#/create');
            }
        }

        //GET for create receipt
        this.get('#/create', async function (ctx) {
            ctx.username = sessionStorage.getItem('username');
            let receiptId = sessionStorage.getItem('activeReceiptId');
            if(sessionStorage.getItem('activeReceiptId') === 'undefined' || sessionStorage.getItem('activeReceiptId') === null){
                await receiptService.createReceipt(0, 0, true)
                    .then(function (newReceipt) {
                        newReceipt._acl.creator = sessionStorage.getItem('userId');
                        sessionStorage.setItem('activeReceiptId', newReceipt._id);
                        ctx.redirect('#/create');
                    })
                    .catch(notify.handleError);
            }

            receiptService.getActiveReceipt()
                .then(function (receipt) {
                    receiptService.getEntriesByReceiptId(receiptId)
                        .then(function (entries) {
                            let total = 0;
                            entries.forEach((entry, index) => {
                                entry.subtotal = entry.qty * entry.price;
                                total += entry.subtotal;
                            });
                            receiptService.commitReceipt(receiptId, total, entries.length, true)
                                .then(function () {
                                    ctx.entries = entries;
                                    ctx.total = receipt[0].total;
                                    ctx.loadPartials({
                                        footer: './templates/common/footer.hbs',
                                        header: './templates/common/header.hbs',
                                    }).then(function () {
                                        this.partial('./templates/createReceiptView.hbs');
                                    })
                                })
                                .catch(notify.handleError);
                        })
                        .catch(notify.showError);
                })
                .catch(notify.showError);
        });

        //GET method for add entries
        this.post('#/addProduct', function (ctx) {
            let type = ctx.params['type'];
            let qty = ctx.params['qty'];
            let price = ctx.params['price'];
            let receiptId = sessionStorage.getItem('activeReceiptId');

            if(type === '' || type.length===0){
                notify.showError('Product type is required.')
            }else if(isNaN(price)){
                notify.showError('Price must be a number.')
            }else if(isNaN(qty)){
                notify.showError('Quantity must be a number.')
            }else {
                receiptService.addEntry(type, qty, price, receiptId)
                    .then(function () {
                        notify.showInfo('Entry added.');
                        ctx.redirect('#/create');
                    })
                    .catch(notify.handleError);
            }

        });

        //GET method for checkout
        this.get('#/total', function (ctx) {
            receiptService.getActiveReceipt()
                .then(function (receipt) {
                    ctx.total = receipt[0].total;
                    ctx.redirect('#/create')
                })
                .catch(notify.handleError);
        })

        //GET for delete entry
        this.get('#/removeEntry/:entryId',function (ctx) {
            let entryId = ctx.params.entryId;
            receiptService.deleteEntry(entryId)
                .then(function () {
                    notify.showInfo('Entry deleted.');
                    ctx.redirect('#/create');
                })
                .catch(notify.handleError)
        })

        //GET for overview
        this.get('#/overview',function (ctx) {
            receiptService.getMyReceipts()
                .then(function (receipts) {
                    let totalPrice = 0;
                    receipts.forEach((receipt,index) =>{
                        let date = new Date(receipt._kmd.lmt);
                        let year = date.getFullYear();
                        let month = date.getMonth();
                        let day = date.getUTCDate();
                        let hour = date.getHours();
                        let minutes = date.getMinutes();

                        receipt.date =  `${year}-${month}-${day} ${hour}:${minutes}`;

                        totalPrice += Number(receipt.total);
                    });

                    ctx.username = sessionStorage.getItem('username');
                    ctx.receipts = receipts;
                    ctx.totalPrice = totalPrice;

                    ctx.loadPartials({
                        footer: './templates/common/footer.hbs',
                        header: './templates/common/header.hbs',
                    }).then(function () {
                        this.partial('./templates/allReceiptsView.hbs');
                    })
                        .catch(notify.handleError);
                })
                .catch(notify.handleError);
        });

        //GET for details entry
        this.get('#/details/:receiptId',function (ctx) {
            let receiptId = ctx.params.receiptId;
            receiptService.getReceiptById(receiptId)
                .then(function (receipt) {
                    let receiptId = receipt._id;
                    receiptService.getEntriesByReceiptId(receiptId)
                        .then(function (entries) {
                            entries.forEach((entry,index) => {
                                entry.subtotal = entry.price * entry.qty;
                            });

                            ctx.username = sessionStorage.getItem('username');
                            ctx.entries = entries;

                            ctx.loadPartials({
                                footer: './templates/common/footer.hbs',
                                header: './templates/common/header.hbs',
                            }).then(function () {
                                this.partial('./templates/detailsView.hbs')
                            }).catch(notify.handleError)
                        })
                        .catch(notify.handleError);
                })
                .catch(notify.handleError)
        })

    });

    app.run();
});