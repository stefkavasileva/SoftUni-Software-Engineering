function attachEvents() {
    const kinveyAppId = "kid_SJUG61k9G";
    const serviceUrl = "https://baas.kinvey.com/appdata/" + kinveyAppId;
    const kinveyUsername = "guest";
    const kinveyPassword = "guest123";
    const base64auth = btoa(kinveyUsername + ":" + kinveyPassword);
    const authHeaders = {"Authorization": "Basic " + base64auth};

    //  $('.add').on('click', addRecord);
    $('.load').on('click', loadRecords);

    function loadRecords() {
        $.ajax({
            url: serviceUrl + "/biggestCatches",
            headers: authHeaders
        })
            .then(successLoadRecords)
            .catch(error);

        function successLoadRecords(records) {
            let main = $('#main');
            main.empty();
            main.append($('<legend>Catches</legend>'));


            for (let recordObj of records) {
                main
                    .append($('<div id="catches">')
                        .append($('<label>Angler</label>'))
                        .append($(`<input type="text" class="angler" value="${recordObj.angler}"/>`))
                        .append($('<label>Weight</label>'))
                        .append($(`<input type="number" class="weight" value="${recordObj.weight}"/>`))
                        .append($('<label>Species</label>'))
                        .append($(`<input type="text" class="species" value="${recordObj.species}"/>`))
                        .append($('<label>Location</label>'))
                        .append($(`<input type="text" class="location" value="${recordObj.location}"/>`))
                        .append($('<label>Bait</label>'))
                        .append($(`<input type="text" class="bait" value="${recordObj.bait}"/>`))
                        .append($('<label>Capture Time</label>'))
                        .append($(`<input type="number" class="captureTime" value="${recordObj.captureTime}"/>`))
                        .append($('<button class="update">Update</button>')
                            .on('click', updateRecord))
                        .append($('<button class="delete">Delete</button>')
                            .on('click', deleteRecord)));
            }
        }
    }

   /* function addRecord() {
        let angler = $('#addForm input.angler').val();
        let weight = Number($('#addForm input.weight').val());
        let species = $('#addForm input.species').val();
        let location = $('#addForm input.location').val();
        let bait = $('#addForm input.bait').val();
        let captureTime = Number($('#addForm input.captureTime').val());

        let recordToBeAdded = {angler,weight,species,location,bait,captureTime};
        $.ajax({
            type: 'POST',
            url: serviceUrl + "/biggestCatches",
            headers: authHeaders,
            body:JSON.stringify(recordToBeAdded)
        })
            .then(loadRecords)
            .catch(error)
    }
*/
    function updateRecord() {

    }

    function deleteRecord() {

    }



    function error() {

    }
}

attachEvents();