function attachEvents() {
    $('#btnCreate').on('click', create);
    $('#btnLoad').on('click', load);

    let phoneBookElement = $('#phonebook');
    let url = 'https://phonebook-b7a31.firebaseio.com/phonebook';

    function load() {
        phoneBookElement.empty();
        $.get(url + '.json')
            .then(success)
            .catch(error);

        function success(resp) {
            for (let key in resp) {
                phoneBookElement
                    .append($('<li>')
                    .text(`${resp[key].person}: ${resp[key].phone} `)
                    .append($('<button>')
                        .on('click', deleteContact.bind(this, key))
                        .text('Delete')));
            }
        }
    }

    function deleteContact(key) {
        $.ajax({method: 'DELETE', url: url + '/' + key + '.json'})
            .then(load)
            .catch(error)
    }

    function create() {
        let personElement = $('#person');
        let phoneElement = $('#phone');

        let person = personElement.val();
        let phone = phoneElement.val();
        let data = {person, phone};

        $.post(url + '.json', JSON.stringify(data))
            .then(success)
            .catch(error);

        personElement.val('');
        phoneElement.val('');

        function success(resp) {
            phoneBookElement.append($('<li>')
                .text(`${person}: ${phone} `)
                .append($('<button>').text('Delete')));
        }
    }


    function error() {
        phoneBookElement.append($('<li>').text('Error'))
    }
}

attachEvents();