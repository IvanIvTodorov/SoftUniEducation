class Person {
    constructor(first, last, age, mail) {
        this.firstName = first;
        this.lastName = last;
        this.age = age;
        this.email = mail;
    };

    toString() {
        return `${this.firstName} ${this.lastName} (age: ${this.age}, email: ${this.email})`
    };
};

let person = new Person('Anna', 'Simpson', 22, 'anna@yahoo.com');
console.log(person.toString());
