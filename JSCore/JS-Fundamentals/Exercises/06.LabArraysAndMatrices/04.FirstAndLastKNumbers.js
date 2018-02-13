function sortArr(inputArr) {
    let k = inputArr.shift();
    let firstKNums = inputArr.slice(0,k);
    let lastKNums = inputArr.slice(inputArr.length - k);

    console.log(firstKNums);
    console.log(lastKNums);
}

sortArr([2, 7, 8, 9]);