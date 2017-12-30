function isLeapYear(year) {
    let isLeapYear = (year % 4 == 0 && year %100 !=0) || year % 400 == 0
    let result = "no";

    if(isLeapYear){
        result="yes";
    }

    console.log(result);
}

isLeapYear(1900)