function splitByDelimiter(text,delimiter) {
    let result = text.split(delimiter);
    result.forEach(x => console.log(x));
}

splitByDelimiter('One-Two-Three-Four-Five','-');