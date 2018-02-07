function getReportOfAirport(planes) {
    let airport = []; // => id and action of a plan
    let towns = [] // => name, arrivals and departures and set of a plans

    for (let currentPlan of planes) {
        let planArgs = currentPlan
            .split(' ')
            .filter(x => x !== '');

        let [planId,townName,passerngersCount,action] = [planArgs[0], planArgs[1],Number(planArgs[2]),planArgs[3]];

        let plan = airport.find(x => x.id == planId);

        if(plan === undefined && action === 'depart'){
            continue;
        }

        if((plan === undefined && action === 'land') || (plan.action === 'depart' && action === 'land')){
            plan = {id:planId, action: action};
            airport.push(plan);
        }else if(plan && action === 'depart'){
            plan.action = 'depart';
        }else {
            continue;
        }

        let town = towns.find(x => x.name === townName);
        if(!town){
           town = {name: townName, arrivals: 0,departures: 0, planes: new Set()}
           towns.push(town);
        }

        if(plan.action === 'land'){
            town.arrivals += passerngersCount;
        }else if(plan.action === 'depart'){
            town.departures += passerngersCount;
        }

        town.planes.add(plan.id);
    }

    let planesLeft = airport
        .filter(x => x.action === 'land')
        .sort((a,b) => a.id.localeCompare(b.id));

    console.log(`Planes left:`);
    planesLeft.forEach(x => console.log(`- ${x.id}`));

    let sortedTown = towns
        .sort(sortByArrivalsAndName);

    for (let town of sortedTown) {
        console.log(town.name);
        console.log(`Arrivals: ${town.arrivals}`);
        console.log(`Departures: ${town.departures}`);
        console.log(`Planes:`);

        let currentPlanes = [...town.planes].sort((a,b) => a.localeCompare(b));
        currentPlanes.forEach(x =>   console.log(`-- ${x}`))
    }

    function sortByArrivalsAndName(a,b) {
        let arrivalsA = a.arrivals;
        let arrivalsB = b.arrivals;
        let firstCriteria = arrivalsB - arrivalsA;
        if(firstCriteria === 0){
            let nameA = a.name;
            let nameB = b.name;
            return nameA.localeCompare(nameB);
        }

        return firstCriteria;
    }
}

getReportOfAirport([
    "Airbus Paris 356 land",
    "Airbus London 321 land",
    "Airbus Paris 213 depart",
    "Airbus Ljubljana 250 land"
]);