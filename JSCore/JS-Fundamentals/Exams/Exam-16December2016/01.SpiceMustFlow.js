function getTotalAmountOfSpace(input) {
    let startingYield = Number(input[0]);
    let extractedSpice = 0;
    let daysCount = 0;

    while (startingYield >= 100){
        extractedSpice += startingYield;

        if(extractedSpice >= 26){
            extractedSpice -= 26;
        }

        startingYield -= 10;
        daysCount +=1;
    }

    if(extractedSpice >= 26){
        extractedSpice -= 26;
    }

    console.log(daysCount);
    console.log(extractedSpice);
}

getTotalAmountOfSpace(['111']);