class Rat{
    constructor(name){
        this.name = name;
        this.uniteRats = [];
    }

    unite(otherRat){
        if(otherRat.constructor === Rat){
            this.uniteRats.push(otherRat);
        }
    }

     getRats(){
        return this.uniteRats;
    }

    toString(){
        let result = this.name + '\n';
        for (let rat of this.uniteRats) {
            result += `##${rat.name}\n`;
        }

        return result;
    }
}

let test = new Rat("Pesho");
console.log(test.toString()); //Pesho

console.log(test.getRats()); //[]

test.unite(new Rat("Gosho"));
test.unite(new Rat("Sasho"));
console.log(test.getRats());
//[ Rat { name: 'Gosho', unitedRats: [] },
//  Rat { name: 'Sasho', unitedRats: [] } ]

console.log(test.toString());
// Pesho
// ##Gosho
// ##Sasho
