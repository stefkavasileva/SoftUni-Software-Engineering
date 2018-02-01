function main(inputArr) {
    let products = new Map;
    for (let priceList of inputArr) {
        let [town, product, price] = priceList.split(/\s+\|\s+/g);
        if (!products.has(product))
            products.set(product, new Map);
        products.get(product).set(town, Number(price));
    }

    for (let [product, towns] of products) {
        let minPrice = Number.MAX_VALUE;
        let minPriceTown = '';
        for (let [town, price] of towns) {
            if (price < minPrice) {
                minPrice = price;
                minPriceTown = town;
            }
        }

        console.log(`${product} -> ${minPrice} (${minPriceTown})`);
    }
}

main(['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 3',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10']);