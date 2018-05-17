$(() => {

    const app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs');

        //GET method for the main page in app
        this.get('skeleton.html', displayHome);
        this.get('#/home', displayHome);

        //Show different view if user isAuth
        function displayHome(ctx) {
            if (!auth.isAuth()) {
                ctx.loadPartials({
                    header: './templates/common/header.hbs',
                    footer: './templates/common/footer.hbs',
                    registerForm: './templates/forms/registerForm.hbs',
                }).then(function () {
                    this.partial('./templates/auth/viewRegister.hbs')
                }).catch(notify.handleError)
            } else {
                let username = sessionStorage.getItem('username');
                chirp.countChirps(username)
                    .then(function (countChirps) {
                        chirp.getUserChirps(username)
                            .then(function (chirps) {
                                chirps.forEach((c, i) => {
                                    c.time = calcTime(c._kmd.ect)
                                });

                                ctx.chirpsCount = countChirps.length;
                                ctx.chirps = chirps;
                                ctx.username = username;

                                ctx.loadPartials({
                                    header: './templates/common/header.hbs',
                                    footer: './templates/common/footer.hbs',
                                    nav: './templates/common/nav.hbs',
                                }).then(function () {
                                    this.partial('./templates/viewFeed.hbs')
                                }).catch(notify.handleError)
                            })
                            .catch(notify.handleError)

                    })
                    .catch(notify.handleError);
            }
        }

        //POST method for registration
        this.post('#/register', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;
            let repeatPass = ctx.params.repeatPass;

            if (username.length < 5) {
                notify.showError('A username should be at least 5 characters long.')
            } else if (password.length === 0) {
                notify.showError('Passwords input fields shouldn’t be empty.')
            } else if (password !== repeatPass) {
                notify.showError('The passwords do not match.')
            } else {
                auth.register(username, password)
                    .then(function (userData) {
                        auth.saveSession(userData);
                        notify.showInfo('User registration successful.');
                        ctx.redirect('#/home');
                    }).catch(notify.handleError);
            }
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


        //POST submit chirp
        this.post('#/submitChirp', function (ctx) {
            let text = ctx.params.text;
            if (text.length === 0) {
                notify.showError('A chirp text shouldn’t be empty.');
            } else if (text.length > 150) {
                notify.showInfo('A chirp text shouldn’t contain more than 150 symbols');
            } else {
                chirp.createChirp(text)
                    .then(function () {
                        notify.showInfo('Chirp published.');
                        ctx.redirect('#/home');
                    })
                    .catch(notify.handleError);
            }
        });

        //GET me
        this.get('#/me', function (ctx) {
            let username = sessionStorage.getItem('username');
            let followersPromise = chirp.countFollowers(username);
            let followingPromise = chirp.countFollowing(username);
            let userChirpsPromise = chirp.getUserChirps(username);

            Promise.all([followersPromise, followingPromise, userChirpsPromise])
                .then(([followers, following, chirps]) => {
                    ctx.chirps = chirps;
                    ctx.username = username;
                    ctx.following = following;
                    ctx.followers = followers;
                    ctx.chirpsCount = chirps.length;
                    chirps.forEach((c, i) => {
                        c.time = calcTime(c._kmd.ect)
                    });

                    ctx.loadPartials({
                        header: './templates/common/header.hbs',
                        footer: './templates/common/footer.hbs',
                        nav: './templates/common/nav.hbs',
                    }).then(function () {
                        this.partial('./templates/viewMe.hbs')
                    }).catch(notify.handleError)
                }).catch(notify.handleError);

        });

        function calcTime(dateIsoFormat) {
            let diff = new Date - (new Date(dateIsoFormat));
            diff = Math.floor(diff / 60000);
            if (diff < 1) return 'less than a minute';
            if (diff < 60) return diff + ' minute' + pluralize(diff);
            diff = Math.floor(diff / 60);
            if (diff < 24) return diff + ' hour' + pluralize(diff);
            diff = Math.floor(diff / 24);
            if (diff < 30) return diff + ' day' + pluralize(diff);
            diff = Math.floor(diff / 30);
            if (diff < 12) return diff + ' month' + pluralize(diff);
            diff = Math.floor(diff / 12);
            return diff + ' year' + pluralize(diff);

            function pluralize(value) {
                if (value !== 1) return 's';
                else return '';
            }
        }


    });

    app.run();
});