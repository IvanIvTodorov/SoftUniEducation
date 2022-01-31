function getPersons(){
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
    

    let person1 = new Person('Anna', 'Simpson', 22, 'anna@yahoo.com');
    let person2 = new Person('SoftUni');
    let person3 = new Person('Stephan', 'Johnson', 25);
    let person4 = new Person('Gabriel', 'Peterson', 24, 'g.p@gmail.com');

    let persons = [];
    persons.push(person1);
    persons.push(person2);
    persons.push(person3);
    persons.push(person4);

    return persons;
}