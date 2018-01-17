function main(inputArr) {
    inputArr = inputArr.map(Number);
    let positiveNums = [];
    let negativeNums = [];
    for (let i = 0; i < inputArr.length; i++) {
        if (inputArr[i]<0){
            negativeNums.unshift(inputArr[i]);
        }else {
            positiveNums.push(inputArr[i]);
        }

    }

    let newArr = negativeNums.concat(positiveNums);

    console.log(newArr.join("\n"));

}

main([3, 0, -2, -1]);