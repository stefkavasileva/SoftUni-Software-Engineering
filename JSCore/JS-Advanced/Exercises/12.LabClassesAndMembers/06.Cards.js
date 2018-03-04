let result = (function () {
    const Suits = {
        SPADES:'\u2660',
        HEARTS:'\u2665',
        DIAMONDS:'\u2666',
        CLUBS:'\u2663'
    };

    const ValidFace = ["2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"];

    class Card{
        constructor(face,suit){
            this.face = face;
            this.suit = suit;
        }

        set face(face){
            if(!ValidFace.includes(face)){
               throw  new Error(`Invalid face card ${face}`);
            }

            this._face = face;
        }

        get face(){
            return this._face;
        }

        set suit(suit){
            if(!Object.keys(Suits).map(x => x  = Suits[x]).includes(suit)){
                throw  new Error(`Invalid suit card ${suit}`);
            }

            this._suit = suit;
        }

        get suit(){
            return this._suit;
        }
    }

    return {Suits,Card}
})();

let Card = result.Card;
let Suits = result.Suits;

let firstCard = new Card('Q',Suits.CLUBS);
let secondCard = new Card('1',Suits.DIAMONDS); // throw error

console.log(firstCard);