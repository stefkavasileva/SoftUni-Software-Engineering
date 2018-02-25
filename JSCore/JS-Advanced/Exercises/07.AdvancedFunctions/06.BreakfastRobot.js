(function solution() {
    let stock = {};
    let products = {
        apple:{
            carb:1,
            flavour:2
        },
        coke:{
            carb:10,
            flavour:20
        },
        burger :{
            carb:5,
            fat:7,
            flavour:3
        },
        omelet :{
            protein:5,
            fat:1,
            flavour:1
        },
        cheverme  :{
            protein:10,
            carb: 10,
            fat:10,
            flavour:10
        }
    }
    
    return function (command) {
        let commandArgs = command.split(' ');
        let commandName = commandArgs;
        if(commandName === 'restock'){
            if(!stock.hasOwnProperty(commandArgs[1])){
                stock[commandArgs[1]] = 0;
            }

            stock[commandArgs[1]] += Number(commandArgs[2]);
        }else if(commandName === 'prepare'){
            let productQuantity = Number(commandArgs[2]);
            
        }
    }
})();

let manager =  solution();
manager(); //<==command