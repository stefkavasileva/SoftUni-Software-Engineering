const BASE_URL = 'https://baas.kinvey.com/';
const APP_KEY = 'kid_SJUG61k9G';
const APP_SECRET = 'ded604ed204a4224a054ec5ee7a9cb10';
const AUTH_HEADERS = {'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET)};

function registerUser() {
    let username = $('#formRegister [name="username"]').val();
    let password = $('#formRegister [name="passwd"]').val();

    $.ajax({
        method: 'POST',
        url: BASE_URL + 'user/' + APP_KEY + '/',
        headers: AUTH_HEADERS,
        data: {username, password}
    }).then(function (res) {
        signInUser(res);
    })
        .catch(showErrorMessage)
}

function signInUser(res, message) {
    sessionStorage.setItem('username', res.username);
    sessionStorage.setItem('authToken', res._kmd.authtoken);
    sessionStorage.setItem('userId', res._id);
    showViewHome();
    showHideMenuLinks();
    showInfo('Welcome ' + res.username + '!!!');
}

function loginUser() {
    let username = $('#formLogin [name="username"]').val();
    let password = $('#formLogin [name="passwd"]').val();

    $.ajax({
        method: 'POST',
        url: BASE_URL + 'user/' + APP_KEY + '/login',
        headers: AUTH_HEADERS,
        data: {username, password}
    }).then(function (res) {
        signInUser(res);
    })
        .catch(showErrorMessage)
}

function logoutUser() {
    sessionStorage.clear();
    showViewHome();
    showHideMenuLinks();
    showInfo('Logout success!');
}

function createAd() {
    let title = $('#formCreateAd [name="title"]');
    let description = $('#formCreateAd [name="description"]');
    let datePublished = $('#formCreateAd [name="datePublished"]');
    let price = $('#formCreateAd [name="price"]');
    let image = $('#formCreateAd [name="image"]');

    let advertisement = {
        title: title.val(),
        publisher: sessionStorage.getItem('username'),
        description: description.val(),
        price: price.val(),
        datePublished: datePublished.val(),
        image: image.val()
    };

    $.ajax({
        method: 'POST',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisementsData',
        headers: {'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')},
        data: advertisement
    }).then(function (res) {
        showInfo('Advertisement is added successfully!!!');
        listAds();

        title.val('');
        description.val('');
        datePublished.val('');
        price.val('');
    })
        .catch(showErrorMessage);


}

function listAds() {
    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisementsData',
        headers: {'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')}
    }).then(function (res) {
        showViewAds();
        let table = $('#ads > table');
        table.empty();

        table.append($('<tr>')
            .append($('<th>Title</th>'))
            .append($('<th>Publisher</th>'))
            .append($('<th>Description</th>'))
            .append($('<th>Price</th>'))
            .append($('<th>Date Published</th>'))
            .append($('<th>Actions</th>')));


        res = res.reverse();
        for (let ad of res) {
            let tr = $('<tr>');
            tr.append($('<td>').text(ad.title))
                .append($('<td>').text(ad.publisher))
                .append($('<td>').text(ad.description))
                .append($('<td>').text(ad.price))
                .append($('<td>').text(ad.datePublished));

            let td = $('<td>');
            td.append($('<a href="#">').text('[Read more]')
                .on('click', function () {
                    displayAdvert(ad);
                }));

            if (ad._acl.creator === sessionStorage.getItem('userId')) {
                td.append($('<a href="#">').text('[Delete]')
                    .unbind().on('click', function () {
                        deleteAd(ad);
                    }))
                    .append($('<a href="#">').text('[Edit]')
                        .unbind().on('click', function () {
                            loadAdForEdit(ad);
                        }));
            }

            table.append(tr.append(td));
        }
    })
        .catch(showErrorMessage)
}

function deleteAd(ad) {
    $.ajax({
        method: 'DELETE',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisementsData/' + ad._id,
        headers: {'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')},
    }).then(function () {
        listAds();
        showInfo('Advertisement deleted.');
    })
        .catch(showErrorMessage);
}

function loadAdForEdit(ad) {
    showView('viewEditAd');
    $('#formEditAd input[name=id]').val(ad._id);
    $('#formEditAd [name="title"]').val(ad.title);
    $('#formEditAd [name="description"]').val(ad.description);
    $('#formEditAd [name="datePublished"]').val(ad.datePublished);
    $('#formEditAd [name="price"]').val(ad.price);
    $('#formEditAd [name="image"]').val(ad.image);
}

function editAd() {
    let id = $('#formEditAd [name=id]').val();
    let title = $('#formEditAd [name="title"]').val();
    let description = $('#formEditAd [name="description"]').val();
    let datePublished = $('#formEditAd [name="datePublished"]').val();
    let price = $('#formEditAd [name="price"]').val();
    let image = $('#formEditAd [name="image"]').val();

    let newAd = {title, description, datePublished, price, publisher: sessionStorage.getItem('username'),image};

    $.ajax({
        method: 'PUT',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisementsData/' + id,
        headers: {'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')},
        data: newAd
    }).then(function () {
        listAds();
        showInfo('Advertisement edited!!!')
    }).catch(showErrorMessage)
}

function displayAdvert(ad) {
    $('#vewDetailsAd').empty();

    let advertInfo = $('<div>').append(
        $('<div>').append($('<img>').attr('src', ad.image)),
        $('<br>'),
        $('<label>').text('Title:'),
        $('<h1>').text(ad.title),
        $('<label>').text('Description:'),
        $('<p>').text(ad.description),
        $('<label>').text('Publisher:'),
        $('<div>').text(ad.publisher),
        $('<label>').text('Date:'),
        $('<div>').text(ad.datePublished)
    );

    $('#vewDetailsAd').append(advertInfo);
    showView('vewDetailsAd');
}

function showErrorMessage(err) {
    let errorMsg = JSON.stringify(err)
    if (err.readyState === 0) {
        errorMsg = "Cannot connect due to network error.";
    }

    if (err.responseJSON && err.responseJSON.description) {
        errorMsg = err.responseJSON.description;
    }

    showError(errorMsg);
}
