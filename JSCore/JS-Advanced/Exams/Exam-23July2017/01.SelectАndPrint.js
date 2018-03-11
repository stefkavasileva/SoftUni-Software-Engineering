function move(command) {
    if(command === 'right'){
        let availableTowns = $('#available-towns');
        let selectedElement = $('#available-towns :selected');
        availableTowns.find('option:selected').remove().end();

        $('#selected-towns').append(selectedElement);

    }else if(command === 'left'){
        let selectedTowns = $('#selected-towns');
        let selectedElement = $('#selected-towns :selected');
        selectedTowns.find('option:selected').remove().end();

        $('#available-towns').append(selectedElement);
    }else if(command === 'print'){
        let selectedTowns = $('#selected-towns option');
        let selectedTownsText = [];
        for (let town of selectedTowns) {
            selectedTownsText.push($(town).text());
        }

        $('#output').text(selectedTownsText.join('; '));
    }
}