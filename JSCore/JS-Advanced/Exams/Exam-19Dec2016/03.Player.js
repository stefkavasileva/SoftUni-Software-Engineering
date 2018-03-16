class Player {
    constructor(nickName) {
        this.nickName = nickName;
        this.scores = [];
    }

    addScore(score) {
        if(!isNaN(score) && score !== null){
            this.scores.push(+score);
        }

        return this;
    }

    get scoreCount() {
        return this.scores.length;
    }

    get highestScore() {
        let highestScore = this.scores.sort((a,b) => b - a)[0];
        return highestScore;
    }

    get topFiveScore() {
        let orderedScores = this.scores.sort((a, b) => b - a).slice(0, 5);
        return orderedScores;
    }

    toString() {
        return `${this.nickName}: [${this.scores.sort((a,b) => b - a)}]`
    }
}

let peter = new Player("Peter");
console.log('Highest score: ' + peter.highestScore);
console.log(`Top 5 score: [${peter.topFiveScore}]`);
console.log('' + peter);
console.log('Score count: ' + peter.scoreCount);
peter.addScore('4.5');
peter.addScore(200);
console.log('Highest score: ' + peter.highestScore);
console.log(`Top 5 score: [${peter.topFiveScore}]`);
console.log('' + peter);

