function getPersonalInfo(name, age, weight, height) {
    let person = {
        name:name,
        personalInfo:{
            age:age,
            weight: weight,
            height: height,
        },
        BMI: Math.round(weight / Math.pow(height /100,2)),
    };

    person['status'] = getStatus(person.BMI);

    if(person.status === 'obese'){
        person['recommendation'] = 'admission required';
    }

    return person;

    function getStatus(BMI) {
        if(BMI < 18.5){
            return 'underweight';
        }

        if(BMI < 25){
            return 'normal';
        }

        if(BMI < 30){
            return 'overweight';
        }

        if(BMI >= 30){
            return 'obese';
        }
    }
}

getPersonalInfo('Honey Boo Boo', 9, 57, 137);