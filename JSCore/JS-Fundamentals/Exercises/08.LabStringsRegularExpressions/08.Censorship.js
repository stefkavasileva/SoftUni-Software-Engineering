function replaceText(text,input) {
    for (let i = 0; i < input.length; i++) {
        let pattern = input[i];
        let regex = new RegExp(pattern, 'g');
        text = text.replace(regex, "-".repeat(pattern.length));

    }

    console.log(text);
}

replaceText('roses are red, violets are blue', [', violets are', 'red']);