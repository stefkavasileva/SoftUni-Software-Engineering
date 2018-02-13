    function printWinnerInKingdom(inputKingdoms, attackts) {
        let kingdoms = [];
        for (let currentKingdom of inputKingdoms) {
            let kingdom = kingdoms.find(x => x.name === currentKingdom.kingdom);
            if(!kingdom){
                kingdom = {name: currentKingdom.kingdom, generals: []};
                kingdoms.push(kingdom);
            }

            let general = kingdom.generals.find(x => x.name === currentKingdom.general);
            if(!general){
                general = {name:currentKingdom.general,army:0,wins:0,losses:0};
                kingdom.generals.push(general);
            }

            general.army += currentKingdom.army;
        }

        for (let attackArgs of attackts) {
            let attackingKingdom = attackArgs[0];
            let attackingGeneral = attackArgs[1];
            let defendingKingdom = attackArgs[2];
            let defendingGeneral = attackArgs[3];

            if(attackingKingdom == defendingKingdom){
                continue;
            }

            let firstGeneral =kingdoms.find(x => x.name === attackingKingdom).generals.find(x => x.name === attackingGeneral);
            let secondGeneral =kingdoms.find(x => x.name === defendingKingdom).generals.find(x => x.name === defendingGeneral);

            if(firstGeneral.army === secondGeneral.army){
                continue;
            }

            if(firstGeneral.army > secondGeneral.army){
                firstGeneral.army += firstGeneral.army * 0.1;
                secondGeneral.army -= secondGeneral.army * 0.1;

                firstGeneral.wins++;
                secondGeneral.losses++;
            }else if(firstGeneral.army < secondGeneral.army){
                firstGeneral.army -=firstGeneral.army * 0.1;
                secondGeneral.army += secondGeneral.army * 0.1;

                firstGeneral.losses++;
                secondGeneral.wins++;
            }

            firstGeneral.army = Math.trunc(firstGeneral.army);
            secondGeneral.army = Math.trunc(secondGeneral.army);
        }

        let sortedKingdoms = kingdoms.sort(sortKingdoms);

        let winner = sortedKingdoms[0];

        console.log(`Winner: ${winner.name}`);
        let sortedGenerals = winner.generals.sort(sortGeneral);
        for (let general of sortedGenerals) {
            console.log(`/\\general: ${general.name}`);
            console.log(`---army: ${general.army}`);
            console.log(`---wins: ${general.wins}`);
            console.log(`---losses: ${general.losses}`);
        }

        function sortGeneral(a,b) {
            let armyA = a.army;
            let armyB = b.army;
            if(armyA > armyB){
                return -1;
            }else if(armyA < armyB){
                return 1;
            }else {
                return 0;
            }
        }

        function sortKingdoms(a,b) {
            let allWinsA = 0;
            for (let general of a.generals) {
                allWinsA += general.wins;
            }

            let allWinsB = 0;
            for (let general of b.generals) {
                allWinsB += general.wins;
            }

            if(allWinsA > allWinsB){
                return -1;
            }else if(allWinsA < allWinsB){
                return 1;
            }else if(allWinsA === allWinsB) {

                let allLossesA = 0;
                for (let general of a.generals) {
                    allLossesA += general.losses;
                }

                let allLossesB = 0;
                for (let general of b.generals) {
                    allLossesB += general.losses;
                }

                if(allLossesA > allLossesB){
                    return 1;
                }else if(allLossesA < allLossesB){
                    return -1;
                }else {
                    let nameA = a.name;
                    let nameB = b.name;
                    if(nameA >= nameB){
                        return 1;
                    }else if(nameA < nameB){
                        return -1;
                    }
                }
            }
        }
    }

    printWinnerInKingdom([ { kingdom: "Maiden Way", general: "Merek", army: 5000 },
        { kingdom: "Stonegate", general: "Ulric", army: 4900 },
        { kingdom: "Stonegate", general: "Doran", army: 70000 },
        { kingdom: "YorkenShire", general: "Quinn", army: 0 },
        { kingdom: "YorkenShire", general: "Quinn", army: 2000 },
        { kingdom: "Maiden Way", general: "Berinon", army: 100000 } ],
    [ ["YorkenShire", "Quinn", "Stonegate", "Ulric"],
        ["Stonegate", "Ulric", "Stonegate", "Doran"],
        ["Stonegate", "Doran", "Maiden Way", "Merek"],
        ["Stonegate", "Ulric", "Maiden Way", "Merek"],
        ["Maiden Way", "Berinon", "Stonegate", "Ulric"] ]
);