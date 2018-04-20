$(() => {

    const app = Sammy('#app', function () {
        this.use('Handlebars', 'hbs');

        //GET method for the main page in app
        this.get('index.html', displayHome);
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
                    this.partial('./templates/home/logedOut.hbs');
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
        this.get('#/register',function (ctx) {
           ctx.loadPartials({
               header: './templates/common/header.hbs',
               footer: './templates/common/footer.hbs',
               registerForm: './templates/forms/registerForm.hbs',
           }).then(function () {
               this.partial('./templates/auth/register.hbs')
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
        this.get('#/login',function (ctx) {
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                loginForm: './templates/forms/loginForm.hbs',
            }).then(function () {
                this.partial('./templates/auth/login.hbs')
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

        //GET for my message
        this.get('#/messages',(ctx) =>{
            let username = sessionStorage.getItem('username');
            messageService.getAllMessageByUser(username)
                .then(function (messages) {
                    messages.forEach((message,index)=>{
                       message.date =  formatDate(message._kmd.lmt);
                       message.sender = formatSender(message.sender_name,message.sender_username);
                    });

                    ctx.isAuth = auth.isAuth();
                    ctx.username = sessionStorage.getItem('username');
                    ctx.messages = messages;

                    ctx.loadPartials({
                        header: './templates/common/header.hbs',
                        footer: './templates/common/footer.hbs',
                        message: './templates/messages/message.hbs'
                    }).then(function () {
                        this.partial('./templates/messages/myMessages.hbs')
                    }).catch(notify.handleError)

                }).catch(notify.handleError);
        });

        //GET for my archive
        this.get('#/archive',(ctx) =>{
            let username = sessionStorage.getItem('username');
            messageService.getAllMessageByUserSender(username)
                .then(function (archiveMessages) {
                    archiveMessages.forEach((message,index)=>{
                        message.date =  formatDate(message._kmd.lmt);
                    });

                    ctx.isAuth = auth.isAuth();
                    ctx.username = sessionStorage.getItem('username');
                    ctx.archiveMessages = archiveMessages;

                    ctx.loadPartials({
                        header: './templates/common/header.hbs',
                        footer: './templates/common/footer.hbs',
                        archiveMessage: './templates/messages/archiveMessage.hbs'
                    }).then(function () {
                        this.partial('./templates/messages/archive.hbs')
                    }).catch(notify.handleError)

                }).catch(notify.handleError);
        });

        //POST for delete
        this.post('#/delete/:messageId',(ctx) => {
            let messageId = ctx.params.messageId;

            messageService.deleteMessage(messageId)
                .then(function () {
                    notify.showInfo('Message deleted.');
                    ctx.redirect('#/archive')
                })
                .catch(notify.handleError);
        });

        //GET for send message
        this.get('#/send',(ctx) => {
           ctx.isAuth =  auth.isAuth();
           userService.getAllUsers()
               .then(function (users) {
                  ctx.users = users;
                   ctx.loadPartials({
                       header: './templates/common/header.hbs',
                       footer: './templates/common/footer.hbs',
                   }).then(function () {
                       this.partial('./templates/messages/sendMessage.hbs')
                   }).catch(notify.handleError);
               });
        });

        //POST for send message
        this.post('#/send',(ctx) => {
            let senderUsername = sessionStorage.getItem('username');
            let senderName =  sessionStorage.getItem('name');
            let recipient= $('#formSendMessage select[name=recipient]').val();
            let text = $('#formSendMessage input[name=text]').val();

            messageService.sendMessage(senderUsername,senderName,recipient,text)
                .then(() => {
                    notify.showInfo('Message send!');
                    ctx.redirect(`#/archive`);
                })
                .catch(notify.showError);
        });

        function formatDate(dateISO8601) {
            let date = new Date(dateISO8601);
            if (Number.isNaN(date.getDate()))
                return '';
            return date.getDate() + '.' + padZeros(date.getMonth() + 1) +
                "." + date.getFullYear() + ' ' + date.getHours() + ':' +
                padZeros(date.getMinutes()) + ':' + padZeros(date.getSeconds());

            function padZeros(num) {
                return ('0' + num).slice(-2);
            }
        }

        function formatSender(name, username) {
            if (!name)
                return username;
            else
                return username + ' (' + name + ')';
        }

    });

    app.run();
});