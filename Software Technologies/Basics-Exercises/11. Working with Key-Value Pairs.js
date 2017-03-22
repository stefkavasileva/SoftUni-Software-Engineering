function solve(args) {
    let pairs = {};
    let result;

    for (let i = 0; i < args.length; i++) {
        let pair = args[i].split(' ');
        let key = pair[0];
        let value = pair[1];

        if(value === undefined){
            result=pairs[key];
        }
        pairs[key]=value;
    }

    if(result === undefined){
        console.log("None")
    }else {
        console.log(result);
    }
}

solve(['key value1','key value2','key']);