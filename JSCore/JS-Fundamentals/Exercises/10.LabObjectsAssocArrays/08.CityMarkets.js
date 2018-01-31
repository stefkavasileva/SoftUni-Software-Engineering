function main(input) {
    let map = new Map();
    for (let i = 0; i < input.length; i++) {
        let currentArgs = input[i]
            .split(/[->:]/)
            .filter(x => x !== '')
            .map(x => x.trim());

        let town = currentArgs[0];
        let product = currentArgs[1];
        let amount = Number(currentArgs[2]);
        let price = Number(currentArgs[3]);

        if(!map.has(town)){
            map.set(town,new Map())
        }

        if(!map.get(town).has(product)){
            map.get(town).set(product,0);
        }

        map.get(town).set(product,map.get(town).get(product) + (amount * price));
    }

    for (let town of map) {
        console.log(`Town - ${town[0]}`);
        for (let city of town[1]) {
           console.log(`$$$${city[0]} : ${city[1]}`)
        }
    }
}

main(['Sofia -> Laptops HP -> 200 : 2000',
'Sofia -> Raspberry -> 200000 : 1500',
'Sofia -> Audi Q7 -> 200 : 100000',
'Montana -> Portokals -> 200000 : 1',
'Montana -> Qgodas -> 20000 : 0.2',
'Montana -> Chereshas -> 1000 : 0.3']);