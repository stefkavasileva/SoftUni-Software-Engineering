function main(input) {
    let map = new Map();
    for (let i = 0; i < input.length; i++) {
        let currentArgs = input[i]
            .split('|')
            .filter(x => x !== '')
            .map(x => x.trim());

        let town = currentArgs[0];
        let product = currentArgs[1];
        let price = Number(currentArgs[2]);

        if(!map.has(town)){
            map.set(town,new Map());
        }

        if(!map.get(town).has(product)){
            map.get(town).set(product,price);
        }

        if(map.get(town).get(product) >= price ){
            continue;
        }

            map.get(town).set(product,price);
    }

    for (let town of map) {
        for (let product of town[1]) {
            console.log(`${product[0]} -> ${product[1]} (${town[0]})`);
        }
    }
}

main(['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 3',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10']);