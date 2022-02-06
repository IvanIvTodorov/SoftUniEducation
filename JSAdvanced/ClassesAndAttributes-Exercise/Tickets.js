function tickets(input, sorting) {
    let arr = [];

    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    };

    for (const string of input) {
        let [destination, price, status] = string.split('|');

        arr.push(new Ticket(destination, Number(price), status));
    };

    if (sorting == 'price') {
        arr.sort((a, b) => a[sorting] - b[sorting]);
    } else {
        arr.sort((a, b) => {
            return a[sorting].localeCompare(b[sorting])
        });
    }

    return arr;
}


console.log(tickets(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'destination'
));