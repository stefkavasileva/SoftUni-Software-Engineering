function main(key,text) {
    let coordinatesPattern = /(north|east)[^,]*?(\d{2})[^,]*?,[^,]*?(\d{6})/i;
    let match;
    let northMatch;
    let eastMatch;

    while (match = coordinatesPattern.exec(text)){
        text = text.replace(match[0],'');
        if(match[1].toLowerCase() === 'east'){
            eastMatch = match;
            continue;
        }

        northMatch = match;
    }

    let messagePattern = new RegExp(key +'(.+)' + key,'g');
    let message = messagePattern.exec(text);

    console.log(`${northMatch[2]}.${northMatch[3]} N`);
    console.log(`${eastMatch[2]}.${eastMatch[3]} E`);
    console.log(`Message: ${message[1]}`);
}

main('4ds', 'eaSt 19,432567noRt north east 53,123456north 43,3213454dsNot all those who wander are lost.4dsnorth 47,874532');