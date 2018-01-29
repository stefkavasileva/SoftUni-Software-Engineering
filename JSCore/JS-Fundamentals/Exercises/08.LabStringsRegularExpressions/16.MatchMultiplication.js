function main(input) {
    let pattern = /\b(-*\d+)?\s*\*\s*(-*\d+\.*\d*)\b/;
    let match ;
    while (match = pattern.exec(input)){
        let firstNumber = Number(match[1]);
        let secondNumber = Number(match[2]);
        let result = firstNumber * secondNumber;
        input = input.replace(match[0],result);
    }

    console.log(input);
}

main('My bill: 2*2.50 (beer); 2* 1.20 (kepab); -2  * 0.5 (deposit).');