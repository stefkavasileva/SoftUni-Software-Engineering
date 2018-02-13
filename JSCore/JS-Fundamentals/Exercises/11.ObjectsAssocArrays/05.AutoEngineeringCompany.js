/*function main(input) {
    let map = new Map();
    for (let i = 0; i < input.length; i++) {
        let args  = input[i].split('|').filter(x => x !== '').map(x => x.trim());
        let brand = args[0];
        let model = args[1];
        let producedCars = Number(args[2]);

        if(!map.has(brand)){
            map.set(brand,new Map());
        }

        if(!map.get(brand).has(model)){
            map.get(brand).set(model,0);
        }

        map.get(brand).set(model,map.get(brand).get(model) + producedCars);
    }

    for (let brand of map) {
        console.log(brand[0]);
        for (let model of brand[1]) {
            console.log(`###${model[0]} -> ${model[1]}`);
        }
    }
}*/

function printCompanyInfo(input) {
    let cars = [];
    for (let i = 0; i < input.length; i++) {
        let args = input[i].split('|').filter(x => x !== '').map(x => x.trim());
        let brand = args[0];
        let  model = args[1];
        let producedCars = Number(args[2]);
        let car = cars.find(x => x.brand === brand);

        if(car === undefined){
            car = {brand: brand, models: []};
            cars.push(car);
        }

        let carModel = car.models.find(x => x.model === model);
        if(carModel === undefined){
            carModel = {model: model, producedCars: 0};
            car.models.push(carModel);
        }

        carModel.producedCars += producedCars;
    }

    for (let car of cars) {
        console.log(car.brand);
        for (let model of car.models) {
            console.log(`###${model.model} -> ${model.producedCars}`)
        }
    }
}

printCompanyInfo(['Audi | Q7 | 1000',
'Audi | Q7 | 100',
'BMW | X5 | 1000',
'BMW | X6 | 100',
'Citroen | C4 | 123',
'Volga | GAZ-24 | 1000000',
'Lada | Niva | 1000000',
'Lada | Jigula | 1000000',
'Citroen | C4 | 22',
'Citroen | C5 | 10']);