function getWords(input) {
    let reg = /[A-Za-z\d_]+/g;
    let matches = input.match(reg);
    console.log(matches.join('|'));
}

getWords('A Regular Expression needs to have the global flag in order to match all occurrences in the text');