function main(text) {
    let svgMatch = /<svg>(.+?)<\/svg>/g.exec(text);

    if (!svgMatch || svgMatch.length > 2) {
        console.log('No survey found');
        return;
    }


    let sectionMatch = /<cat>(.+)<\/cat>\s*\t*\n*<cat>(.+)<\/cat>/g.exec(svgMatch[1]);
    if (!sectionMatch || sectionMatch.length > 3) {
        console.log('Invalid format');
        return;
    }

    let firstSection = sectionMatch[1];
    let secondSection = sectionMatch[2];

    let labelMatch = /^<text>.+?\[(.+)\]<\/text>$/g.exec(firstSection);

    if (!labelMatch || labelMatch.length > 2 || labelMatch[1].includes('[') || labelMatch[1].includes(']')) {
        console.log('Invalid format');
        return;
    }

    let label = labelMatch[1];
    let ratingReg = new RegExp(/<g><val>(\d+)<\/val>(\d+)<\/g>/g);

    let voteCount = 0;
    let voteAmount = 0;

    let match;
    let hasMatch = false;
    while(match = ratingReg.exec(secondSection)){
        hasMatch = true;
        let value = match[1];
        let count = match[2];

        if(isNaN(value)){
            hasMatch = false;
            continue;
        }

        if(isNaN(count)){
            hasMatch = false;
            continue;
        }

        value = Number(value);
        count = Number(count);

        if(value < 1 || value > 10 || count < 0){
            continue;
        }

        voteAmount += value * count;
        voteCount += count;
    }

    if(!hasMatch && voteCount === 0 && voteAmount === 0){
        console.log('Invalid format');
        return;
    }


    let result = voteAmount / voteCount;
    console.log(`${label}: ${Math.round(result * 100) / 100}`);
}

main('<svg><cat><text>Which is your favourite meal from our selection?</text></cat><cat><g><val>Fish</val>15</g><g><val>Prawns</val>31</g><g><val>Crab Langoon</val>12</g><g><val>Calamari</val>17</g></cat></svg>')