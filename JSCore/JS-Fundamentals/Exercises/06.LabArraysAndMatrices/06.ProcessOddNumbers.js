function oddNumbers(numbers) {
    let oddNumbers = numbers
        .filter((a,b) => b % 2 != 0)
        .map(a => a * 2)
        .reverse();

    console.log(oddNumbers.join(" "));
}

oddNumbers([10, 15, 20, 25]);