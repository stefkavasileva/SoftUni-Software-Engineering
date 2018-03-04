let sortedTickets = (function () {
    let tickets = [];

    class Tickets{
        constructor(destination,price,status){
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }


    return function (inputArr,criteria) {
        for (let inputElement of inputArr) {
            let args = inputElement.split('|');
            let destination = args[0];
            let price = Number(args[1]);
            let status = args[2];

            tickets.push(new Tickets(destination,price,status));
        }

        tickets = tickets.sort((a,b) => {
           if(a[criteria] < b[criteria]){
               return -1;
           }

           if(a[criteria] > b[criteria]){
               return 1;
           }

           return 0;
        });

        return tickets;
    };
})();

let sortFunction = sortedTickets;
console.log(sortFunction(['Philadelphia|94.20|available',
        'New York City|95.99|available',
        'New York City|95.99|sold',
        'Boston|126.20|departed'],
    'status'));