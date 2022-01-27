function solution() {
    let stock = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    }

    return function (command) {
        let [com, type, value] = command.split(' ');
        let returnString = 'Success';

        if (com == 'restock') {
            stock[type] += Number(value);
        } else if (com == 'prepare') {
            if (type == 'apple') {
                if (stock.carbohydrate < 1 * value) {
                    returnString = `Error: not enough carbohydrate in stock`;
                } else if (stock.flavour < 2 * value) {
                    returnString = `Error: not enough flavour in stock`;
                } else {
                    stock.carbohydrate -= 1 * value;
                    stock.flavour -= 2 * value;
                }
            } else if (type == 'lemonade') {
                if (stock.carbohydrate < 10 * value) {
                    returnString = `Error: not enough carbohydrate in stock`;
                } else if (stock.flavour < 20 * value) {
                    returnString = `Error: not enough flavour in stock`;
                } else {
                    stock.carbohydrate -= 10 * value;
                    stock.flavour -= 20 * value;
                }
            } else if (type == 'burger') {
                if (stock.carbohydrate < 5 * value) {
                    returnString = `Error: not enough carbohydrate in stock`;
                } else if (stock.fat < 7 * value) {
                    returnString = `Error: not enough fat in stock`;
                } else if (stock.flavour < 3 * value) {
                    returnString = `Error: not enough flavour in stock`;
                } else {
                    stock.carbohydrate -= 5 * value;
                    stock.flavour -= 3 * value;
                    stock.fat -= 7 * value;
                }
            } else if (type == 'eggs') {
                if (stock.protein < 5 * value) {
                    returnString = `Error: not enough protein in stock`;
                } else if (stock.fat < 1 * value) {
                    returnString = `Error: not enough fat in stock`;
                } else if (stock.flavour < 1 * value) {
                    returnString = `Error: not enough flavour in stock`;
                } else {
                    stock.protein -= 5 * value;
                    stock.flavour -= 1 * value;
                    stock.fat -= 1 * value;
                }
            } else {
                if (stock.protein < 10 * value) {
                    returnString = `Error: not enough protein in stock`;
                } else if (stock.carbohydrate < 10 * value) {
                    returnString = `Error: not enough carbohydrate in stock`;
                } else if (stock.fat < 10 * value) {
                    returnString = `Error: not enough fat in stock`;
                } else if (stock.flavour < 10 * value) {
                    returnString = `Error: not enough flavour in stock`;
                } else {
                    stock.protein -= 10 * value;
                    stock.carbohydrate -= 10 * value;
                    stock.flavour -= 10 * value;
                    stock.fat -= 10 * value;
                }
            }

        } else {
            let current = '';
            for (const item of Object.keys(stock)) {
                current += `${item}=${stock[item]} `;
            }
            returnString = `protein=${stock.protein} carbohydrate=${stock.carbohydrate} fat=${stock.fat} flavour=${stock.flavour}`
        }
        return returnString;
    }
}

let manager = solution();
console.log(manager("restock flavour 50")); // Success 
console.log(manager("report")); // Success 
console.log(manager("prepare lemonade 4")); // Error: not enough carbohydrate in stock 
