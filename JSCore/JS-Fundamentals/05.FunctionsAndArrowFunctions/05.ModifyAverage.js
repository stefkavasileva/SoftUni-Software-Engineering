function modifyAvg(number) {
    let numberAsStr = number.toString();
    let digits = numberAsStr.split("").map(Number);

    let avg = digits.reduce((a,b) => a + b) / numberAsStr.length;

    while (avg <= 5){
        numberAsStr += 9;
        digits = numberAsStr.split("").map(Number);
        avg = digits.reduce((a,b) => a + b) / numberAsStr.length;
    }

    console.log(numberAsStr);
}

modifyAvg(101);