class Circle{
    constructor(r){
        this._radius = r;
    };
    
    get radius(){
        return this._radius;
    };

    set radius(number){
        this._radius = number;
    }
    get diameter(){
        return this._radius * 2;
    };
    
    set diameter(number){
        this._radius = number / 2;
    };

    get area(){
        return Math.PI * this._radius ** 2;
    };
}



let c = new Circle(2);
console.log(`Radius: ${c.radius}`);
console.log(`Diameter: ${c.diameter}`);
console.log(`Area: ${c.area}`);
c.diameter = 1.6;
console.log(`Radius: ${c.radius}`);
console.log(`Diameter: ${c.diameter}`);
console.log(`Area: ${c.area}`);
