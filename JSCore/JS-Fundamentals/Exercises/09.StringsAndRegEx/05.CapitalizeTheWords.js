function capitalizeTheWords(input) {
    let pattern = /\w+/g;
    let match;
    while (match = pattern.exec(input)){
        let newWord = match[0][0].toUpperCase();
        newWord += match[0].slice(1).toLowerCase();
        input = input.replace(match[0],newWord);
    }

    console.log(input);
}

capitalizeTheWords('Capitalize these words');