$(() => {
    const app = Sammy('#app', function () {
        this.use('Handlebars', 'hbs');

        //GET method for the main page in app
        this.get('market.html', displayHome);
        this.get('#/home', displayHome);

        //Show different view if user isAuth
        function displayHome(ctx) {
            ctx.isAuth = auth.isAuth();
            ctx.username = sessionStorage.getItem('username');
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',

            }).then(function () {
                if (!auth.isAuth()) {
                    this.partial('./templates/home/loggedOut.hbs');
                } else {
                    this.partial('./templates/home/loggedIn.hbs');
                }
            })
        }

        //POST method for registration
        this.post('#/register', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;
            let name = ctx.params.name;

            auth.register(username, password, name)
                .then(function (userData) {
                    auth.saveSession(userData);
                    notify.showInfo('User registration successful!');
                    ctx.redirect('#/home');
                }).catch(notify.handleError);
        });

        //GET method for register
        this.get('#/register', function (ctx) {
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                registerForm: './templates/forms/registerForm.hbs',
            }).then(function () {
                this.partial('./templates/auth/viewRegister.hbs')
            }).catch(notify.handleError);
        });

        //POST method for login
        this.post('#/login', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;

            auth.login(username, password)
                .then(function (userData) {
                    auth.saveSession(userData);
                    notify.showInfo('User login successful!');
                    ctx.redirect('#/home');
                }).catch(notify.handleError);
        });

        //GET method for login
        this.get('#/login', function (ctx) {
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                loginForm: './templates/forms/loginForm.hbs',
            }).then(function () {
                this.partial('./templates/auth/viewLogin.hbs')
            }).catch(notify.handleError);
        });

        //POST method for logout
        this.get('#/logout', (ctx) => {
            auth.logout()
                .then(() => {
                    sessionStorage.clear();
                    ctx.redirect('#/home');
                })
                .catch(notify.handleError);
        });


        //GET method for shop
        this.get('#/shop', function (ctx) {
            productService.getAllProducts()
                .then(function (products) {
                    products.forEach((product, index) => {
                        product.price = product.price.toFixed(2);
                    });

                    ctx.isAuth = auth.isAuth();
                    ctx.username = sessionStorage.getItem('username');
                    ctx.products = products;

                    ctx.loadPartials({
                        header: './templates/common/header.hbs',
                        footer: './templates/common/footer.hbs',
                    }).then(function () {
                        this.partial('./templates/product/viewShop.hbs');
                    })
                }).catch(notify.handleError);
        });

        this.post('#/purchase/:purchaseId', function (ctx) {
            let userId = sessionStorage.getItem('userId');
            let productId = ctx.params.purchaseId;
            let userPromise =  userService.getParticularUser(userId);
            let productPromise = productService.getProductById(productId);

            Promise.all([userPromise,productPromise])
                .then(function ([user, product]) {
                    if(!user.hasOwnProperty('cart')){
                        user.cart = {};
                    }

                    if(!user.cart.hasOwnProperty(productId)){
                        user.cart[productId] = {
                            quantity:1,
                            product:{
                                name: product.name,
                                description: product.description,
                                price: product.price
                            }
                        }
                    }
                    user.cart[product._id].quantity = Number(user.cart[product._id].quantity) + 1;
                    notify.showInfo('Product was added to your cart!')
            }).catch(notify.handleError)

        });

        this.get('#/cart',function (ctx) {
           ctx.isAuth = auth.isAuth();
           ctx.username = sessionStorage.getItem('username');
            let userId = sessionStorage.getItem('userId');

           userService.getParticularUser(userId)
               .then(function (user) {
                   let products  = [];

                   Object.keys(user.cart).forEach((key,index) =>{
                       products.push(user.cart[key]);
                   });

                   ctx.products = products;
               })
               .catch(notify.handleError)
        });
    });

    app.run();
});