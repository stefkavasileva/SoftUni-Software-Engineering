let flightService = (() => {

    function getPublishFlight() {
        const endpoint = `flights?query={"isPublished":"true"}`;
        return remote.get('appdata', endpoint, 'kinvey');
    }

    function addFlight(isPublished,image,cost,seats,departureDate,departureTime,origin,destination) {
        let data = {isPublished,image,cost,seats,departureDate,departureTime,origin,destination};
        return remote.post('appdata', 'flights', 'kinvey', data);
    }

    function flightDetails(flightId) {
        return remote.get('appdata', `flights/${flightId}`, 'kinvey');
    }

    function editFlight(flightId,isPublished,image,cost,seats,departureDate,departureTime,origin,destination) {
        const endpoint = `flights/${flightId}`;
        let data = { isPublished,image,cost,seats,departureDate,departureTime,origin,destination};
        return remote.update('appdata', endpoint, 'kinvey', data);
    }

    function getMyFlights() {
        let userId = sessionStorage.getItem('userId')
        const endpoint = `flights?query={"_acl.creator":"${userId}"}`;
        return remote.get('appdata', endpoint, 'kinvey');
    }

    function deleteFlight(flightId) {
        const endpoint = `flights/${flightId}`;
        return remote.remove('appdata', endpoint, 'kinvey');
    }

    return {
        getPublishFlight,
        addFlight,
        flightDetails,
        editFlight,
        getMyFlights,
        deleteFlight,
    }
})();