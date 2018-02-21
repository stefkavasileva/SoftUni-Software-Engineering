function initializeTable() {
     $('#createLink').on('click',createRecord);
    addRecord('Bulgaria', 'Sofia');
    addRecord('Germany', 'Berlin');
    addRecord('Russia', 'Moscow');

    function addRecord(country,capital) {
       let record = $('<tr>')
           .append($('<td>').text(country))
           .append($('<td>').text(capital))
           .append($('<td>')
               .append($('<a href="#">[Up] <a/>').on('click',up))
               .append($('<a href="#">[Down] </a>').on('click',down))
               .append($('<a href="#">[Delete] <a/>').on('click',deleteRecord)));

       $('#countriesTable').append(record);
       fixRowLinks();
    }

    function createRecord() {
        let country = $('#newCountryText');
        let capital = $('#newCapitalText');
        addRecord(country.val(),capital.val());
        country.val('');
        capital.val('');
        fixRowLinks();
    }
    
    function up() {
        let row = $(this).parent().parent();
        if(row.index() > 2){
            row.insertBefore(row.prev());
            fixRowLinks();
        }
    }
    
    function down() {
       let row = $(this).parent().parent();
       if(!row.is(':last-child')){
           row.insertAfter(row.next());
           fixRowLinks();
       }
    }
    
    function deleteRecord() {
        $(this).parent().parent().fadeOut(function () {
           $(this).parent().parent().remove();
            fixRowLinks();
        });
    }

    function fixRowLinks() {
        $('#countriesTable a').css('display','inline');

        let rows = $('#countriesTable tr');

        $(rows[2]).find('a:contains("Up")').css('display','none');
        $(rows[rows.length - 1]).find('a:contains("Down")').css('display','none');
    }
}
