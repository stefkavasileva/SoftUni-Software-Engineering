function  solve(args) {
    let firstNum = Number(args[0]);
    let secondNum = Number(args[1]);
    let thirdNum = Number(args[2]);

    let isPositive = true;
    if(firstNum < 0 && secondNum < 0 && thirdNum < 0){
        isPositive = false;
    }else if(firstNum < 0 && secondNum >= 0 && thirdNum >= 0){
        isPositive = false;
    }else if(secondNum < 0 && firstNum >= 0 && thirdNum >= 0 ){
        isPositive = false;
    }else if(thirdNum < 0 && firstNum >= 0 && secondNum >= 0){
        isPositive = false;
    }

    if (isPositive){
        console.log("Positive");
    }else {
        console.log("Negative");
    }
}