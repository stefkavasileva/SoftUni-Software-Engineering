function increment(selector) {
    let element = $(selector);

    let textArea = $('<textarea>')
        .addClass('counter')
        .attr('disabled',true)
        .text(0);

    let buttonIncrement = $('<button>')
        .addClass('btn')
        .attr('id','incrementBtn')
        .text('Increment')
        .on('click',increment);
    
    let buttonAdd = $('<button>')
        .addClass('btn')
        .attr('id','addBtn')
        .text('Add')
        .on('click',add);

    let ul = $('<ul>')
        .addClass('results');

    element.append(textArea);
    element.append(buttonIncrement);
    element.append(buttonAdd);
    element.append(ul);

    function increment() {
        let textArea = $('textarea.counter');
        textArea.val(Number(textArea.val()) + 1);
    }
    
    function add() {
        let textAreaVal = $('textarea.counter').val();
        $('.results').append($('<li>').text(textAreaVal));
    }
}
