function getMostImportantPerson(personInfo) {
    let people = [];
    for (let i = 0; i < personInfo.length; i++) {
        let personArgs = personInfo[i].split('-');
        if(personArgs.length === 1){
            let currentPerson = {name: personArgs[0],subscribers: [],subscribedBy: new Set()};
            if(people.find(x => x.name === currentPerson.name)){
                continue;
            }

            people.push(currentPerson);
        }else {
            let firstPerson = people.find(x => x.name === personArgs[0]);
            let secondPerson = people.find(x => x.name === personArgs[1]);

            if(!firstPerson || !secondPerson){
                continue;
            }

             if(firstPerson.name !== secondPerson.name && !secondPerson.subscribers.find(x => x.name === firstPerson.name)){
                secondPerson.subscribers.push(firstPerson);
                firstPerson.subscribedBy.add(secondPerson);
             }
        }
    }


    let mostImportantPerson = people.sort(sortPeopleBySubscribers)[0];

    console.log(mostImportantPerson.name);
    let subscriberCount = 1;
    for (let subscriber of mostImportantPerson.subscribers) {
        console.log(`${subscriberCount}. ${subscriber.name}`);
        subscriberCount++;
    }

    function sortPeopleBySubscribers(a,b) {
        let subscribersLengthA = a.subscribers.length;
        let subscribersLengthB = b.subscribers.length;

        if(subscribersLengthA > subscribersLengthB){
            return -1;
        }else if(subscribersLengthA < subscribersLengthB){
            return 1;
        }else{
            let subscribedByLengthA = a.subscribedBy.size;
            let subscribedByLengthB = b.subscribedBy.size;

            if(subscribedByLengthA > subscribedByLengthB){
                return -1
            }else if(subscribedByLengthA < subscribedByLengthB){
                return 1;
            }

            return 0;
        }
    }
}

getMostImportantPerson(['A',
'Z',
'O',
'R',
'D',
'Z-O',
'R-O',
    'D-O',
    'P',
    'O-P',
    'O-Z',
    'R-Z',
    'D-Z']
);