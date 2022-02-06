class Hex {
    constructor(value) {
        this.value = value;
    };

    valueOf() {
        return this.value;
    };

    plus(item) {
        if (Number(item)) {
            return new Hex(this.value + item);
        };

        return new Hex(this.value + item.value);
    };

    minus(item) {
        if (Number(item)) {
            return new Hex(this.value - item);
        };

        return new Hex(this.value - item.value);
    };

    parse(item) {
        return parseInt(item, 16);
    };

    toString() {
        return '0x' + this.value.toString(16).toUpperCase();
    };
}

let FF = new Hex(255);
console.log(FF.toString());
let a = new Hex(10);
let b = new Hex(5);
console.log(a.plus(b).toString());
console.log(a.plus(b).toString() === '0xF');
console.log(FF.parse('AAA'));

