function getElementsByStep(input) {
    let step = input.pop();
    let elements = input.filter((a, b) => b % step == 0);

    console.log(elements.join(`\n`));

}

getElementsByStep(["dsa", "asd", "test", "tset", 1]);