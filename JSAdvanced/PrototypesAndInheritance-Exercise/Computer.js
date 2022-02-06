function solve() {
    class Keyboard {
        constructor(manufacturer, responseTime) {
            this.manufacturer = manufacturer;
            this.responseTime = Number(responseTime);
        };
    };
    class Monitor {
        constructor(manufacturer, width, height) {
            this.manufacturer = manufacturer;
            this.width = Number(width);
            this.height = Number(height);
        };
    };
    class Battery {
        constructor(manufacturer, expectedLife) {
            this.manufacturer = manufacturer;
            this.expectedLife = Number(expectedLife);
        };
    };
    class Computer {
        constructor(manufacturer, processorSpeed, ram, hardDiskSpace) {
            if (this.constructor === Computer) {
                throw new Error;
            };
            this.manufacturer = manufacturer;
            this.processorSpeed = Number(processorSpeed);
            this.ram = Number(ram);
            this.hardDiskSpace = Number(hardDiskSpace);
        };
    };
    class Laptop extends Computer {
        constructor(manufacturer, processorSpeed, ram, hardDiskSpace, weight, color, battery) {
            super(manufacturer, processorSpeed, ram, hardDiskSpace);
            this.weight = Number(weight);
            this.color = color;
            this.battery = battery;
        };

        get battery() {
            return this._battery;
        };

        set battery(bat) {
            if (!(bat instanceof Battery)) {
                throw new TypeError;
            };
            this._battery = bat;
        };
    };
    class Desktop extends Computer {
        constructor(manufacturer, processorSpeed, ram, hardDiskSpace, keyboard, monitor) {
            super(manufacturer, processorSpeed, ram, hardDiskSpace);
            this.keyboard = keyboard;
            this.monitor = monitor;
        };

        get keyboard() {
            return this._keyboard;
        };

        set keyboard(key) {
            if (!(key instanceof Keyboard)) {
                throw new TypeError;
            };
            this._keyboard = key;
        };

        get monitor() {
            return this._monitor;
        };

        set monitor(mon) {
            if (!(mon instanceof Monitor)) {
                throw new TypeError;
            };
            this._monitor = mon;
        };
    }

    return {
        Keyboard,
        Monitor,
        Battery,
        Computer,
        Desktop,
        Laptop
    };
};

let classes = solve();
let Computer = classes.Computer;
let Laptop = classes.Laptop;
let Desktop = classes.Desktop;
let Monitor = classes.Monitor;
let Battery = classes.Battery;
let Keyboard = classes.Keyboard;

let battery = new Battery('Energy', 3);
console.log(battery);
let laptop = new Laptop("Hewlett Packard", 2.4, 4, 0.5, 3.12, "Silver", battery);
console.log(laptop);

let keyboard = new Keyboard('Acer', 55, 2);
let monitor = new Keyboard('Wizz', 66, 3);
console.log(keyboard);
console.log(monitor);

let desktop = new Desktop('HP', 2, 3, 4, keyboard, monitor);