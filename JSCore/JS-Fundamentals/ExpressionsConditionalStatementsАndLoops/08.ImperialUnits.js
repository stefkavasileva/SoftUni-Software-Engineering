function getImperial(inches) {
    let feet = Math.trunc(inches / 12);

    console.log(`${feet}'-${inches%12}"`)
}

getImperial(36);