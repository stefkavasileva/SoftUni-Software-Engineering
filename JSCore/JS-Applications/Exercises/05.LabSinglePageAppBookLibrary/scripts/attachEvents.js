function attachAllEvents() {
    // Bind the navigation menu links
    $("#linkHome").on('click', showHomeView);
    $("#linkLogin").on('click', showLoginView);
    $("#linkRegister").on('click', showRegisterView);
    $("#linkListBooks").on('click', listBooks);
    $("#linkCreateBook").on('click', showCreateBookView);
    $("#linkLogout").on('click', logoutUser);

    // Bind the form submit buttons
    $("#formLogin").on('submit', loginUser);
    $("#formRegister").on('submit', registerUser);
    $("#formCreateBook").on('submit', createBook);
    $("#formEditBook").on('submit', editBook);
    $("form").on('submit', function(event) { event.preventDefault() });

    // Bind the info / error boxes
    $("#infoBox, #errorBox").on('click', function() {
        $(this).fadeOut()
    })

    // Attach AJAX "loading" event listener
    $(document).on({
        ajaxStart: function() { $("#loadingBox").show() },
        ajaxStop: function() { $("#loadingBox").hide() }
    })
}