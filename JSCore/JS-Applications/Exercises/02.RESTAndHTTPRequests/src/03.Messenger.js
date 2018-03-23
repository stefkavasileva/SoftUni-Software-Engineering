function attachEvents() {
    $('#submit').on('click',submitFun);
    $('#refresh').on('click',refreshFun);

    let messageElement = $('#messages');
    let url = 'https://messenger-43e19.firebaseio.com/messenger.json';

    function submitFun() {
        let author = $('#author').val();
        let content = $('#content').val();
        let data = {author,content,timestamp: Date.now()};

        $.post(url,JSON.stringify(data))
            .then(success)
            .catch(error);

        function success() {
            messageElement.append(`${data.author}: ${data.content}`);
        }
    }

    function refreshFun() {
        $.get(url)
            .then(success)
            .catch(error);
        
        function success(resp) {
            messageElement.text('');
            for (let keyObj of Object.keys(resp)) {
                messageElement.append(`${resp[keyObj].author}: ${resp[keyObj].content}\n`);
            }
        }
    }

    function error() {
        messageElement.append($('<div>').text(`Invalid data`));
    }
}

attachEvents();