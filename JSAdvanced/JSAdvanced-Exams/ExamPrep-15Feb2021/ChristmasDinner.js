class ChristmasDinner{
    constructor(budget){
        this.budget = budget;
        this.dishes = [];
        this.products = [];
        this.guests = {};
    };

    get budget(){
        return this._budget;
    };

    set budget(number){
        if (number < 0) {
            throw new Error('The budget cannot be a negative number')
        };

        this._budget = number;
    };

    shopping(product){
        let [name, price ] = product;

        if (this.budget < price) {
            throw new Error("Not enough money to buy this product");
        };

        this.budget -= price;
        this.products.push(name);
        return `You have successfully bought ${name}!`
    };

    recipes(recipe){

        let name = recipe.recipeName;
        let items = recipe.productsList;
        let isContained = true;

        for (const product of items) {
            
            if (!this.products.includes(product)) {
                isContained = false;
                break;
            }
        };

        if (isContained) {
            this.dishes.push({
                recipeName: name,
                productsList: items
            });

            return `${name} has been successfully cooked!`;
        }else{
            throw new Error("We do not have this product");
        };
    };

    inviteGuests(name, dish){

        if (!this.dishes.find(x => x.recipeName == dish)) {
            throw new Error("We do not have this dish");
        };

        if (Object.keys(this.guests).includes(name)) {
            throw new Error("This guest has already been invited");
        };

        this.guests[name] = dish;
        return `You have successfully invited ${name}!`
    };

    showAttendance(){
        let text = '';

        for (const guest of Object.keys(this.guests)) {
            let tempDish = this.guests[guest];
            let tempDishList = this.dishes.find(x => x.recipeName == tempDish);

            text += `${guest} will eat ${tempDish}, which consists of ${tempDishList.productsList.join(', ')}\n`;
        };

        return text.trimEnd();
    };
};

let dinner = new ChristmasDinner(300);

dinner.shopping(['Salt', 1]);
dinner.shopping(['Beans', 3]);
dinner.shopping(['Cabbage', 4]);
dinner.shopping(['Rice', 2]);
dinner.shopping(['Savory', 1]);
dinner.shopping(['Peppers', 1]);
dinner.shopping(['Fruits', 40]);
dinner.shopping(['Honey', 10]);

dinner.recipes({
    recipeName: 'Oshav',
    productsList: ['Fruits', 'Honey']
});
dinner.recipes({
    recipeName: 'Folded cabbage leaves filled with rice',
    productsList: ['Cabbage', 'Rice', 'Salt', 'Savory']
});
dinner.recipes({
    recipeName: 'Peppers filled with beans',
    productsList: ['Beans', 'Peppers', 'Salt']
});

dinner.inviteGuests('Ivan', 'Oshav');
dinner.inviteGuests('Petar', 'Folded cabbage leaves filled with rice');
dinner.inviteGuests('Georgi', 'Peppers filled with beans');

console.log(dinner.showAttendance());
