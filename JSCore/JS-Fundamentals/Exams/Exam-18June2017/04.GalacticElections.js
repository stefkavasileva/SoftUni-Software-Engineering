//50/100
function main(input) {
    let systems = [];
    for (let i = 0; i < input.length; i++) {
       let currentSystem = input[i];
       let systemName = currentSystem.system;
       let candidateName = currentSystem.candidate;
       let vote = currentSystem.votes;

       let system = systems.find(x => x.name === systemName);
       if(system === undefined){
           system = {name: systemName, candidates: []};
           systems.push(system);
       }

       let candidate = system.candidates.find(x => x.name === candidateName);
       if(candidate === undefined){
           candidate = {name: candidateName, vote: 0};
           system.candidates.push(candidate);
       }

       candidate.vote += vote;
    }

    let systemWithWinners = [];
    for (let system of systems) {
        let winner = system.candidates.sort((a,b) => b.vote - a.vote)[0];

        if(system.candidates.length != 1){
            winner.vote = system.candidates.reduce((a,b) => a.vote + b.vote);
        }

       systemWithWinners.push({name: system.name, winner: winner});
    }

    //sort winners by votes
    systemWithWinners = systemWithWinners
        .sort((a,b) => b.winner.vote - a.winner.vote);


    /// if has one winner
    let hasOneWinner = true;
    for (let i = 0; i < systemWithWinners.length -1 ; i+= 2) {
        if(systemWithWinners[i].winner.name !== systemWithWinners[i + 1].winner.name){
            hasOneWinner = false;
            break;
        }
    }

    let totalVotes = 0;

    for (let system of systemWithWinners) {
        totalVotes += system.winner.vote;
    }

    if(hasOneWinner){
        console.log(`${systemWithWinners[0].winner.name} wins with ${totalVotes} votes`);
        console.log(`${systemWithWinners[0].winner.name} wins unopposed!`);
        return;
    }


    if(systemWithWinners[0].winner.vote > totalVotes / 2){
        console.log(`${systemWithWinners[0].winner.name} wins with ${systemWithWinners[0].winner.vote} votes`);
        console.log(`Runner up: ${systemWithWinners[1].winner.name}`);
        for (let i = 1; i < systemWithWinners.length; i++) {
            console.log(`${systemWithWinners[i].name}: ${systemWithWinners[i].winner.vote}`)
        }

        return;
    }

    let firstCandidatePercentage = Math.floor(systemWithWinners[0].winner.vote / totalVotes  * 100);
    let secondCandidatePercentage = Math.floor(systemWithWinners[1].winner.vote / totalVotes  * 100);

    console.log(`Runoff between ${systemWithWinners[0].winner.name} with ${firstCandidatePercentage}% and ${systemWithWinners[1].winner.name} with ${secondCandidatePercentage}%`)
}

main([ { system: 'Tau',     candidate: 'Flying Shrimp', votes: 150 },
    { system: 'Tau',     candidate: 'Space Cow',     votes: 100 },
    { system: 'Theta',   candidate: 'Space Cow',     votes: 10 },
    { system: 'Sigma',   candidate: 'Space Cow',     votes: 200 },
    { system: 'Sigma',   candidate: 'Flying Shrimp', votes: 75 },
    { system: 'Omicron', candidate: 'Flying Shrimp', votes: 50 },
    { system: 'Omicron', candidate: 'Octocat',       votes: 75 } ]
);