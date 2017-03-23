function solve(args) {

    for (let i = 0; i < args.length; i++) {
        let obj = JSON.parse(args[i]);
        console.log(`Name: ${obj.name}`);
        console.log(`Age: ${obj.age}`);
        console.log(`Date: ${obj.date}`);
    }
}