function hierarchy() {
    class Figure {
        constructor(units = 'cm') {
            this.units = units;
        };

        get area() {
        };

        changeUnits(value) {
            this.units = value;
        };

        toString() {
            return `Figures units: ${this.units} `;
        }
    };

    class Circle extends Figure {
        constructor(radius) {
            super()
            this.radius = radius;          
        };

        get area() {
            let tempRad =  this.changeUnits(this.units);
            return Math.PI * tempRad * tempRad;
        };

        changeUnits(value) {
            let r = this.radius;

            if (value == 'm') {
                r *= 0.01;
            }else if (value == 'mm'){
                r *= 10;
            };

            return r;
        };

        toString() {
            return super.toString() + `Area: ${this.area} - radius: ${this.radius}`;
        };
    };

    class Rectangle extends Figure {
        constructor(width, height, units) {
            super(units);
            this.width = width;
            this.height = height;  
            this.tempHeight;
            this.tempWidth;       
        };

        get area() {
            let [tempWidth,tempHeight] =  this.changeUnits(this.units);
            this.tempHeight = tempHeight;
            this.tempWidth = tempWidth;
            return tempWidth * tempHeight;
        };

        changeUnits(value) {
            let h = this.height;
            let w = this.width;
            this.units = value;
            
            if (value == 'm') {
                h *= 0.01;
                w *= 0.01;
            }else if (value == 'mm'){
                h *= 10;
                w *= 10;
            };

            return [w, h] ;
        };

        toString() {
            return super.toString() + `Area: ${this.area} - width: ${this.tempWidth}, height: ${this.tempHeight}`;
        };
    }
    return {
        Figure,
        Circle,
        Rectangle
    };
};

let temp = hierarchy();
let Rectangle = temp.Rectangle;
let r = new Rectangle(3,4, 'mm');
r.changeUnits('m');
console.log(r.toString());