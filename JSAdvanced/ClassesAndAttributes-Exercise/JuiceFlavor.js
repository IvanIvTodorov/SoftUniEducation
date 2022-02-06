function makeBottles(input) {
    let bottles = {};
    let value = {};

    for (const item of input) {
        let [product, qty] = item.split(' => ');

        if (value[product]) {
            value[product] += Number(qty);
        } else {
            value[product] = Number(qty);
        };

        while (value[product] >= 1000) {
            value[product] -= 1000;

            if (bottles[product]) {
                bottles[product]++;
            } else {
                bottles[product] = 1;
            };
        };
    };

    let result = [];
    for (const [key, value] of Object.entries(bottles)) {
        result.push(`${key} => ${value}`);
    };

    return result.join('\n');
};

console.log(makeBottles(['Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549']
));
