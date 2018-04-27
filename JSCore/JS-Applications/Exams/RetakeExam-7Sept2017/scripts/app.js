$(() => {
    const app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs');

        //GET method for the main page in app
        this.get('skeleton.html', displayHome);
        this.get('#/home', displayHome);

        //GET method for login
        this.get('#/login',function(ctx){
            displayHome(ctx);
        });

        //POST method for login
        this.post('#/login', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;

            if (username === '' ||  password ==='') {
                notify.showError('All fields are required.')
            } else {
                authService.login(username, password)
                    .then(function (userData) {
                        authService.saveSession(userData);
                        notify.showInfo('User login successful!');
                        ctx.redirect('#/feedPage');
                    }).catch(notify.handleError);
            }
        });
        //POST method for login
        this.post('#/login', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;

            if (username === '' || password === '') {
                notify.showError('All fields are required.')
            } else {
                authService.login(username, password)
                    .then(function (userData) {
                        authService.saveSession(userData);
                        notify.showInfo('User login successful!');
                        ctx.redirect('#/feedPage');
                    }).catch(notify.handleError);
            }
        });

        //GET method for registration
        this.get('#/register',function(ctx){
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                registerForm: './templates/forms/registerForm.hbs',
            }).then(function () {
                this.partial('./templates/home/registerPage.hbs');
            })
        });
        //POST method for registration
        this.post('#/register', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;
            let repeatPass = ctx.params.repeatPass;

            if (!/^.{5,}$/.test(username)) {
                notify.showError('Username must be at least five characters long!')
            } else if (password === '' || repeatPass === '') {
                notify.showError('Password fields are required.')
            } else if (password !== repeatPass) {
                notify.showError('Password do not match!')
            } else {
                authService.register(username, password)
                    .then(function (userData) {
                        authService.saveSession(userData);
                        notify.showInfo('User registration successful.');
                        ctx.redirect('#/feedPage');
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

        //GET method for feedPage
        this.get('#/feedPage', function (ctx) {
            if (!authService.isAuth()) {
                ctx.redirect('#/home');
                return;
            }

            chirpService.getAllChirps()
                .then(function (chirps) {
                    chirps.forEach((chirp, index) => {
                        chirp.time = calcTime(post._kmd.ect);
                    });

                    ctx.username = sessionStorage.getItem('username');
                    ctx.chirps = chirps;

                    ctx.loadPartials({
                        header: './templates/common/header.hbs',
                        footer: './templates/common/footer.hbs',
                        nav: './templates/common/nav.hbs',
                        chirp: './templates/feeds/chirp.hbs'
                    }).then(function () {
                        this.partial('./templates/feeds/feedPage.hbs')
                    })
                })
                .catch(notify.handleError);
        });

        function displayHome(ctx) {
            if (!authService.isAuth()) {

                ctx.loadPartials({
                    header: './templates/common/header.hbs',
                    footer: './templates/common/footer.hbs',
                    loginForm: './templates/forms/loginForm.hbs',
                }).then(function () {
                    this.partial('./templates/home/loginPage.hbs');
                })
            } else {
                ctx.redirect('#/catalog');
            }
        }
    });

    app.run();
});