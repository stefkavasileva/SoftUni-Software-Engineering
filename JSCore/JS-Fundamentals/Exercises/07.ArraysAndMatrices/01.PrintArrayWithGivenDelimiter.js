function joinByDelimiter(input) {
    let delimiter = input.pop();
    console.log(input.join(delimiter));
}

joinByDelimiter(["One",
"Two",
"Three",
"Four",
"Five",
"-"]);