function main(input) {
    let numbers = [];

    for (let i = 0; i < input.length; i++) {
        let instruction = input[i];
        if(!isNaN(instruction)){
            numbers.push(instruction);
            continue;
        }

        let firstNumber = numbers.pop();
        let secondNumber = numbers.pop();

        if(firstNumber === undefined || secondNumber === undefined){
            console.log('Error: not enough operands!');
            return;
        }
        let result = getResult(firstNumber,secondNumber,instruction);

        numbers.push(result);
    }

    if(numbers.length > 1){
        console.log('Error: too many operands!');
        return;
    }

    console.log(numbers[0]);

    function getResult(firstNumber,secondNumber,instruction) {
        switch (instruction){
            case '+':
                return secondNumber + firstNumber;
            case '-':
                return secondNumber - firstNumber;
            case '*':
                return secondNumber * firstNumber;
            case '/':
                return secondNumber / firstNumber;
        }
    }
}

main([-1,
    1,
    '+',
    101,
    '*',
    18,
    '+',
    3,
    '/']
);