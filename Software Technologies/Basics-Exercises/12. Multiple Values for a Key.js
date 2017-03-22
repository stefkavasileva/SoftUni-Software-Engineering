function solve(args) {
    let pairs = {};
    let result;

    for (let i = 0; i < args.length; i++) {
        let pair = args[i].split(' ');
        let key = pair[0];
        let value = pair[1];

        if(value === undefined){
            result=pairs[key];
            break;
        }

        if (pairs[key]=== undefined){
            pairs[key]= [];
        }

        pairs[key].push(value);
    }

    if(result === undefined){
        console.log("None")
    }else {
        console.log(result.join('\n'));
    }
}
