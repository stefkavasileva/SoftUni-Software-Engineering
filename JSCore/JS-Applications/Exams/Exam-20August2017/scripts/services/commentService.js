let commentsService = (() => {

    function createComment(postId, content, author) {
        let data = {author, content, postId};
        return remote.post('appdata', 'comments', 'kinvey', data);
    }

    function deleteComment(commentId) {
        const endpoint = `comments/${commentId}`;
        return remote.remove('appdata', endpoint, 'kinvey');
    }

    function getPostComments(postId) {
        const endpoint = `comments?query={"postId":"${postId}"}&sort={"_kmd.ect": -1}`;

        return remote.get('appdata', endpoint, 'kinvey');
    }

    return {
        createComment,
        deleteComment,
        getPostComments
    }
})();