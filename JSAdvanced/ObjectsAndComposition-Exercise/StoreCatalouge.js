function storeTheItems(arr) {
    const collection = [];
    for (const item of arr) {

        let [product, price] = item.split(" : ");

        collection.push({ product, price: Number(price) })
    }
    collection.sort((a, b) => a.product.localeCompare(b.product));

    let compare = collection[0].product[0];
    console.log(compare);
    console.log(`  ${collection[0].product}: ${collection[0].price}`)
    collection.splice(0, 1);

    for (const iterator of collection) {
        if (iterator.product[0] != compare) {
            compare = iterator.product[0];
            console.log(compare);
        }
        console.log(`  ${iterator.product}: ${iterator.price}`);
    }
}

storeTheItems(['Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10']
)