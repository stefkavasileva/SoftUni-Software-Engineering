$(() => {
    const app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs');

        this.get('index.html', displayHome);
        this.get('#/home', displayHome);

        //GET about page
        this.get('#/about', function (ctx) {
            ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');

            loadPartials(ctx).then(function () {
                this.partial('./templates/about/about.hbs');
            });
        });

        //GET login page
        this.get('#/login', function (ctx) {
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                loginForm: './templates/login/loginForm.hbs'

            }).then(function () {
                this.partial('./templates/login/loginPage.hbs');
            }).catch(auth.showError);
        });

        //POST login page
        this.post('#/login', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;
            auth.login(username, password)
                .then(function (userInfo) {
                    auth.saveSession(userInfo);
                    auth.showInfo(`Welcome ${username}!!!`);
                    displayHome(ctx);
                })
                .catch(auth.showError);
        });

        //GET logout
        this.get('#/logout', function (ctx) {
            auth.logout()
                .then(function () {
                    sessionStorage.clear();
                    auth.showInfo('Logged out successful!!');
                    displayHome(ctx);
                }).catch(auth.showError)
        });

        //GET register
        this.get('#/register', function (ctx) {
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                registerForm: './templates/register/registerForm.hbs',
            }).then(function () {
                this.partial('./templates/register/registerPage.hbs');
            }).catch(auth.showError)
        });

        //POST register
        this.post('#/register', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;
            let repeatPassword = ctx.params.repeatPassword;

            if (password === repeatPassword) {
                auth.register(username, password, repeatPassword)
                    .then(function (userInfo) {
                        auth.saveSession(userInfo);
                        auth.showInfo('Registered successful!!!');
                        displayHome(ctx);
                    }).catch(auth.showError);
            } else {
                auth.showError('Password do not match!')
            }

        });

        //GET catalog
        this.get('#/catalog', function (ctx) {
            ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');

            teamsService.loadTeams()
                .then(function (teams) {
                    ctx.hasNoTeam = sessionStorage.getItem('teamId') === null || sessionStorage.getItem('teamId') === 'undefined';
                    ctx.loadPartials({
                        header: './templates/common/header.hbs',
                        footer: './templates/common/footer.hbs',
                        team:'./templates/catalog/team.hbs',
                    }).then(function () {
                        this.partial('./templates/catalog/teamCatalog.hbs')
                    }).catch(auth.showError);
                })
                .catch(auth.showError)

        });

        function displayHome(ctx) {
            ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
            }).then(function () {
                this.partial('./templates/home/home.hbs');
            })
        }

        function loadPartials(ctx) {
            return ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs'
            });
        }
    });

    app.run();
});