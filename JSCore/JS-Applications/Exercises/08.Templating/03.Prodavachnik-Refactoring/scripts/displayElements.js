function showView(viewName) {
    $('main > section').hide();
    $('#' + viewName).show();
}

function showMenuLinks() {
    async function f() {
        let header = await $.get('./templates/header-link.hbs');
        let headerTemplate = Handlebars.compile(header);
        let context = {
            checkIfLogged: sessionStorage.getItem('authToken') === null,
            text: `Welcome, ${sessionStorage.getItem('username')} !`
        };
        let compileHBStoHtml = headerTemplate(context);
        $('#menu').empty();
        $('#menu').append(compileHBStoHtml);
        attachHeaderEvenets()
    }

    f();

    function attachHeaderEvenets() {
        //navigation menu link events
        $('#linkHome').on('click', showHomeView);
        $('#linkLogin').on('click', showLoginView);
        $('#linkRegister').on('click', showRegisterView);
        $('#linkListAds').on('click', listAds);
        $('#linkCreateAd').on('click', showCreateAdView);
        $('#linkLogout').on('click', logoutUser);
    }
}

function showInfo(messgae) {
    let infoBox = $('#infoBox');
    infoBox.text(messgae);
    infoBox.show();
    setTimeout(function () {
        $('#infoBox').fadeOut();
    }, 3000)
}

function showError(error) {
    let errorBox = $('#errorBox');
    errorBox.text(error);
    errorBox.show();
}

function showHomeView() {
    showView('viewHome');
}

function showLoginView() {
    showView('viewLogin');
    $('#viewLogin').empty();
    $('#formLogin').trigger('reset');

    async function f() {
        let reigsterLoginCheck = true;
        let login = await $.get('./templates/register-login-view.hbs');
        let loginTemplate = Handlebars.compile(login);
        let contextLogin = {
            reigsterLoginCheck: reigsterLoginCheck
        };
        let compileHBStoHtml = loginTemplate(contextLogin);
        $('#viewLogin').append(compileHBStoHtml);

        attachHeaderEvents()
    }

    f();

    function attachHeaderEvents() {
        $('#buttonLoginUser').on('click', loginUser);
    }
}

function showRegisterView() {
    showView('viewRegister');
    $('#viewRegister').empty();
    $('#formRegister').trigger('reset');

    async function f() {
        let reigsterLoginCheck = false;
        let register = await $.get('./templates/register-login-view.hbs');
        let registerTemplate = Handlebars.compile(register);
        let contextRegister = {
            reigsterLoginCheck: reigsterLoginCheck
        };
        let compileHBStoHtml = registerTemplate(contextRegister);
        $('#viewRegister').append(compileHBStoHtml);

        attachHeaderEvents()
    }

    f();

    function attachHeaderEvents() {
        $('#buttonRegisterUser').on('click', registerUser);
    }
}

function showCreateAdView() {
    showView('viewCreateAd');
    $('#viewCreateAd').empty();
    $('#formCreateAd').trigger('reset');

    async function f() {
        let editCreateCheck = true;
        let create = await $.get('./templates/create-edit-view.hbs');
        let createTemplate = Handlebars.compile(create);
        let contextCreate = {
            editCreateCheck: editCreateCheck
        };
        let compileHBStoHtml = createTemplate(contextCreate);
        $('#viewCreateAd').append(compileHBStoHtml);

        attachHeaderEvents()
    }

    f();

    function attachHeaderEvents() {
        $('#buttonCreateAd').on('click', createAd);
    }
}

async function showEditAdView() {
    showView('viewEditAd');
    $('#viewEditAd').empty();

    async function f() {
        let editCreateCheck = false;
        let edit = await $.get('./templates/create-edit-view.hbs');
        let editTemplate = Handlebars.compile(edit);
        let contextEdit = {
            editCreateCheck: editCreateCheck,
        };
        let compileHBStoHtml = editTemplate(contextEdit);
        $('#viewEditAd').append(compileHBStoHtml);

        attachHeaderEvents()
    }

    await f();

    function attachHeaderEvents() {
        $('#buttonEditAd').on('click', editAd);
    }
}

async function readMoreView(title, author, description, price, date, image, views) {
    showView('viewReadMore');
    $('#viewReadMore').empty();

    async function f() {
        let checkImage = false;
        if (image.length > 0) {
            checkImage = true;
        }

        let readMore = await $.get('./templates/readmore-view.hbs');
        let readMoreTemplate = Handlebars.compile(readMore);
        let contextReadMore = {
            checkImage: checkImage,
            title: title,
            author: author,
            description: description,
            price: price,
            date: date,
            image: image,
            views: views
        };
        let compileHBStoHtml = readMoreTemplate(contextReadMore);
        $('#viewReadMore').append(compileHBStoHtml);

    }

    await f();

}

async function showAdsView(ads) {
    showView('viewAds');
    $('#viewAds').empty();

    if (ads.length > 0) {
        async function f() {
            //check is currentuser author
            ads.forEach(el => {
                if (el._acl.creator === sessionStorage.getItem('userId')) {
                    el.isAuthor = true;
                }
            });
            //format price cuz handlebars cant
            ads.map(el => {
                el.price = Number(el.price).toFixed(2)
            });

            let listAds = await $.get('./templates/display-ads.hbs');
            let listAdsTemplate = Handlebars.compile(listAds);
            let contextListAds = {
                ads: ads
            };
            let compileHBStoHtml = listAdsTemplate(contextListAds);
            $('#viewAds').append(compileHBStoHtml);
            attachEvents();
        }
        await f();

        function attachEvents() {
            $('.btnReadMore').on('click', readMore);
            $('.btnDelete').on('click', deleteAd);
            $('.btnEdit').on('click', loadEdit);
        }
    }
    else {
        $('#viewAds').empty();
        $('#viewAds').append($('<p>No advertisements available.</p>'));
    }
}
