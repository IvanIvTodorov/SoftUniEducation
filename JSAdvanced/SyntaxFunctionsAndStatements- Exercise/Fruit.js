function calculatePrice(name,grams,price){

    let kg = grams / 1000;
    let sum = kg * price;

    console.log(`I need $${sum.toFixed(2)} to buy ${kg.toFixed(2)} kilograms ${name}.`)
}

calculatePrice('orange', 2500, 1.80)