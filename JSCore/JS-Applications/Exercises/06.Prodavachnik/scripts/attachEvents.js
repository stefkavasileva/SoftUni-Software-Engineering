function attachAllEvents() {
    //navigation menu links
    $('#linkHome').on('click', showViewHome);
    $('#linkLogin').on('click', showLoginView);
    $('#linkRegister').on('click', showRegisterView);
    $('#linkCreateAd').on('click', showCreateAdView);
    $('#linkLogout').on('click', logoutUser);
    $('#linkListAds').on('click', listAds);

    $("#buttonLoginUser").unbind().on('click', loginUser);
    $("#buttonRegisterUser").unbind().on('click', registerUser);
    $("#buttonCreateAd").unbind().on('click', createAd);
    $('#buttonEditAd').unbind().on('click', editAd);


    //$("form").on('submit', function(event) { event.preventDefault() });

    // Bind the info / error boxes
    $("#infoBox, #errorBox").on('click', function () {
        $(this).fadeOut()
    });

    // Attach AJAX "loading" event listener
    $(document).on({
        ajaxStart: function () {
            $("#loadingBox").show()
        },
        ajaxStop: function () {
            $("#loadingBox").hide()
        }
    });
}