function carFactory(obj) {

    const engines = {
        Small: {
            power: 90,
            volume: 1800
        },
        Normal: {
            power: 120,
            volume: 2400
        },
        Monster: {
            power: 200,
            volume: 3500
        }
    };

    const carriage = {
        Hatchback: {
            type: "hatchback",
            color: ""
        },
        Coupe: {
            type: "coupe",
            color: ""
        }
    };

    const car = {};
    car.model = obj.model;
    const test = [];

    for (const [key, value] of Object.entries(engines)) {
        test.push(value.power);
    }

    const engineToPick = test.reduce((a, b) => Math.abs(b - obj.power) < Math.abs(a - obj.power) ? b : a)

    for (const [key, value] of Object.entries(engines)) {
        if (engineToPick == value.power) {
            car.engine = value;
        }
    };

    for (const [key, value] of Object.entries(carriage)) {

        if (obj.carriage == value.type) {
            carriage[key].color = obj.color;
            car.carriage = value;
        }
    };
    car.wheels = Array(4).fill(obj.wheelsize);

    if (obj.wheelsize % 2 == 0) {
        car.wheels.fill(obj.wheelsize - 1);
    }

    return car;
}

console.log(carFactory({
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
}
));
console.log(carFactory({
    model: 'Opel Vectra',
    power: 110,
    color: 'grey',
    carriage: 'coupe',
    wheelsize: 17
}
));