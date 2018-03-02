function makeCard(face, inputSuit) {
    let validFace  = [2,3,4,5,6,7,8,9,10,'J','Q','K','A'];
    let validSuit = {
        S:'\u2660',
        H:'\u2665',
        D:'\u2666',
        C:'\u2663'
    };

    if(!validFace.includes(face) || !validSuit[inputSuit] ){
        throw new Error('Error');
    }

    let card = {
        face: face,
        suit: validSuit[inputSuit],
        toString: function () {
            return `${this.face}${this.suit}`;
        }
    };

    return card;
}

console.log(makeCard('1', 'C').toString());