function solve(args) {
    let firstNumbers=Number(args[0]);
    let secondNumber=Number(args[1]);

    let result;
    if (secondNumber>=firstNumbers){
        result = secondNumber * firstNumbers;
    }else {
        result = firstNumbers / secondNumber;
    }

    console.log(result);
}