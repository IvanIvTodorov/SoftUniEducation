function createInventory(arr) {
    const allHeroes = [];
    for (const current of arr) {
        const hero = {
            name: current.split(" / ")[0],
            level: Number(current.split(" / ")[1]),
            items: []
        }

        let temp = current.split(" / ")[2];
        if (temp) {
            for (const item of temp.split(", ")) {
                hero.items.push(item);
            }
        }

        allHeroes.push(hero);
    }
    return JSON.stringify(allHeroes);
}

console.log(createInventory(['Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 ']
));