function attachEvents() {
    const serviceUrl = "https://baas.kinvey.com/appdata/kid_SJUG61k9G/biggestCatches";
    const kinveyUsername = "guest";
    const kinveyPassword = "guest123";
    const base64auth = btoa(kinveyUsername + ":" + kinveyPassword);
    const authHeaders = {"Authorization": "Basic " + base64auth};

    $('.add').on('click', addRecord);
    $('.load').on('click', loadRecords);

    function loadRecords() {
        $.get({
            url: serviceUrl,
            headers: authHeaders,
        })
            .then(successLoadRecords)
            .catch(error);

        function successLoadRecords(records) {
            let main = $('#main');
            main.empty();
            main.append($('<legend>Catches</legend>'));


            for (let recordObj of records) {
                main
                    .append($('<div>').addClass("catch").attr("data-id", recordObj._id)
                        .append($('<label>Angler</label>'))
                        .append($(`<input type="text" class="angler" value="${recordObj.angler}"/>`))
                        .append($('<label>Weight</label>'))
                        .append($(`<input type="number" class="weight" value="${Number(recordObj.weight)}"/>`))
                        .append($('<label>Species</label>'))
                        .append($(`<input type="text" class="species" value="${recordObj.species}"/>`))
                        .append($('<label>Location</label>'))
                        .append($(`<input type="text" class="location" value="${recordObj.location}"/>`))
                        .append($('<label>Bait</label>'))
                        .append($(`<input type="text" class="bait" value="${recordObj.bait}"/>`))
                        .append($('<label>Capture Time</label>'))
                        .append($(`<input type="number" class="captureTime" value="${Number(recordObj.captureTime)}"/>`))
                        .append($('<button class="update">Update</button>')
                            .on('click', updateRecord))
                        .append($('<button class="delete">Delete</button>')
                            .on('click',deleteRecord)));
            }
        }
    }

    function addRecord() {
        let angler = $('#addForm input.angler');
        let weight = $('#addForm input.weight');
        let species = $('#addForm input.species');
        let location = $('#addForm input.location');
        let bait = $('#addForm input.bait');
        let captureTime = $('#addForm input.captureTime');

        let recordToBeAdded = {
            angler: angler.val(),
            weight: Number(weight.val()),
            species: species.val(),
            location: location.val(),
            bait: bait.val(),
            captureTime: Number(captureTime.val())
        };

        $.ajax({
            url: serviceUrl,
            type: 'POST',
            headers: {"Authorization": "Basic " + base64auth, "Content-type": "application/json"},
            data: JSON.stringify(recordToBeAdded)
        })
            .then(loadRecords)
            .catch(error);

        angler.val('');
        weight.val('');
        species.val('');
        location.val('');
        bait.val('');
        captureTime.val('');
    }

    function updateRecord() {
        let inputs = $(this).parent().find('input');
        let catchId = $(this).parent().attr('data-id');

        let request = {
            url: serviceUrl + "/" + catchId,
            method: "PUT",
            headers: {"Authorization": "Basic " + base64auth, "Content-type": "application/json"},
            data: JSON.stringify({
                angler: $(inputs[0]).val(),
                weight: $(inputs[1]).val(),
                species: $(inputs[2]).val(),
                location: $(inputs[3]).val(),
                bait: $(inputs[4]).val(),
                captureTime: $(inputs[5]).val()
            })
        };

        $.ajax(request)
            .then(loadRecords)
    }

    function deleteRecord() {
        let catchId = $(this).parent().attr('data-id');

        $.ajax({
            url: serviceUrl + "/" + catchId,
            method: "DELETE",
            headers: authHeaders
        }).then(loadRecords)
            .catch(error)
    }
}

// not working in judge system ==> https://judge.softuni.bg/Contests/Compete/Index/361#1