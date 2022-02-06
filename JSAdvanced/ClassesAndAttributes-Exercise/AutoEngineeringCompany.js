function cars(input){
    let collection = {};

    for (const item of input) {
        let [brand, model, qty] = item.split(' | ');

        if (collection[brand]) {
            if (collection[brand][model]) {
                collection[brand][model] += Number(qty);
            }else{
                collection[brand][model] = Number(qty);
            };
        }else{
            collection[brand] = {
                [model]: Number(qty)
            };
        }
    }

   for (const [car, models] of Object.entries(collection)) {
        console.log(car);
        for (const [model, qty] of Object.entries(models)) {
            console.log(`###${model} -> ${qty}`);
        }
   }
}

cars(['Audi | Q7 | 1000',
'Audi | Q6 | 100',
'BMW | X5 | 1000',
'BMW | X6 | 100',
'Citroen | C4 | 123',
'Volga | GAZ-24 | 1000000',
'Lada | Niva | 1000000',
'Lada | Jigula | 1000000',
'Citroen | C4 | 22',
'Citroen | C5 | 10']
)