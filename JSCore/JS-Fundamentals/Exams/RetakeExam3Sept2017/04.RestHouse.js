function roomsReport(roomsInput,peopleInput) {
   let movedGuests = 0;
    for (let people of peopleInput) {
        let firstGuest = people.first;
        let secondGuest = people.second;

        if(firstGuest.gender !== secondGuest.gender){
            let currentRoom = roomsInput.find(x => x.type === 'double-bedded' && !x.hasOwnProperty('guests'));
            if(currentRoom){
                currentRoom['guests'] = [];
                currentRoom.guests.push(firstGuest);
                currentRoom.guests.push(secondGuest);
                continue;
            }

            movedGuests += 2;
            continue;
        }

        let hasPushed = pushGuest(firstGuest,roomsInput);
        if(!hasPushed){
            movedGuests++;
        }

        hasPushed = pushGuest(secondGuest,roomsInput);

        if(!hasPushed){
            movedGuests++;
        }
    }

    function pushGuest(guest, rooms){
        let isPushed = false;
        for (let currentRoom of rooms.filter(x => x.type === 'triple')) {
            if(!currentRoom.hasOwnProperty('guests')){
                currentRoom['guests'] = [];
                currentRoom.guests.push(guest);
                isPushed = true;
                break;
            }

            if(currentRoom.guests[0].gender === guest.gender && currentRoom.guests.length < 3){
                currentRoom.guests.push(guest);
                isPushed = true;
                break;
            }
        }

        return isPushed;
    }

    let sortedRooms = roomsInput.sort((a,b) => a.number.localeCompare(b.number));
    for (let room of sortedRooms) {
        console.log(`Room number: ${room.number}`);

        let bedsCount = room.type === 'triple' ? 3 : 2;

        if(!room.hasOwnProperty('guests')){
            console.log(`Empty beds in the room: ${bedsCount}`);
            continue;
        }

        let guests = room.guests.sort((a,b) => a.name.localeCompare(b.name));
        for (let guest of guests) {
            console.log(`--Guest Name: ${guest.name}`);
            console.log(`--Guest Age: ${guest.age}`);
        }

        let freeBeds = bedsCount - guests.length;
        console.log(`Empty beds in the room: ${freeBeds}`);
    }

    console.log(`Guests moved to the tea house: ${movedGuests}`);
}

roomsReport([ { number: '101A', type: 'double-bedded' },
        { number: '104', type: 'triple' },
        { number: '101B', type: 'double-bedded' },
        { number: '102', type: 'triple' } ],
    [ { first: { name: 'Sushi & Chicken', gender: 'female', age: 15 },
        second: { name: 'Salisa Debelisa', gender: 'female', age: 25 } },
        { first: { name: 'Daenerys Targaryen', gender: 'female', age: 20 },
            second: { name: 'Jeko Snejev', gender: 'male', age: 18 } },
        { first: { name: 'Pesho Goshov', gender: 'male', age: 20 },
            second: { name: 'Gosho Peshov', gender: 'male', age: 18 } },
        { first: { name: 'Conor McGregor', gender: 'male', age: 29 },
            second: { name: 'Floyd Mayweather', gender: 'male', age: 40 } } ]
);