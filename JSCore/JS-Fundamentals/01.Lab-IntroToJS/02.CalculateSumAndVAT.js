function calc(numbers) {
    let sum = numbers.reduce((a, b) => a + b, 0);
    let vat = sum * 0.2;
    let total = sum + vat;

    console.log(`sum = ${sum}`);
    console.log(`VAT = ${vat}`);
    console.log(`total = ${total}`);
}

calc([1.20, 2.60, 3.50]);