function loadRepos() {
    let reposElement = $("#repos");
    let usernameVal = $('#username').val();
    let url = `https://api.github.com/users/${usernameVal}/repos`;

    reposElement.empty();

    $.ajax({
        url,
        success: displayRepos,
        error: displayError
    });

    function displayRepos(res) {
        for (let repo of res) {
            let link = $('<a>').text(repo.full_name);
            link.attr('href', repo.html_url);

            reposElement.append($('<li>').append(link));
        }
    }

    function displayError(err) {
        reposElement.append($(`<li>`).text('Error'));
    }

}
