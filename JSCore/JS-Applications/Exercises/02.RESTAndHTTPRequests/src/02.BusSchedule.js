function solve() {
    let nextStation;
    let currentId = 'depot'; //==> The ID of the first stop is "depot".
    let departBtn = $('#depart');
    let arriveBtn = $('#arrive');
    let infoSpan = $('#info span.info');

    function depart() {
        let url = `https://judgetests.firebaseio.com/schedule/${currentId}.json`;

        $.get(url)
            .then(success)
            .catch(error);

        function success(resp) {
            departBtn.prop('disabled', true);
            arriveBtn.prop('disabled', false);

            infoSpan.text(`Next stop ${resp['name']}`);
            currentId = resp['next'];
            nextStation = resp['name'];
        }

        function error() {
            departBtn.prop('disabled', true);
            arriveBtn.prop('disabled', true);
        }
    }

    function arrive() {
        departBtn.prop('disabled', false);
        arriveBtn.prop('disabled', true);
        infoSpan.text(`Arriving at ${nextStation}`);
    }

    return {
        depart,
        arrive
    };
}

let result = solve();