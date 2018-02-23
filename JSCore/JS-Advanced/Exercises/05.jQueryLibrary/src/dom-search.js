//60/100
function domSearch(selector,isCaseSensitive) {
    getSkeleton();

    function search(event) {
        let searchValue = $(event.target).val();
        let allItems = $('.list-item strong').toArray();

        if(searchValue === undefined || searchValue === ''){
            for (let item of allItems) {
                $(item).parent().css('display','');
            }

            return;
        }

        if(!isCaseSensitive){
            searchValue = searchValue.toLowerCase();
        }


        for (let item of allItems) {
            let itemVal = $(item).text();
            if(!isCaseSensitive){
                itemVal = itemVal.toLowerCase();
            }

            if(itemVal.indexOf(searchValue) < 0){
                $(item).parent().css('display','');
            }else{
                $(item).parent().css('display','none')
            }
        }


    }

    function removeText() {
        $(this).parent().remove();
    }

    function addText(event) {
        let li = $('<li>')
            .addClass('list-item');

        let aTag = $('<a>X</a>')
            .prop('href','#')
            .addClass('button')
            .on('click',removeText);

        let inputValue = $('.add-controls input').val();
        let element = $(`<strong>${inputValue}</strong>`);

        $(li).append($(aTag));
        $(li).append($(element));
        $('.items-list').append(li);

        event.preventDefault();
    }

    function getSkeleton() {
        getAddBox();
        getSearchBox();
        getResultControl();
    }

    function getResultControl() {
        let container = $(selector);

        let div = $('<div>')
            .addClass('result-controls');

        let ul = $('<ul>')
            .addClass('items-list');

        $(div).append($(ul));
        $(container).append(div);
    }

    function getSearchBox() {
        let container = $(selector);

        let div = $('<div>')
            .addClass('search-controls');

        let label = $('<label>Search: </label>');
        let input = $('<input>')
            .attr('id','search-text')
            .on('input',search);

        $(label).append($(input));
        $(div).append(label);
        container.append(div);
    }

    function getAddBox() {
        let container = $(selector)
            .addClass('items-control');

        let addDiv = $('<div>')
            .addClass('add-controls');

        let label = $('<lable>Enter text: </lable>');
        let input = $('<input>');

        let aTag = $('<a>Add</a>')
            .addClass('button')
            .prop('href','#')
            .css('display','inline-block')
            .on('click',addText);

        $(container).append($(addDiv));
        $(addDiv).append($(label));
        $(addDiv).append($(input));
        $(addDiv).append($(aTag));
    }
}

//100/100
/*function domSearch(selector, caseType) {
    let addControls = $('<div>')
        .addClass('add-controls')
        .append($('<label>').text('Enter text:').append($('<input>')))
        .append($('<a>')
            .addClass('button')
            .css('display', 'inline-block')
            .text('Add')
            .click(function () {
                let elementText = $('label input');
                let newElement = $('<li>')
                    .addClass('list-item')
                    .append($('<a>').addClass('button').text('X').click(function () {
                        $(this).parent().remove();
                    }))
                    .append($('<strong>').text(elementText.val().trim()));

                $('ul.items-list').append(newElement);
                elementText.val('');
            }));

    let searchControls = $('<div>')
        .addClass('search-controls')
        .append($('<label>').text('Search:').append($('<input>')
            .on('input', function () {
                let needle = $(this).val();
                let items = $('.list-item strong').toArray();
                for (let item of items) {
                    let current = $(item);

                    if (caseType) {
                        if (current.text().indexOf(needle) < 0) {
                            current.parent().css('display', 'none')
                        } else {
                            current.parent().css('display', '')
                        }
                    } else {
                        if (current.text().toLowerCase().indexOf(needle.toLowerCase()) < 0) {
                            current.parent().css('display', 'none')
                        } else {
                            current.parent().css('display', '')
                        }
                    }

                }
            })));

    let resultControls = $('<div>').addClass('result-controls')
        .append($('<ul>').addClass('items-list'));

    $(selector)
        .append(addControls)
        .append(searchControls)
        .append(resultControls);
}*/