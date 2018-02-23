function processText(commands) {
    let processor = (function () {
        let currentStr = '';
        return {
            append:(text) =>  currentStr += text,
            removeStart: (count) => currentStr = currentStr.slice(count),
            removeEnd: (count) => currentStr = currentStr.substr(0,currentStr.length - count),
            print: () => console.log(currentStr)
        }
    }());

    for (let commandStr of commands) {
        let commandArgs = commandStr.split(' ');
        let commandName = commandArgs[0];
        let commandValue = commandArgs[1];
        processor[commandName](commandValue);
    }
}

processText(['append hello',
    'append again',
    'removeStart 3',
    'removeEnd 4',
    'print']);