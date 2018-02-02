function main(input) {
    let map = new Map();
    for (let i = 0; i < input.length; i++) {
       let args = input[i].split(':').map(x => x.trim()).filter(x => x !== '');
       let name = args[0];
       let price = Number(args[1]);
       if(!map.has(name)){
           map.set(name,0);
       }

       map.set(name,price);
    }

    let arr = Array.from(map.keys()).sort();
    let letter = '';
    for (let element of arr) {
        let firstLetter = element[0].substring(0,1);
        if(firstLetter !== letter){
            letter = firstLetter;
            console.log(letter);
        }

        console.log(`  ${element}: ${map.get(element)}`);
    }
}

main(['Appricot : 20.4',
'Fridge : 1500',
'TV : 1499',
'Deodorant : 10',
'Boiler : 300',
'Apple : 1.25',
'Anti-Bug Spray : 15',
'T-Shirt : 10']);