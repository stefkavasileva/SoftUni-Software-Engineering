function letterCount(text,letter) {
    let regex = new RegExp(letter,"g")
    let count = (text.match(regex)).length;
    console.log(count);
}


letterCount("hello", "l");