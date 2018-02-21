function createBook(selector,titleName,authorName,isbn) {
    let bookGenerator = (function () {
        let id = 1;
        return function (selector,titleName,authorName,isbn) {
            let selectedElement = $(selector);
            let bookElement = $('<div>')
                .attr('id',`book${id}`)
                .css('border','none');

            bookElement.append($('<p>')
                .addClass('title')
                .text(titleName))
                .append($('<p>')
                    .addClass('author')
                    .text(authorName))
                .append($('<p>')
                    .addClass('isbn')
                    .text(isbn))
                .append($('<button>')
                    .text('Select')
                    .on('click',() => {
                        bookElement.css('border','2px solid blue')
                    }))
                .append($('<button>')
                    .text('Deselect')
                    .on('click',() => {
                        bookElement.css('border','none')
                    }));

            selectedElement.append(bookElement);
            id++;
        }
    }());

    bookGenerator(selector,titleName,authorName,isbn);
}
