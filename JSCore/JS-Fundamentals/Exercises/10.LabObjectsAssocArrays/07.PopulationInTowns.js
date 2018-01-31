function main(input) {
    let townAndPopulation = input
        .map(x => x.split(/<->/).filter(x => x !== ''))
        .reduce((a,b) => a.concat(b));

    let map = new Map();
    for (let i = 0; i < townAndPopulation.length; i+= 2) {
        if(!map.has(townAndPopulation[i])){
            map.set(townAndPopulation[i], Number(townAndPopulation[i + 1]));
            continue;
        }

        map.set(townAndPopulation[i],map.get(townAndPopulation[i]) + Number(townAndPopulation[i + 1]));
    }

    for (let element of map) {
        console.log(`${element[0]}: ${element[1]}`);
    }
}

main(['Sofia <-> 1200000',
'Montana <-> 20000',
'New York <-> 10000000',
'Washington <-> 2345000',
'Las Vegas <-> 1000000']);