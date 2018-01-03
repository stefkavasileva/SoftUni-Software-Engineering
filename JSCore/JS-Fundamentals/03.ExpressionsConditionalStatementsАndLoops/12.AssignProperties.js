function printObject(inputArr) {
    let firstValue = inputArr[0];
    let secondValue = inputArr[2];
    let thirdValue = inputArr[4];

    console.log({
        [firstValue]: inputArr[1],
        [secondValue]: inputArr[3],
        [thirdValue]: inputArr[5]
    });
}

printObject(['name', 'Pesho', 'age', '23', 'gender', 'male']);