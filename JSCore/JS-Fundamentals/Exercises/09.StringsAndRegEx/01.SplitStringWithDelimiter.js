function main(text,delimiter) {
    let result = text.split(delimiter);
    result.forEach(x => console.log(x));
}

main('One-Two-Three-Four-Five','-');