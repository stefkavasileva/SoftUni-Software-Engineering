function printDeckOfCards(cards) {
    let cardsResult = [];

    for (let card of cards) {
        try {
            cardsResult.push(makeCard(card).toString());
        } catch(err) {
            console.log("Invalid card: " + card);
            return;
        }

        cardsResult.push(makeCard(card).toString())
    }

    console.log(cardsResult.join(' '));

    function makeCard(card) {
        let validFace  = ['2','3','4','5','6','7','8','9','10','J','Q','K','A'];
        let validSuit = {
            S:'\u2660',
            H:'\u2665',
            D:'\u2666',
            C:'\u2663'
        };

        let inputSuit = [...card].pop();
        let inputFace = card.slice(0, card.length - 1);

        if(!validFace.includes(inputFace) || !validSuit[inputSuit] ){
            throw new Error(`Invalid card: ${inputFace}${inputSuit}`);
        }

       return {
            face: inputFace,
            suit: validSuit[inputSuit],
            toString: function () {
                return `${this.face}${this.suit}`;
            }
        };
    }
}

printDeckOfCards(['5S', '3D', 'QD','1C']);