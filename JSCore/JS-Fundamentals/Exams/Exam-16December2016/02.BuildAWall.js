function getYard(input) {
    let heightSections = input.map(Number);
    let yards = [];
    let totalYards = 0;
    let foots = 0;
    let isBuildTheWall = true;

    while (true) {

        for (let i = 0; i < heightSections.length; i++) {
            if (heightSections[i] < 30) {
                heightSections[i]++;
                foots++;
                isBuildTheWall = false;
            }
        }

        if(isBuildTheWall){
            break;
        }

        yards.push(foots * 195);
        totalYards += foots * 195;
        foots = 0;

        isBuildTheWall = true;
    }

    console.log(yards.join(", "));
    console.log(totalYards * 1900 + " pesos");
}

getYard(['17'])