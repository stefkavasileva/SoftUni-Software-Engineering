let userService = (() => {

    function getAllUsers() {
            return remote.get('user', '', 'kinvey');
    }

    return {
        getAllUsers,
    }
})();