const BASE_URL = 'https://baas.kinvey.com/';
const APP_KEY = '';
const APP_SECRET = '';
const AUTH_HEADERS = {'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET)};

function registerUser() {
    let username = $('#formRegister input[name=username]').val();
    let password = $('#formRegister input[name=passwd]').val();

    $.ajax({
        method: 'POST',
        url: BASE_URL + 'user/' + APP_KEY + '/',
        headers: AUTH_HEADERS,
        data: {username: username, password: password}
    }).then(function (res) {
        signInUser(res, 'Registration successful.');
    }).catch(handleError);
}

function loginUser() {
    let username = $('#formLogin input[name=username]').val();
    let password = $('#formLogin input[name=passwd]').val();

    $.ajax({
        method: 'POST',
        url: BASE_URL + 'user/' + APP_KEY + '/login',
        headers: AUTH_HEADERS,
        data: {username: username, password: password}
    }).then(function (res) {
        signInUser(res, 'Login successful.');
    }).catch(handleError);
}

function logoutUser() {
    sessionStorage.clear();
    showMenuLinks();
    showHomeView();
    showInfo('Logout successful.')
}

function createAd() {
    let title = $('#formCreateAd input[name=title]').val();
    let description = $('#formCreateAd textarea[name=description]').val();
    let date = $('#formCreateAd input[name=datePublished]').val();
    let price = $('#formCreateAd input[name=price]').val();
    let image = $('#formCreateAd input[name=image]').val();
    let publisher = sessionStorage.getItem('username');

    $.ajax({
        method: 'POST',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisementsData',
        headers: {'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')},
        data: {
            views: 0,
            image: image,
            title: title,
            description: description,
            datePublished: date,
            price: price,
            publisher: publisher
        }
    }).then(function (res) {
        listAds();
    }).catch(handleError);
}

async function loadEdit() {

    let id = $(this).parent().parent().data().id;
    let title = $($(this).parent().parent().children()[0]).text();
    let author = $($(this).parent().parent().children()[1]).text();
    let description = $($(this).parent().parent().children()[2]).text();
    let price = $($(this).parent().parent().children()[3]).text();
    let date = $($(this).parent().parent().children()[4]).text();
    let image = $($(this).parent().parent().children()[6]).text();

    await showEditAdView(id, title, author, description, price, date, image);

    $('#formEditAd input[name=publisher]').val(author);
    $('#formEditAd input[name=id]').val(id);
    $('#formEditAd input[name=title]').val(title);
    $('#formEditAd textarea[name=description]').text(description);
    $('#formEditAd input[name=datePublished]').val(date);
    $('#formEditAd input[name=price]').val(price);
    $('#formEditAd input[name=image]').val(image)


}

function editAd() {

    let id = $('#formEditAd input[name=id]').val();
    let publisher = $('#formEditAd input[name=publisher]').val();

    let changedTitle = $('#formEditAd input[name=title]').val();
    let changedDescription = $('#formEditAd textarea[name=description]').val();
    let changedPrice = $('#formEditAd input[name=price]').val();
    let changedDate = $('#formEditAd input[name=datePublished]').val();
    let changedImage = $('#formEditAd input[name=image]').val();

    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisementsData/' + id,
        headers: {'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')},
    }).then(function (res) {
        let views = Number(res.views);

        $.ajax({
            method: 'PUT',
            url: BASE_URL + 'appdata/' + APP_KEY + '/ads/' + id,
            headers: {'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')},
            data: {
                views: views,
                image: changedImage,
                title: changedTitle,
                description: changedDescription,
                price: changedPrice,
                datePublished: changedDate,
                publisher: publisher
            }
        }).then(function (res) {
            listAds();
            showInfo('AD updated.')
        }).catch(handleError);
    });


}

function deleteAd() {
    let id = $(this).parent().parent().data().id;
    $.ajax({
        method: 'DELETE',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisementsData/' + id,
        headers: {'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')},
    }).then(function () {
        listAds();
        showInfo('AD deleted.')
    }).catch(handleError);
}

function readMore() {

    let id = $(this).parent().parent().data().id;
    let title = $($(this).parent().parent().children()[0]).text();
    let author = $($(this).parent().parent().children()[1]).text();
    let description = $($(this).parent().parent().children()[2]).text();
    let price = $($(this).parent().parent().children()[3]).text();
    let date = $($(this).parent().parent().children()[4]).text();
    let image = $($(this).parent().parent().children()[6]).text();

    let views;

    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisementsData/' + id,
        headers: {'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')},
    }).then(function (res) {
        views = Number(res.views);
        views++;

        readMoreView(title, author, description, price, date, image, views);

        $.ajax({
            method: 'PUT',
            url: BASE_URL + 'appdata/' + APP_KEY + '/advertisementsData/' + id,
            headers: {'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')},
            data: {
                views: views,
                image: image,
                title: title,
                description: description,
                datePublished: date,
                price: price,
                publisher: author
            }
        })

    }).catch(handleError);

}

function listAds() {
    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisementsData',
        headers: {'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')},
    }).then(function (res) {
        displayAds(res);
    }).catch(handleError);

    function displayAds(res) {
        let sortedAds = res.sort((a, b) => {
            return Number(b.views) - Number(a.views);
        });
        showAdsView(sortedAds);
    }

}

function signInUser(res, msg) {

    sessionStorage.setItem('username', res.username);
    sessionStorage.setItem('userId', res._id);
    sessionStorage.setItem('authToken', res._kmd.authtoken);

    showHomeView();
    showMenuLinks();
    showInfo(msg);
}

function handleError(err) {
    let errorMsg = JSON.stringify(err);
    if (err.readyState === 0) {
        errorMsg = "Cannot connect due to network error.";
    }
    if (err.responseJSON && err.responseJSON.description) {
        errorMsg = err.responseJSON.description;
    }
    showError(errorMsg);
}