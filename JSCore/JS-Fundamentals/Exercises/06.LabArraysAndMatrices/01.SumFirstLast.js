function calcSum(input) {
    input = input.map(Number);
    let sum = input[0] + input[input.length - 1];

    console.log(sum);
}

calcSum(['20', '30', '40']);