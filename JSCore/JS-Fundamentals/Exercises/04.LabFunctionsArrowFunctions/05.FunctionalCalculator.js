function calc(leftOperand,rightOperand,operator) {
    let result  = 0;

    if (operator=="+"){
       result = leftOperand + rightOperand;
    }else if(operator=="-"){
        result = Math.abs(leftOperand - rightOperand);
    }else if(operator=="*"){
       result = leftOperand * rightOperand;
    }else if(operator=="/"){
        result = leftOperand / rightOperand;
    }else if(operator=="%"){
        result = leftOperand % rightOperand;
    }
    console.log(result);
}

calc(2, 4, '+');