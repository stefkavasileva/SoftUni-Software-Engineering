function solve(args) {
    let arrLen = Number(args[0]);

    let resultArr=[];
    for (let i = 1; i < args.length; i++) {
        let indexOfDashes = args[i].indexOf('-');
        let index = Number(args[i].substr(0,indexOfDashes - 1));
        let element = args[i].substr(indexOfDashes+1);
        resultArr[index] = element;
    }

        for (let i = 0; i < arrLen; i++) {
            if (resultArr[i] === undefined){
                resultArr[i] = 0;
            }
        }

    console.log(resultArr.join('\n'));
}