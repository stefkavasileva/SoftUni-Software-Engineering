function toUpperString(input) {
    let words = input.toUpperCase().split(/\W+/);

    words = words.filter(w => w !== '');
    let result = words.join(", ");
    console.log(result);
}

toUpperString('Hi, how are you?');