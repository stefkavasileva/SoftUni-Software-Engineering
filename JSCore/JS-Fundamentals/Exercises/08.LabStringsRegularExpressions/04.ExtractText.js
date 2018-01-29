function extractText(input) {
    let regex =  /\((.+?)\)/g;
    let match;
    let matches = [];

    while(match = regex.exec(input)){
        matches.push(match[1]);
    }

    console.log(matches.join(", "));

}

extractText('Rakiya (Bulgarian brandy) is self-made liquor (alcoholic drink)');