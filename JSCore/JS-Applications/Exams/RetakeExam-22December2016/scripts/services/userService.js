let userService = (() => {
    function getParticularUser(userId) {
        return remote.get('user', `${userId}`, 'kinvey');
    }

    function updateParticularUser(userId, username, name, cart) {
        let data = {username, name, cart};
        return remote.update('user', `${userId}`, 'kinvey', data);
    }

    function addUserToCollection(username, password, name, cart) {
        let data = {username, password, name, cart};
        remote.post('appdata', 'users', 'kenvey', data);
    }

    return {
        getParticularUser,
        updateParticularUser,
        addUserToCollection,
    }
})();