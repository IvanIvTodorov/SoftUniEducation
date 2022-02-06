class List {
    constructor() {
        this.list = [];
        this.size = 0;
    };

    add(num) {
        this.list.push(num);
        this.list.sort((a, b) => a - b);
        this.size++;
    };

    remove(index) {
        if (index >= 0 && index < this.list.length) {
            this.list.splice(index, 1);
            this.size--;
        }
    };

    get(index) {
        if (index >= 0 && index < this.list.length) {
            return this.list[index];
        }
    };
};

let list = new List();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
console.log(list.size);
list.remove(1);
console.log(list.get(1));
console.log(list.size);

