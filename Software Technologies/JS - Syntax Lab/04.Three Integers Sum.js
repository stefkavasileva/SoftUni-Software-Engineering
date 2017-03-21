function solve(args) {
    let numbers = args[0].split(' ');
    let firstNum=Number(numbers[0]);
    let secondNum=Number(numbers[1]);
    let thirdNum=Number(numbers[2]);

    console.log(checkForSum(firstNum,secondNum,thirdNum)||
                checkForSum(secondNum,thirdNum,firstNum) ||
                checkForSum(firstNum,thirdNum,secondNum) ||
                'No');

    function checkForSum(firstNum,secondNum,thirdNum) {
        if(firstNum+secondNum!=thirdNum){
            return false;
        }

        if( firstNum> secondNum){
            [firstNum,secondNum]=[secondNum,firstNum];
        }
        return `${firstNum} + ${secondNum} = ${thirdNum}`;
    }
}
