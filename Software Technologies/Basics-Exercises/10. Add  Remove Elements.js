function solve(args) {
    let result = [];
    let index = 0;

    for (let i = 0; i < args.length; i++) {
        let currentLine = args[i].split(' ');
        let command = currentLine[0].trim();
        let element = Number(currentLine[1].trim());

        if(command === "add"){
            result.push(element);
        }else{
            result.splice(element, 1)
        }
    }

    console.log(result.join('\n'));
}

