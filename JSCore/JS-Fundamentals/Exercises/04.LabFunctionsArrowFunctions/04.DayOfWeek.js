function getNumberOfTheDay(dayAsString) {
    let daysInWeek = ["Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"];
    let isValidDay = daysInWeek.includes(dayAsString);

    let result = "error"
    if(isValidDay){
        result = daysInWeek.indexOf(dayAsString) + 1; //start from index 0
    }

    console.log(result);
}

getNumberOfTheDay("Monday");