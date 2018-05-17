$(() => {
    const app = Sammy('#container', function () {
        this.use('Handlebars', 'hbs');

        //GET method for the main page in app
        this.get('index.html', displayHome);
        this.get('#/home', displayHome);

        //GET method for login
        this.get('#/login', function (ctx) {
            ctx.loadPartials({
                nav: './templates/common/nav.hbs',
                footer: './templates/common/footer.hbs',
                loginForm: './templates/forms/loginForm.hbs',
            }).then(function () {
                ctx.isAuth = authService.isAuth();
                this.partial('./templates/viewLogin.hbs')
            }).catch(notify.handleError);
        });

        //POST method for login
        this.post('#/login', function (ctx) {
            let username = ctx.params['username'];
            let password = ctx.params['pass'];

            if (!/^.{5,}$/.test(username)) {
                notify.showError('Username must be at least five characters long!')
            } else if (password === '' || password.length === 0) {
                notify.showError('Password field shouldn’t be empty.')
            } else {
                authService.login(username, password)
                    .then(function (userData) {
                        authService.saveSession(userData);
                        notify.showInfo('Login successful.');
                        ctx.redirect('#/home');
                    }).catch(notify.handleError);
            }
        });

        //GET register
        this.get('#/register', function (ctx) {
            ctx.loadPartials({
                nav: './templates/common/nav.hbs',
                footer: './templates/common/footer.hbs',
                registerForm: './templates/forms/registerForm.hbs',
            }).then(function () {
                ctx.isAuth = authService.isAuth();

                this.partial('./templates/viewRegister.hbs')
            }).catch(notify.handleError);
        });

        //POST method for registration
        this.post('#/register', function (ctx) {
            let username = ctx.params['username'];
            let password = ctx.params['pass'];
            let passwordCheck = ctx.params['checkPass'];

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
                        ctx.redirect('#/home');
                    }).catch(notify.handleError);
            }
        });

        //POST method for logout
        this.get('#/logout', (ctx) => {
            authService.logout()
                .then(() => {
                    sessionStorage.clear();
                    notify.showInfo('Logout successful.');
                    ctx.redirect('#/home');
                })
                .catch(notify.handleError);
        });

        function displayHome(ctx) {
            let isAuth = authService.isAuth();
            ctx.isAuth = isAuth;
            if (isAuth) {

                ctx.username = sessionStorage.getItem('username');

                flightService.getPublishFlight()
                    .then(function (flights) {
                        flights.forEach((f, i) => {
                            let fDate = new Date(f._kmd.lmt);
                            f.date = fDate.getDay();

                        });

                        ctx.flights = flights;
                        ctx.loadPartials({
                            footer: './templates/common/footer.hbs',
                            nav: './templates/common/nav.hbs',
                        }).then(function () {
                            this.partial('./templates/viewCatalog.hbs');
                        }).catch(notify.handleError)

                    })
                    .catch(notify.handleError);

            } else {

                ctx.loadPartials({
                    footer: './templates/common/footer.hbs',
                    loginForm: './templates/forms/loginForm.hbs',
                    nav: './templates/common/nav.hbs',
                }).then(function () {
                    this.partial('./templates/viewLogin.hbs');
                })
            }
        }

        //GET addFlight
        this.get('#/addFlight', function (ctx) {
            ctx.isAuth = authService.isAuth();

            ctx.username = sessionStorage.getItem('username');
            ctx.loadPartials({
                footer: './templates/common/footer.hbs',
                addFlightForm: './templates/forms/addFlightForm.hbs',
                nav: './templates/common/nav.hbs',
            }).then(function () {
                this.partial('./templates/viewAddFlight.hbs');
            }).catch(notify.handleError)
        });

        //POST addFlight
        this.post('#/addFlight', function (ctx) {
            let destination = ctx.params['destination'];
            let origin = ctx.params['origin'];
            let departureDate = ctx.params['departureDate'];
            let departureTime = ctx.params['departureTime'];
            let seats = ctx.params['seats'];
            let cost = ctx.params['cost'];
            let img = ctx.params['img'];
            let isPublic = 'false';
            if (ctx.params['public'] === 'on') {
                isPublic = 'true';
            }

            let validNumberType = /^\d+\.*\d*$/;

            if (destination.length === 0) {
                notify.showError('Destination is required.')
            } else if (origin.length === 0) {
                notify.showError('Origin is required.')
            } else if (!validNumberType.test(seats)) {
                notify.showError('Seats must be a valid number.')
            } else if (!validNumberType.test(cost)) {
                notify.showError('Cost must be a valid number.')
            } else {
                flightService.addFlight(isPublic, img, cost, seats, departureDate, departureTime, origin, destination)
                    .then(function () {
                        notify.showInfo('Created flight.');
                        ctx.redirect('#/home');
                    })
                    .catch(notify.handleError);
            }
        });

        //GET details
        this.get('#/details/:flightId', function (ctx) {
            let flightId = ctx.params.flightId;
            flightService.flightDetails(flightId)
                .then(function (flight) {
                    ctx.isAuth = authService.isAuth();
                    ctx.username = sessionStorage.getItem('username');

                    let date = new Date(flight.departureDate);
                    let locale = "en-us";

                    flight.day = date.getDay();
                    flight.month = date.toLocaleString(locale, {month: "long"});

                    ctx.flight = flight;

                    ctx.loadPartials({
                        footer: './templates/common/footer.hbs',
                        nav: './templates/common/nav.hbs',
                    }).then(function () {
                        this.partial('./templates/viewFlightDetails.hbs');
                    })
                })
                .catch(notify.showInfo);
        });

        //GET edit
        this.get('#/edit/:flightId', function (ctx) {
            let flightId = ctx.params.flightId;

            flightService.flightDetails(flightId)
                .then((flight) => {
                    if(flight._acl.creator !== sessionStorage.getItem('userId')){
                        ctx.redirect('#/flights');
                        notify.showError('You can edit only your flight.');
                        return;
                    }
                    ctx.isAuth = authService.isAuth();

                    ctx.username = sessionStorage.getItem('username');

                    if(flight.isPublished === 'true'){
                        ctx.isPublished = 'true'
                    }else {
                        ctx.isPublished = 'false'
                    }

                    ctx.flight = flight;

                    ctx.loadPartials({
                        footer: './templates/common/footer.hbs',
                        nav: './templates/common/nav.hbs',
                    }).then(function () {
                        this.partial('./templates/viewEditFlight.hbs');
                    })
                })
        });

        //POST edit
        this.post('#/edit/:flightId', function (ctx) {
            let flightId = ctx.params.flightId;
            flightService.flightDetails(flightId)
                .then(function (flight) {
                    if(flight._acl.creator !== sessionStorage.getItem('userId')){
                        ctx.redirect('#/flights');
                        notify.showError('You can delete only your flight.');
                        return;
                    }

                    let destination = ctx.params['destination'];
                    let origin = ctx.params['origin'];
                    let departureDate = ctx.params['departureDate'];
                    let departureTime = ctx.params['departureTime'];
                    let seats = ctx.params['seats'];
                    let cost = ctx.params['cost'];
                    let img = ctx.params['img'];
                    let isPublic = 'false';

                    if (ctx.params['public'] === 'on') {
                        isPublic = 'true';
                    }

                    let validNumberType = /^\d+\.*\d*$/;

                    if (destination.length === 0 || origin.length === 0) {
                        notify.showError('Destination and  origin are required.')
                    } else if (!validNumberType.test(seats)) {
                        notify.showInfo('Seats must be a valid number.')
                    } else if (!validNumberType.test(cost)) {
                        notify.showInfo('Cost must be a valid number.')
                    } else {
                        flightService.editFlight(flightId, isPublic, img, cost, seats, departureDate, departureTime, origin, destination)
                            .then(function () {
                                notify.showInfo('Successfully edited flight.');
                                ctx.redirect('#/details/' + flightId);
                            })
                            .catch(notify.handleError);
                    }
                })
                .catch(notify.handleError);
        });

        //GET my flights
        this.get('#/flights', function (ctx) {
            flightService.getMyFlights()
                .then(function (fligths) {
                    fligths.forEach((f, i) => {
                        let date = new Date(f.departureDate);
                        let locale = "en-us";

                        f.day = date.getDay();
                        f.month = date.toLocaleString(locale, {month: "long"});

                    });

                    ctx.isAuth = authService.isAuth();
                    ctx.username = sessionStorage.getItem('username');
                    ctx.flights = fligths;

                    ctx.loadPartials({
                        footer: './templates/common/footer.hbs',
                        nav: './templates/common/nav.hbs',
                    }).then(function () {
                        this.partial('./templates/viewMyFlights.hbs')
                    })
                })
                .catch(notify.handleError);
        });

        //GET method  delete
        this.get('#/delete/:flightId', function (ctx) {
            if (!authService.isAuth()) {
                ctx.redirect('#/home');
                return;
            }
            let flightId = ctx.params.flightId;

            flightService.flightDetails(flightId)
                .then(function (fligth) {
                    if(fligth._acl.creator !== sessionStorage.getItem('userId')){
                        ctx.redirect('#/home');
                        notify.showError('You can delete only your flight.');
                        return;
                    }

                    flightService.deleteFlight(flightId)
                        .then(function () {
                            notify.showInfo('Flight deleted.');
                            ctx.redirect('#/flights')
                        })
                        .catch(notify.handleError);
                })
                .catch(notify.handleError);
        });

    });

    app.run();
});