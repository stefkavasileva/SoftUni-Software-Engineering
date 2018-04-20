let messageService = (() => {

    function getAllMessageByUser(username) {
        const endpoint = `messages?query={"recipient_username":"${username}"}`;
        return remote.get('appdata', endpoint, 'kinvey');
    }

    function getAllMessageByUserSender(username) {
        const endpoint = `messages?query={"sender_username":"${username}"}`;
        return remote.get('appdata', endpoint, 'kinvey');
    }

    function getAllMessage() {
        return remote.get('appdata', 'messages', 'kinvey');
    }

    function sendMessage(sender_username,sender_name,recipient_username,text) {
        let data = {sender_username,sender_name,recipient_username,text };
        return remote.post('appdata', 'messages', 'kinvey', data);
    }
    function deleteMessage(messageId) {
        const endpoint = `messages/${messageId}`;
        return remote.remove('appdata', endpoint, 'kinvey');
    }

    //messages?query={"sender_username":"username"}

    return {
        getAllMessage,
        getAllMessageByUser,
        getAllMessageByUserSender,
        deleteMessage,
        sendMessage
    }
})();