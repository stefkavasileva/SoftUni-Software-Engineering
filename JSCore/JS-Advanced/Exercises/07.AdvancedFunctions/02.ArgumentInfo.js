function getArguments() {
    let argumentsCount = {};
    for (let argument of arguments) {
        let type = typeof  argument;
        let argumentValue = argument;

        if(!argumentsCount.hasOwnProperty(type)){
            argumentsCount[type] = 0;
        }

        argumentsCount[type]++;
        console.log(`${type}: ${argumentValue}`);;
    }

    let sortedKey =  Object.keys(argumentsCount).sort(function(a,b){return argumentsCount[b] - argumentsCount[a]});
    for (let key of sortedKey) {
        console.log(`${key} = ${argumentsCount[key]}`);;
    }
}

getArguments('cat', 42, function () { console.log('Hello world!'); });
