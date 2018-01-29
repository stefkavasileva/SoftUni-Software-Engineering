function main(input) {
    let patter = /[\s\(\),;\.]/;
    let result = input.split(patter).filter(x => x !== '');
    result.forEach(x => console.log(x))
}

main('let sum = 4 * 4,b = "wow";');