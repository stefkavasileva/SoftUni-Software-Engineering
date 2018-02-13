function getBill(input) {
    let purchases = input.filter((a,b) => b % 2 === 0);
    let totalPrice = input
        .filter((a,b) => b % 2 !== 0)
        .map(Number)
        .reduce((a,b) => a + b);

    console.log(`You purchased ${purchases.join(', ')} for a total sum of ${totalPrice}`);
}

getBill(['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69']);