function main(input) {
    let juices = new Map();
    let juiceBottles = new Map();

    for (let i = 0; i < input.length; i++) {
        let args = input[i].split('=>').filter(x => x !== '').map(x => x.trim());
        let fruitName = args[0];
        let quantity = Number(args[1]);

        if (!juices.has(fruitName)) {
            juices.set(fruitName, 0);
        }

        juices.set(fruitName, juices.get(fruitName) + quantity);

        let totalQuantity = juices.get(fruitName);
        let bottles = Math.trunc(totalQuantity / 1000);

        if (bottles > 0) {
            let remainder = Math.trunc(totalQuantity % 1000);
            juices.set(fruitName, remainder);

            if (!juiceBottles.has(fruitName)) {
                juiceBottles.set(fruitName, 0);
            }

            juiceBottles.set(fruitName, juiceBottles.get(fruitName) + bottles);
        }

        juices = Array.from(juiceBottles);
        for (let fruit of juices) {
            console.log(`${fruit[0]} => ${quantity}`);
        }
    }
}

main(['Orange => 2000','Peach => 1432','Banana => 450','Peach => 600','Strawberry => 549']);