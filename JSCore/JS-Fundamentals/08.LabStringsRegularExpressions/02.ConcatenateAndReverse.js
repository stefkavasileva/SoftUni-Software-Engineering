function concatAndReverseArray(inputArr) {
    let result = inputArr
        .map(x => x.split(``).reverse().join(``))
        .reverse()
        .join(``);

    console.log(result);
}

concatAndReverseArray(['I', 'am', 'student']);