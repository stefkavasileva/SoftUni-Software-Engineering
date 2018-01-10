function printLetterIndex(text) {
    text.split(``).forEach((a,b) => console.log(`str[${b}] -> ${a}`)) ;
}

printLetterIndex('Hello, World!');