function printNumbers(numberAsString) {
    let number = Number(numberAsString);
    let result = "";
    for(let i = 1; i <= number; i++){
     result+=i;
    }

    return result;
}

console.log(printNumbers("5"));