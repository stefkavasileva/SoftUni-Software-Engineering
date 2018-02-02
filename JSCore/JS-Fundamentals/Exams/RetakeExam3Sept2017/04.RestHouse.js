function main(roomsInput,peopleInput) {
   let movedGuests = 0;
    for (let i = 0; i < peopleInput.length; i++) {
       let firstPerson = peopleInput[i].first;
       let secondPerson = peopleInput[i].second;
       if(firstPerson.gender !== secondPerson.gender){
           let doubleRoom = roomsInput.find(x => x.type === 'double-bedded' && !x.hasOwnProperty('guests'));

           if(doubleRoom === undefined){
               movedGuests += 2;
               continue;
           }
           doubleRoom['guests'] = peopleInput[i];
           continue;
       }

      let leftGuests = peopleInput[i];
        for (let room of roomsInput.filter(x => x.type === 'triple')) {
            if(leftGuests.second === undefined){
                break;
            }

            for (let key in leftGuests) {
                if(!room.hasOwnProperty('guests')){
                    room['guests'] = [];
                    room.guests.push(leftGuests[key]);
                    leftGuests[key] = undefined;
                    continue;
                }

                if(room.guests.length < 3){
                    if(room.guests[0].gender !== leftGuests[key].gender){
                        break;
                    }
                    room.guests.push(leftGuests[key]);
                    leftGuests[key] = undefined;
                    continue;
                }
            }
        }

        if(leftGuests.first !== undefined){
            movedGuests += 2;
        }else if(leftGuests.second !== undefined){
            movedGuests += 1;
        }
    }

    let roomsKeys = Array.from(roomsInput).sort((a,b) => a - b);
    for (let key of roomsKeys) {
        console.log(`Room number: ${key.number}`);
        let guests = key.guests;
        for (let guest of guests.keys()) {
            console.log(`--Guest Name: ${guest.name}`);
            console.log(`--Guest Age: ${guest.age}`);
        }

        let leftBeds = 0;
        if(key.type === 'triple'){
            leftBeds = key.guests.length - 3;
        }

        console.log(`Empty beds in the room: ${leftBeds}`);
    }

    console.log(`Guests moved to the tea house: ${movedGuests}`);


}

main([ { number: '206', type: 'double-bedded' },
    { number: '311', type: 'triple' } ],[ { first: { name: 'Tanya Popova', gender: 'female', age: 24 },
    second: { name: 'Miglena Yovcheva', gender: 'female', age: 23 } },
    { first: { name: 'Katerina Stefanova', gender: 'female', age: 23 },
        second: { name: 'Angel Nachev', gender: 'male', age: 22 } },
    { first: { name: 'Tatyana Germanova', gender: 'female', age: 23 },
        second: { name: 'Boryana Baeva', gender: 'female', age: 22 } } ])