function subSum(numbers, startIndex, endIndex) {
    if(!Array.isArray(numbers)){
        return NaN;
    };

    if(numbers.length === 0){
        return 0;
    }

    if(startIndex < 0){
        startIndex = 0;
    };

    if(endIndex >= numbers.length){
        endIndex = numbers.length - 1;
    };

    let mapNumber = numbers.map(Number);
    let resultSubSum = mapNumber.slice(startIndex,endIndex + 1).reduce((a,b) => a + b);

    return resultSubSum;
}

console.log(subSum('text', 0, 2));