let chirpService = (() => {

    function getAllChirps(subscriptions ){
        const endpoint = `chirps?query={"author":{"$in": [${subscriptions}]}}&sort={"_kmd.ect": 1}}`;
        return remote.get('appdata', endpoint, 'kinvey');
    }

    function createChirp(author, text) {
        let data = {author,text};
        return remote.post('appdata', 'chirps', 'kinvey', data);
    }

    function deleteChirp(chirpId) {
        const endpoint = `chirps/${commentId}`;
        return remote.remove('appdata', endpoint, 'kinvey');
    }

    function getMyPosts(username) {
        const endpoint = `chirps?query={"author":"${username}"}&sort={"_kmd.ect": 1}`;
        return remote.get('appdata', endpoint, 'kinvey');
    }

    return {
        getAllChirps
    }
})();