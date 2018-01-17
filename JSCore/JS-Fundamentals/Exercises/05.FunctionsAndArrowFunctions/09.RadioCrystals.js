function grindCrystals(inputArr) {

    function cut(crystal) {

        return crystal / 4;
    }

    function lap(crystal) {

        return crystal * 0.80;
    }


    function grind(crystal) {

        crystal -= 20;
        return crystal;
    }

    function etch(crystal) {

        crystal -= 2;
        return crystal;
    }

    function xRay(crystal) {

        console.log("X-ray x1");
        return crystal + 1;
    }

    function transportAndWash(crystal) {

        console.log("Transporting and washing");
        return Math.floor(crystal);
    }

    let targetSize = inputArr[0];

    function execOperation(microns, opStr, operation) {

        let newSize = operation(microns);
        let counter = 0;

        while (newSize >= targetSize || Math.floor(targetSize - newSize) === 1) {
            microns = newSize;
            newSize = operation(microns);
            counter++;
        }

        if (counter > 0) {

            console.log(`${opStr} x${counter}`);
            microns = transportAndWash(microns);
        }

        return microns;
    }

    for (let i = 1; i < inputArr.length; i++) {

        let microns = inputArr[i];
        console.log(`Processing chunk ${microns} microns`);
        microns = execOperation(microns, "Cut", cut);
        microns = execOperation(microns, "Lap", lap);
        microns = execOperation(microns, "Grind", grind);
        microns = execOperation(microns, "Etch", etch);

        if (microns + 1 === targetSize) {
            microns = xRay(microns);
        }

        console.log(`Finished crystal ${microns} microns`);
    }
}

grindCrystals([1000, 4000, 8100]);