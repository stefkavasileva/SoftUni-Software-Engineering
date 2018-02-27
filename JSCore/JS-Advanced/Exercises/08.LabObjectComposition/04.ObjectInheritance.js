function solve(input) {
    let commandExecutor = (function () {
        let objs = {};
        function create(commandAsStr) {
            let commandArgs = commandAsStr.split(' ');
            let name = commandArgs[1];
            if(commandArgs.length > 2){
                objs[name] = Object.create(objs[commandArgs[3]]);
            }else {
                objs[name] = {};
            }
        }
        
        function set(commandAsStr) {
            let commandArgs = commandAsStr.split(' ');
            let objName = commandArgs[1];
            let key = commandArgs[2];
            let value = commandArgs[3];
           objs[objName][key] = value;
        }
        
        function print(commandAsStr) {
            let commandArgs = commandAsStr.split(' ');
            let name = commandArgs[1];

            let keyValueToString = [];
            let currentObj = objs[name];
            for (let key in currentObj) {
                keyValueToString.push(`${key}:${currentObj[key]}`)
            }

            console.log(keyValueToString.join(', '));;
        }

        return {create,set,print}
    })();

    for (let currentElement of input) {
        let commandName = currentElement.split(' ')[0];
        commandExecutor[commandName](currentElement);
    }
}

solve(['create c1',
    'create c2 inherit c1',
    'set c1 color red',
    'set c2 model new',
    'print c1',
    'print c2']
);