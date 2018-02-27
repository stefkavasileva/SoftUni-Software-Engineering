function getScore(commandName) {
    let balance = this.upvotes - this.downvotes;
    let totalVotes = this.upvotes + this.downvotes;

    let commands = {
        upvote: () => this.upvotes++,
        downvote: () => this.downvotes++,
        score: () => {
            let up = this.upvotes;
            let down = this.downvotes;

            if (totalVotes > 50) {
                let value = Math.ceil(Math.max(up, down) * 0.25);

                if(totalVotes > 50){
                    up += value;
                    down += value;
                }
            }

            return [up, down, balance, getRating.call(this)];

            function getRating() {
                if (totalVotes < 10) {
                    return 'new';
                }
                if (this.upvotes > (this.upvotes + this.downvotes) * 0.66) {
                    return 'hot';
                } else if (balance >= 0 && (this.upvotes > 100 || this.downvotes > 100)) {
                    return 'controversial';
                } else if (this.upvotes < this.downvotes) {
                    return "unpopular";
                } else {
                    return 'new';
                }
            }
        }
    };

    return commands[commandName]();
}

let post = {
    id: '3',
    author: 'emil',
    content: 'wazaaaaa',
    upvotes: 100,
    downvotes: 100
};

getScore.call(post, 'upvote');
getScore.call(post, 'downvote');
console.log(getScore.call(post, 'score')); // [127, 127, 0, 'controversial']

for (let i = 0; i < 50; i++) {
    getScore.call(post, 'downvote');
}

console.log(getScore.call(post, 'score')); // [139, 189, -50, 'unpopular']