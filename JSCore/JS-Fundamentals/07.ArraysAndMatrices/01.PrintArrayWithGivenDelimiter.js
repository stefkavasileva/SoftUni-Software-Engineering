function main(input) {
    let delimiter = input.pop();
    console.log(input.join(delimiter));
}

main(["One",
"Two",
"Three",
"Four",
"Five",
"-"]);