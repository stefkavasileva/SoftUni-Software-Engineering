function getCar(carInfo) {
    let power = carInfo.power;
    let color = carInfo.color;
    let carriage = carInfo.carriage;
    let wheelsize = carInfo.wheelsize;

    let newCar = {
        model: carInfo.model
    };

    if(power <= 90){
        newCar.engine = {
            power:90,
            volume:1800
        }
    }else if(power <= 120){
        newCar.engine = {
            power:120,
            volume:2400
        }
    }else {
        newCar.engine = {
            power:200,
            volume:3500
        }
    }

    newCar.carriage = {
        type:carriage,
        color:color,
    };


    let value = wheelsize;
    if(wheelsize % 2 === 0){
        value -= 1;
    }

    newCar.wheels = [value,value,value,value];

    return newCar;
}

console.log(getCar({ model: 'Opel Vectra',
    power: 110,
    color: 'grey',
    carriage: 'coupe',
    wheelsize: 17 }
));