function main(input) {
    let golds = input.map(Number);
    let bitcoins = 0;
    let money = 0;
    let firstDay = -1;

    for (let i = 1; i <= input.length; i++) {
        let currentGold = input[i - 1];
        if(i % 3 === 0 && i !== 1 ){
            currentGold = currentGold - (currentGold * 0.3);
        }

        let amountOfMoney = currentGold * 67.51;
        money += amountOfMoney;


        if(money >= 11949.16){
            let currentBitcoins = Math.trunc(money / 11949.16);
            bitcoins += currentBitcoins
            money -= currentBitcoins * 11949.16;

            if(firstDay === -1){
                firstDay = i;
            }

        }
    }

    console.log(`Bought bitcoins: ${bitcoins}`);
    if(firstDay != -1){
        console.log(`Day of the first purchased bitcoin: ${firstDay}`);
    }

    console.log(`Left money: ${money.toFixed(2)} lv.`);
}