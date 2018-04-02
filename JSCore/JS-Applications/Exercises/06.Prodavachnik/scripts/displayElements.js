function showView(viewName) {
    $('main > section').hide(); // Hide all views
    $('#' + viewName).show(); // Show the selected view only
}

function showHideMenuLinks() {
    $('#menu').show();
    showViewHome();
    if (sessionStorage.getItem('authToken') === null) {
        // No logged in user
        $("#linkHome").show();
        $("#linkLogin").show();
        $("#linkRegister").show();
        $("#linkCreateAd").hide();
        $('#linkListAds').hide('');
        $("#linkLogout").hide();

    } else { // We have logged in user
        $("#linkHome").show();
        $("#linkLogin").hide();
        $("#linkRegister").hide();
        $("#linkCreateAd").show();
        $('#linkListAds').show('');
        $("#linkLogout").show();
       // $('#loggedInUser').text("Welcome, " + sessionStorage.getItem('username') + "!");
    }
}

function showInfo(message) {
    let infoBox = $('#infoBox');
    infoBox.text(message);
    infoBox.show();
    setTimeout(function() {
        $('#infoBox').fadeOut()
    }, 3000)
}

function showError(errorMsg) {
    let errorBox = $('#errorBox');
    errorBox.text("Error: " + errorMsg);
    errorBox.show();
}

function showViewHome() {
    showView('viewHome');
}
function showLoginView(){
    showView('viewLogin');
    $('#formLogin').trigger('reset') //==> remove any values wrote before, it is single page app
}

function showRegisterView() {
    showView('viewRegister');
    $('#formRegister').trigger('reset');
}

function showCreateAdView() {
    showView('viewCreateAd');
}

function showViewAds() {
    showView('viewAds');
}
