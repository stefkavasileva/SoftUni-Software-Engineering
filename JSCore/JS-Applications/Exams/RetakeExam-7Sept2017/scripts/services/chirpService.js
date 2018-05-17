let chirp = (() => {

    function createChirp(text) {
        let author = sessionStorage.getItem('username');
        let data = {text, author};
        return remote.post('appdata', 'chirps', 'kinvey', data);
    }

    function deleteMessage(chirpId) {
        const endpoint = `chirps/${chirpId}`;
        return remote.remove('appdata', endpoint, 'kinvey');
    }

    function getUserChirps(username) {
        const endpoint = `chirps?query={"author":"${username}"}&sort={"_kmd.ect": 1}`;
        return remote.get('appdata', endpoint, 'kinvey');
    }

    function listAllChirpsFromSubscriptions(subs) {
        const endpoint = `chirps?query={"author":{"$in": ${subs}}}&sort={"_kmd.ect": 1}`;
        return remote.get('appdata', endpoint, 'kinvey');
    }

    function countChirps(username) {
        const endpoint = `chirps?query={"author":"${username}"}`;
        return remote.get('appdata', endpoint, 'kinvey');
    }

    function countFollowing(username) {
        const endpoint = `?query={"username":"username"}`;
        return remote.get('user', endpoint, 'kinvey');
    }

    function countFollowers(username) {
        const endpoint = `?query={"subscriptions":"username"}`;
        return remote.get('user', endpoint, 'kinvey');
    }

    function discoverPage() {
        return remote.get('user', 'kinvey');
    }

    function follow(userId) {
        const endpoint = `posts/${postId}`;
        let data = {author, title, description, url, imageUrl};
        return remote.update('appdata', endpoint, 'kinvey', data);
    }


    return {
        createChirp,
        deleteMessage,
        getUserChirps,
        listAllChirpsFromSubscriptions,
        countChirps,
        countFollowing,
        countFollowers,
        discoverPage,
        follow,
    }
})();