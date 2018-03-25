function loadCommits() {
    let userName = $('#username');
    let repo = $('#repo');
    let url = `https://api.github.com/repos/${userName.val()}/${repo.val()}/commits`;
    let commitsUl = $('#commits');
    commitsUl.empty();
    $.get(url)
        .then(success)
        .catch(error);

    function success(commits) {
        for (let commitObj of commits) {
            commitsUl.append($('<li>').text(`${commitObj.commit.author.name}: ${commitObj.commit.message}`));
        }
    }

    function error(error) {
        commitsUl.append($('<li>').text(`Error: ${error.status} (${error.statusText})"`));
    }
}

loadCommits();