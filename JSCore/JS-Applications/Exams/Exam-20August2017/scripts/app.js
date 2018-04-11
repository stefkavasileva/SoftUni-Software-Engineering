$(() => {
    const usernameReg = /^[A-Za-z]{3,}$/;
    const passwordReg = /^[A-Za-z\d]{6,}$/;

    const app = Sammy('#container', function () {
        this.use('Handlebars', 'hbs');

        //GET method for the main page in app
        this.get('index.html', displayHome);
        this.get('#/home', displayHome);

        //POST method for registration
        this.post('#/register', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;
            let repeatPass = ctx.params.repeatPass;

            if (!usernameReg.test(username)) {
                notify.showError('Username must contains only english alphabet letters and must be at least three characters long!')
            } else if (!passwordReg.test(password) || !passwordReg.test(repeatPass)) {
                notify.showError('Password must contains english alphabet letters and digits and must be at least six characters long!')
            } else if (password !== repeatPass) {
                notify.showError('Password do not match!')
            } else {
                auth.register(username, password)
                    .then(function (userData) {
                        auth.saveSession(userData);
                        notify.showInfo('User registration successful!');
                        ctx.redirect('#/catalog');
                    }).catch(notify.handleError);
            }
        });

        //POST method for login
        this.post('#/login', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;

            if (!usernameReg.test(username)) {
                notify.showError('Username must contains only english alphabet letters and must be at least three characters long!')
            } else if (!passwordReg.test(password)) {
                notify.showError('Password must contains english alphabet letters and digits and must be at least six characters long!')
            } else {
                auth.login(username, password)
                    .then(function (userData) {
                        auth.saveSession(userData);
                        notify.showInfo('User login successful!');
                        ctx.redirect('#/catalog');
                    }).catch(notify.handleError);
            }
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

        //GET method for catalog
        this.get('#/catalog', function (ctx) {
            if (!auth.isAuth()) {
                ctx.redirect('#/home');
                return;
            }

            postsService.getAllPosts()
                .then(function (posts) {
                    posts.forEach((post, index) => {
                        post.postCounter = index + 1;
                        post.cretedTime = calcTime(post._kmd.ect);
                        post.isAuthor = post._acl.creator === sessionStorage.getItem('userId');
                    });

                    ctx.isAuth = auth.isAuth();
                    ctx.username = sessionStorage.getItem('username');
                    ctx.posts = posts;

                    ctx.loadPartials({
                        header: './templates/common/header.hbs',
                        footer: './templates/common/footer.hbs',
                        navigation: './templates/common/navigationTemplate.hbs',
                        post: './templates/catalog/post.hbs'
                    }).then(function () {
                        this.partial('./templates/catalog/catalogPage.hbs')
                    })
                })
                .catch(notify.handleError);
        });

        //GET for create post
        this.get('#/submitLink', function (ctx) {
            if (!auth.isAuth()) {
                ctx.redirect('#/home');
                return;
            }

            ctx.isAuth = auth.isAuth();
            ctx.username = sessionStorage.getItem('username');
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                navigation: './templates/common/navigationTemplate.hbs',
                createPostForm: './templates/forms/createPostForm.hbs'
            }).then(function () {
                this.partial('./templates/catalog/createPost.hbs');
            })
                .catch(notify.handleError)
        });

        //POST method for creating post
        this.post('#/submitLink', function (ctx) {
            let url = ctx.params.url;
            let title = ctx.params.title;
            let imageUrl = ctx.params.image;
            let description = ctx.params.comment;

            if (url === '' || title === '') {
                notify.showError('Url and title are required!')
            } else if (!url.startsWith('http') || !imageUrl.startsWith('http')) {
                notify.showError('Valid url must starts with http!')
            } else {
                postsService.createPost(sessionStorage.getItem('username'), title, description, url, imageUrl)
                    .then(function () {
                        notify.showInfo('Post created.');
                        ctx.redirect('#/catalog');
                    })
                    .catch(notify.handleError)
            }
        });

        //GET edit post by id
        this.get('#/editPost/:postId', function (ctx) {
            if (!auth.isAuth()) {
                ctx.redirect('#/home');
                return;
            }

            let postId = ctx.params.postId;

            postsService.getPostById(postId)
                .then((post) => {
                    ctx.isAuth = auth.isAuth();
                    ctx.username = sessionStorage.getItem('username');
                    ctx.post = post;

                    ctx.loadPartials({
                        header: './templates/common/header.hbs',
                        footer: './templates/common/footer.hbs',
                        navigation: './templates/common/navigationTemplate.hbs',
                    }).then(function () {
                        this.partial('./templates/catalog/editPost.hbs');
                    })
                })
        });

        //POST edit post by edit
        this.post('#/editPost', function (ctx) {
            let url = ctx.params.url;
            let title = ctx.params.title;
            let imageUrl = ctx.params.imageUrl;
            let description = ctx.params.description;
            let postId = ctx.params.postId;

            if (url === '' || title === '') {
                notify.showError('Url and title are required!')
            } else if (!url.startsWith('http') || !imageUrl.startsWith('http')) {
                notify.showError('Valid url must starts with http!')
            } else {
                postsService.editPost(postId, sessionStorage.getItem('username'), title, description, url, imageUrl)
                    .then(function () {
                        notify.showInfo(`Post ${title} updated.`);
                        ctx.redirect('#/catalog');
                    })
                    .catch(notify.handleError)
            }
        });

        //GET method for delete
        this.get('#/deletePost/:postId', function (ctx) {
            if (!auth.isAuth()) {
                ctx.redirect('#/home');
                return;
            }
            let postId = ctx.params.postId;

            postsService.deletePost(postId)
                .then(function () {
                    notify.showInfo('Post deleted.');
                    ctx.redirect('#/catalog')
                })
                .catch(notify.handleError);
        });

        //GET post of current user
        this.get('#/myPosts', function (ctx) {
            if (!auth.isAuth()) {
                ctx.redirect('#/home');
                return;
            }

            postsService.getMyPosts(sessionStorage.getItem('username'))
                .then(function (posts) {
                    posts.forEach((post, index) => {
                        post.postCounter = index + 1;
                        post.cretedTime = calcTime(post._kmd.ect);
                    });

                    ctx.isAuth = auth.isAuth();
                    ctx.username = sessionStorage.getItem('username');
                    ctx.myPosts = posts;

                    ctx.loadPartials({
                        header: './templates/common/header.hbs',
                        footer: './templates/common/footer.hbs',
                        navigation: './templates/common/navigationTemplate.hbs',
                        myPost: './templates/catalog/myPost.hbs'
                    }).then(function () {
                        this.partial('./templates/catalog/myPostsPage.hbs')
                    })
                })
                .catch(notify.handleError);
        });

        //GET comments for current post
        this.get('#/comments/:postId', function (ctx) {
            let postId = ctx.params.postId;
            let postPromise = postsService.getPostById(postId);
            let commentsPromise = commentsService.getPostComments(postId);

            Promise.all([postPromise, commentsPromise])
                .then(([post, comments]) => {
                    post.date = calcTime(post._kmd.ect);
                    post.isAuthor = post._acl.creator === sessionStorage.getItem('userId');
                    comments.forEach((c) => {
                        c.date = calcTime(c._kmd.ect);
                        c.commentAuthor = c._acl.creator === sessionStorage.getItem('userId');
                    });

                    ctx.isAuth = auth.isAuth();
                    ctx.username = sessionStorage.getItem('username');
                    ctx.post = post;
                    ctx.comments = comments;

                    ctx.loadPartials({
                        header: './templates/common/header.hbs',
                        footer: './templates/common/footer.hbs',
                        navigation: './templates/common/navigationTemplate.hbs',
                        currentPostDetail : './templates/catalog/currentPostDetail.hbs',
                        comment: './templates/catalog/comment.hbs'
                    }).then(function () {
                        this.partial('./templates/catalog/postDetail.hbs');
                    })
                })
                .catch(notify.handleError);
        });

        //POST for comment
        this.post('#/createComment', (ctx) => {
            let author = sessionStorage.getItem('username');
            let content = ctx.params.content;
            let postId = ctx.params.postId;

            if (content === '') {
                notify.showError('Cannot add empty comment!');
                return;
            }

            commentsService.createComment(postId, content, author)
                .then(() => {
                    notify.showInfo('Comment created!');
                    ctx.redirect(`#/comments/${postId}`);
                })
                .catch(notify.showError);
        });

        //GET delete comment
        this.get('#/commentDelete/:commentId/post/:postId', (ctx) => {
            let commentId = ctx.params.commentId;
            let postId = ctx.params.postId;

            commentsService.deleteComment(commentId)
                .then(() => {
                    notify.showInfo('Comment deleted.');
                    ctx.redirect(`#/comments/${postId}`);
                })
                .catch(notify.handleError);
        });

        //Show different view if user isAuth
        function displayHome(ctx) {
            if (!auth.isAuth()) {
                ctx.loadPartials({
                    header: './templates/common/header.hbs',
                    footer: './templates/common/footer.hbs',
                    loginForm: './templates/forms/loginForm.hbs',
                    registerForm: './templates/forms/registerForm.hbs'
                }).then(function () {
                    this.partial('./templates/welcome.hbs');
                })
            } else {
                ctx.redirect('#/catalog');
            }
        }

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