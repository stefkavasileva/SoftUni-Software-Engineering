function currencyFormatter(separator, symbol, symbolFirst, value) {
    let result = Math.trunc(value) + separator;
    result += value.toFixed(2).substr(-2,2);
    if (symbolFirst) {
        return symbol + ' ' + result;
    }

    return result + ' ' + symbol;
}

function getDollarFormat(formatter) {
    function dollarFormatter(value) {
        return formatter(',','$',true,value);
    }

    return dollarFormatter;
}

function getLvFormat(formatter) {
    function lvFormatter(value) {
        return formatter('.','lv',false,value);
    }

    return lvFormatter;
}

let dollarFormatter = getDollarFormat(currencyFormatter);
let lvFormatter = getLvFormat(currencyFormatter);

console.log(lvFormatter(5345));   // 5345.00 lv
console.log(lvFormatter(3.1429)); // 3.14 lv
console.log(dollarFormatter(2.709));  // $ 2,71
console.log(dollarFormatter(35.5555)); // $ 35,56
