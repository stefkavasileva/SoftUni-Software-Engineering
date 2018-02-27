function getGreatestDivisor(firstNumber, secondNumber) {
    while (firstNumber != secondNumber)
    {
        if (firstNumber > secondNumber) {
            firstNumber -= secondNumber;
        } else {
            secondNumber -= firstNumber;
        }
    }

    return firstNumber;
}

console.log(getGreatestDivisor(252, 105));;