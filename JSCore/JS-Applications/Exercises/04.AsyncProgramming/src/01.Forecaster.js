function attachEvents() {
    const urlLocations = `https://judgetests.firebaseio.com/locations.json`

    $('#submit').on('click', getWeather);

    function getWeather() {
        let locationToGet = $('#location').val();
        $.get(urlLocations)
            .then(getLocations)
            .catch(error);


        function getLocations(locations) {
            let currentLocationCode;

            for (let locObj of locations) {
                if (locationToGet === locObj.name) {
                    currentLocationCode = locObj.code;
                }
            }

            let todayForecast = $.get(`https://judgetests.firebaseio.com/forecast/today/${currentLocationCode}.json`);
            let upcomingForecast = $.get(`https://judgetests.firebaseio.com/forecast/upcoming/${currentLocationCode}.json`);

            Promise.all([todayForecast, upcomingForecast])
                .then(displayForecast)
                .catch(error);

            function displayForecast([today, upcoming]) {
                $('#forecast').show();

                let currentElement = $('#current');

                currentElement.empty();
                currentElement
                    .append($(' <div class="label">Current conditions</div>'))
                    .append($(`<span>`)
                        .addClass('condition symbol')
                        .html(getSymbol(today.forecast.condition)))
                    .append($('<span>')
                        .addClass('condition')
                        .append($('<span>')
                            .addClass('forecast-data')
                            .text(today.name))
                        .append($('<span>')
                            .addClass('forecast-data')
                            .html(`${today.forecast.low}&#176;/${today.forecast.high}&#176;`))
                        .append($('<span>')
                            .addClass('forecast-data')
                            .text(today.forecast.condition)));

                let upcomingElement = $('#upcoming');
                upcomingElement.empty();

                upcomingElement
                    .append($('<div>')
                        .addClass('label')
                        .text('Three-day forecast'));


                for (let currentUpcoming of upcoming.forecast) {

                    upcomingElement.append($('<span>')
                        .addClass('upcoming')
                        .append($(`<span>`)
                            .addClass('symbol')
                            .html(getSymbol(currentUpcoming.condition)))
                        .append($('<span>')
                            .addClass('forecast-data')
                            .html(`${currentUpcoming.low}&#176;/${currentUpcoming.high}&#176;`))
                        .append($('<span>')
                            .addClass('forecast-data')
                            .text(currentUpcoming.condition)));
                }
            }

        }
    }

    function error(error) {

    }

    function getSymbol(condition) {
        switch (condition) {
            case'Sunny':
                return '&#x2600;';
            case'Partly sunny':
                return '&#x26C5;';
            case'Overcast':
                return '&#x2601;';
            case'Rain':
                return '&#x2614;';
        }
    }

}

attachEvents();