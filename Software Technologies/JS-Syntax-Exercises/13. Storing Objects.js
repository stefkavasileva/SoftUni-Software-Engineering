function solve(args) {
    for (let i = 0; i < args.length; i++) {
        let personArgs=args[i].split(" -> ");
        let name = personArgs[0];
        let age = personArgs[1];
        let grade = personArgs[2];

        console.log(`Name: ${name}`);
        console.log(`Age: ${age}`);
        console.log(`Grade: ${grade}`);
    }
}