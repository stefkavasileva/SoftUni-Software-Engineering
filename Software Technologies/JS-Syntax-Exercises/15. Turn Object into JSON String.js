function solve(args) {
    let obj = {};
    for (let i = 0; i < args.length; i++) {
        let objProps=args[i].split(" -> ");
        let key = objProps[0];
        let value = objProps[1];

        if(key === "age" || key === "grade"){
            value = Number(value);
        }
        obj[key]=value;
    }

    let json=JSON.stringify(obj);
    console.log(json);
}