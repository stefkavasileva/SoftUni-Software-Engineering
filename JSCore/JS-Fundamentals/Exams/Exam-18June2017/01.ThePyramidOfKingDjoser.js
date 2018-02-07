function getMaterials(base,increment) {
    let stones = 0;
    let marbles = 0;
    let lapis = 0;
    let gold = 0;

    let rowsOfPyramid  = Math.ceil(base / 2);
    for (let i = 1; i <= rowsOfPyramid - 1; i++) {
        let currentStones = (base - 2) * (base - 2);
        if(i % 5 === 0){
            lapis += base * base - currentStones;
        }else {
            marbles += base * base - currentStones;
        }

        stones += currentStones;
        base -= 2;

    }

    console.log(`Stone required: ${Math.ceil(stones * increment)}`);
    console.log(`Marble required: ${Math.ceil(marbles * increment)}`);
    console.log(`Lapis Lazuli required: ${Math.ceil(lapis * increment)}`);
    console.log(`Gold required: ${Math.ceil(base * base * increment)}`);
    console.log(`Final pyramid height: ${Math.floor(rowsOfPyramid * increment)}`);
}

getMaterials(11,0.75);