function Person(first, second){
    this.firstName = first;
    this.lastName = second;

    Object.defineProperty(this, 'fullName', {
        set: function(value){
            let splitted = value.split(' ');
            if (splitted.length == 2) {              
                this.firstName = splitted[0];
                this.lastName = splitted[1];
            }
        },
        get: function(){
            return  `${this.firstName} ${this.lastName}`;
        }
    })
};

let person = new Person("Peter", "Ivanov");
console.log(person.fullName); //Peter Ivanov
person.firstName = "George";
console.log(person.fullName); //George Ivanov
person.lastName = "Peterson";
console.log(person.fullName); //George Peterson
person.fullName = "Nikola Tesla";
console.log(person.firstName); //Nikola
console.log(person.lastName); //Tesla
