class PaymentManager {
    constructor(title) {
        this.title = title;
        this.table = this.createTable();
    }

    render(id) {
        $(`#${id}`).append(this.table);
    }

    createTable() {
        let table = $('<table>');
        let caption = $('<caption>')
            .text(this.title + ' Payment Manager');

        let thead = $('<thead>')
            .append($('<tr>')
                .append($('<th>')
                    .addClass('name')
                    .text('Name'))
                .append($('<th>')
                    .addClass('category')
                    .text('Category'))
                .append($('<th>')
                    .addClass('price')
                    .text('Price'))
                .append($('<th>')
                    .text('Actions')));

        let tbody = $('<tbody>').addClass('payments');

        let tfoot = $('<tfoot >')
            .addClass('input-data')
            .append($('<tr>')
                .append($('<td>')
                    .append($('<input>')
                        .attr('name', 'name')
                        .attr('type', 'text')))
                .append($('<td>')
                    .append($('<input>')
                        .attr('name', 'category')
                        .attr('type', 'text')))
                .append($('<td>')
                    .append($('<input>')
                        .attr('name', 'price')
                        .attr('type', 'number')))
                .append($('<td>')
                    .append($('<button>')
                        .on('click', this.addRow)
                        .text('Add'))));

        table.append(caption)
            .append(thead)
            .append(tbody)
            .append(tfoot);

        return table;
    }


    addRow() {
        let name = $(this).parent().parent().find('input[name=\'name\']');
        let category =$(this).parent().parent().find('input[name=\'category\']');
        let price = $(this).parent().parent().find('input[name=\'price\']');

        if(name.val() === '' || category.val() === '' || price.val() === '' || isNaN(price.val())) return;

        let tr = $('<tr>')
            .append($('<td>').text(name.val()).attr('type','text'))
            .append($('<td>').text(category.val()).attr('type','text'))
            .append($('<td>').text(Number(price.val())).attr('type','number'))
            .append($('<td>')
                .append($('<button>')
                    .on('click', function (){
                        $(this).parent().parent().remove();
                    })
                    .text('Delete')));

        let currentTable = $(this)
            .parent()
            .parent()
            .parent()
            .parent().parent().find('tbody');

        currentTable.append(tr);
        name.val('');
        category.val('');
        price.val('');
    }

}