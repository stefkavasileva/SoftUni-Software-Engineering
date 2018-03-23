function getInfo() {
    let ulBuses = $('#buses');
    let idValue = $('#stopId').val();
    let divStopName = $('#stopName');

    let url = `https://judgetests.firebaseio.com/businfo/${idValue}.json`;

    $.get(url)
        .then(success)
        .catch(error);

    function success(resp) {
        ulBuses.empty();
        divStopName.text(resp['name']);

        let busesObj = resp['buses'];
        for (let key of Object.keys(busesObj)) {
            ulBuses.append($('<li>')
                .text(`Bus ${key} arrives in ${busesObj[key]} minutes`))
        }
    }

    function error() {
        ulBuses.empty();
        divStopName.text('Error');
    }
}