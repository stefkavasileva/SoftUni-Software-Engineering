let result =(function solve() {
    let robot ={
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0,
    };
    let products = {
        apple: {
            carbohydrate: 1,
            flavour: 2
        },
        coke:{
            carbohydrate: 10,
            flavour: 20
        },
        burger:{
            carbohydrate: 5,
            fat: 7,
            flavour: 3
        },
        omelet:{
            protein: 5,
            fat: 1,
            flavour: 1
        },
        cheverme:{
            protein: 10,
            carbohydrate: 10,
            fat: 10,
            flavour: 10
        }
    };

    return function (input) {
        let commandArgs = input.split(' ');
        let commandName = commandArgs[0];
        if(commandName === 'restock'){
            let element = commandArgs[1];
            let quantity = Number(commandArgs[2]);
            robot[element] += quantity;
            return 'Success';
        }else if(commandName === 'prepare'){
            let selectedProduct = commandArgs[1];
            let selectedProductQuantity = Number(commandArgs[2]);
            let currentProductStats = products[selectedProduct];

            let canProductBeCooked = true;
            for (let microElement in currentProductStats) {
                if(currentProductStats.hasOwnProperty(microElement)){
                    let microElementQuantity = currentProductStats[microElement];
                    if(robot[microElement] < microElementQuantity * selectedProductQuantity){
                        canProductBeCooked = false;
                        return `Error: not enough ${microElement} in stock`;
                    }
                }
            }

            if(canProductBeCooked){
                for (let microElement in currentProductStats) {
                    if(currentProductStats.hasOwnProperty(microElement)){
                        let microElementQuantity = currentProductStats[microElement];
                        robot[microElement] -= microElementQuantity * selectedProductQuantity;
                    }
                }
                return 'Success';
            }
        }else if(commandName === 'report'){
            return `protein=${robot.protein} carbohydrate=${robot.carbohydrate} fat=${robot.fat} flavour=${robot.flavour}`;
        }
    }
})();

result('prepare cheverme 1'),
result('restock protein 10'),
result('prepare cheverme 1'),
result('restock carbohydrate 10'),
result('prepare cheverme 1'),
result('restock fat 10'),
result('prepare cheverme 1'),
result('restock flavour 10'),
result('prepare cheverme 1'),
result('report');

