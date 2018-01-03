function getRoundNumber([numToBeRound, precisionNum]) {
    if (precisionNum > 15){
        precisionNum = 15;
    }

    let result = numToBeRound.toFixed(precisionNum);
    result = parseFloat(result);
    console.log(result);
}

getRoundNumber([3.1415926535897932384626433832795, 2])