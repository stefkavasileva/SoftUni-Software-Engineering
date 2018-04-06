function attachAllEvents() {
    //bind info boxes
    $('#infoBox, #errorBox').on('click', function () {
        $(this).fadeOut();
    });

    //Attach AJAX loading event listener
    $(document).on({
        ajaxStart: function () {$('#loadingBox').show()},
        ajaxStop: function () {$('#loadingBox').hide()}
    })
}