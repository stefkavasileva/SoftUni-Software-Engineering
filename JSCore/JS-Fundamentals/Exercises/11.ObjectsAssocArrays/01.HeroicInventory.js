function getInventoryInfo(inputArr) {
 let heroes = [];
    for (let i = 0; i < inputArr.length; i++) {
       let currentHeroArgs = inputArr[i].split(' / ').filter(x => x !== '').map(x => x.trim());
       let name = currentHeroArgs[0];
       let level = Number(currentHeroArgs[1].trim());

       let items = [];

       if(currentHeroArgs.length > 2){
          items = currentHeroArgs[2].split(', ').filter(x => x !== '').map(x => x.trim());
       }

       let hero = {name:name,level:level,items:items};
       heroes.push(hero);
    }

    console.log(JSON.stringify(heroes));
}

getInventoryInfo(['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']);