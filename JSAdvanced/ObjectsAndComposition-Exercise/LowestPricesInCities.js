function printLowestPirce(arr){
    const listOfTowns = [];
    for (const input of arr) {
        
        let [town, product, price] = input.split(" | ");

        if (listOfTowns[product]) {
            if (listOfTowns[product].price > price) {
                listOfTowns[product].price = price;
                listOfTowns[product].town = town;
            }          
        }else{
            listOfTowns[product] = {town, price: Number(price)};
        }
    };

    for (const [key, value] of Object.entries(listOfTowns)) {
        console.log(`${key} -> ${value.price} (${value.town})`)
    }
}

printLowestPirce(['Sofia City | Audi | 100000',
'Sofia City | BMW | 100000',
'Mexico City | BMW | 99999',
'Sofia City | Mitsubishi | 10000',
'Sofia City | Mercedes | 10000',
'Sofia City | NoOffenseToCarLovers | 0',
'Mexico City | Audi | 1000',
'Mexico City | BMW | 99999',
'Mexico City | Mitsubishi | 10000',
'New York City | Mitsubishi | 1000',
'Washington City | Mercedes | 1000']
)