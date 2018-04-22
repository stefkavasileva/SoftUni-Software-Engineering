let userService = (() => {
    function getParticularUser(userId) {
        return remote.get('appdata', `/users${userId}`, 'kinvey');
    }

    function updateParticularUser(userId, username, name, cart) {
        let data = {username, name, cart};
        return remote.update('appdata', `/users${userId}`, 'kinvey', data);
    }

    return {
        getParticularUser,
        updateParticularUser,
    }
})();