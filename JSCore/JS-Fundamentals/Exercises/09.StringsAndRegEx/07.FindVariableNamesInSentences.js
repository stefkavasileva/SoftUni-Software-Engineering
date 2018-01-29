function main(input) {
    let result = [];
    let reg = /_([A-Za-z\d]+)/g;
    let match;
    while (match = reg.exec(input)){
        result.push(match[1]);
    }

    console.log(result.join(','));
}

main('The _id and _age variables are both integers.');