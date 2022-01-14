function printTowns(input) {

    const towns = {}

    for (const pair of input) {

        const [town, population] = pair.split(" <-> ");
        if (towns.hasOwnProperty(town)) {
            towns[town] += Number(population);
        } else {
            towns[town] = Number(population);
        }
    }

    for (const [key, value] of Object.entries(towns)) {
        console.log(`${key} : ${value}`)
    }
}

// printTowns(['Sofia <-> 1200000',
//     'Montana <-> 20000',
//     'New York <-> 10000000',
//     'Washington <-> 2345000',
//     'Las Vegas <-> 1000000']
// )

printTowns(['Istanbul <-> 100000',
    'Honk Kong <-> 2100004',
    'Jerusalem <-> 2352344',
    'Mexico City <-> 23401925',
    'Istanbul <-> 1000']
)