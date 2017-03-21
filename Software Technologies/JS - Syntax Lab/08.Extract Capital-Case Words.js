function solve(args) {
    let upperCaseWords = args
        .join(' ')
        .split(/\W+/)
        .filter(w=>w.length>0)
        .filter(w=>w === w.toUpperCase());

    console.log(upperCaseWords.join(', '));
}