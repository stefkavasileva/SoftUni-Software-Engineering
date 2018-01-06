function getSmallestNums(numbers) {
    let result = numbers.sort((a,b) => a - b).slice(0,2);
    console.log(result.join(" "));
}

getSmallestNums([30, 15, 50, 5]);