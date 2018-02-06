function main(input) {
    let landedPlans = [];
    let departedPlans = [];

    for (let i = 0; i < input.length; i++) {
        let args = input[i].split(' ').filter(x => x !== '');
        let planId= args[0];
        let townName = args[1];
        let passengersCount = Number(args[2]);
        let action = args[3];

        if(action === 'land'){
            let plan = landedPlans.find(x => x.id === planId);
            if(plan !== undefined){
                continue;
            }

            plan = {id: planId, town: townName, passengersCount: passengersCount};
            landedPlans.push(plan);
        }else if(action === 'depart'){
            let plan = landedPlans.find(x => x.id == planId);
            if(plan === undefined){
                continue;
            }

            departedPlans.push(plan);
            plan.id = undefined;
        }
    }

    landedPlans = landedPlans.sort((a,b) => a.id.localeCompare(b.id)).filter(x => x.id !== undefined);
    console.log(`Planes left:`);
    for (let plan of landedPlans) {
        console.log(`- ${plan.id}`);
    }





}

main([
        "Boeing474 Madrid 300 land",
        "AirForceOne WashingtonDC 178 land",
        "Airbus London 265 depart",
        "ATR72 WashingtonDC 272 land",
        "ATR72 Madrid 135 depart"
    ]
);