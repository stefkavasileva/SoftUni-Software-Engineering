function main(meals, commands) {
    let eatenMealsCount = 0;
    for (let command of commands) {
        let commandArgs = command.split(' ').filter(x => x !== '');
        let commandName = commandArgs[0];

        if(commandName === 'Serve'){
            if(!hasMeal()){
                continue;
            }

            let lastMeal = meals.pop();
            console.log(`${lastMeal} served!`);

        }else if(commandName === 'Add'){
            let mealToBeAdded = commandArgs[1];

            if(mealToBeAdded === undefined){
                continue;
            }

            meals.unshift(mealToBeAdded);

        }else if(commandName === 'Shift'){
            let firstIndex = Number(commandArgs[1]);
            let secondIndex = Number(commandArgs[2]);

            if(!areValidIndexes(firstIndex, secondIndex, meals.length)){
                continue;
            }

            let firstMeal = meals[firstIndex];
            let secondMeal = meals[secondIndex];
            meals[firstIndex] = secondMeal;
            meals[secondIndex] = firstMeal;

        } else if(commandName === 'Eat'){
            if(!hasMeal()){
                continue;
            }

            let firstMeal = meals.shift();
            eatenMealsCount++;
            console.log(`${firstMeal} eaten`);
        }else if(commandName === 'Consume'){
            let firstIndex = Number(commandArgs[1]);
            let secondIndex = Number(commandArgs[2]);

            if(!areValidIndexes(firstIndex, secondIndex, meals.length)){
                continue;
            }

            meals.splice(firstIndex, secondIndex - firstIndex + 1);
            eatenMealsCount += secondIndex - firstIndex + 1;
            console.log(`Burp!`);
        }else if(commandName === `End`) {
            break;
        }
    }

    let result = meals.length === 0 ? `The food is gone` : `Meals left: ${meals.join(', ')}`;
    console.log(result);
    console.log(`Meals eaten: ${eatenMealsCount}`);

    function hasMeal() {
        return meals.length > 0;
    }

    function areValidIndexes(firstIndex, secondIndex, length) {
       let isValidFirstIndex = firstIndex >= 0 && firstIndex < length;
       let isValidSecondIndex = secondIndex >= 0 && secondIndex < length;

       return isValidFirstIndex && isValidSecondIndex;
    }

}

main(['carrots', 'apple', 'beet'],
    ['shift 2 ds',
        'End',]
);