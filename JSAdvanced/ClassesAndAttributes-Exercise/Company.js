class Company {
    constructor() {
        this.departments = {};
    };

    addEmployee(...args) {

        for (const item of args) {
            if (!item || !item.toString().trim()) {
                throw new Error('Invalid Input!');
            };
        };

        let [name, salary, position, department] = args;

        if (Number(salary) < 0) {
            throw new Error('Invalid Input!');
        }

        let employee = {
            name: name,
            salary: Number(salary),
            position: position,
            department: department
        };

        if (this.departments[department]) {
            this.departments[department].push(employee);
        } else {
            this.departments[department] = [];
            this.departments[department].push(employee);
        };

        return `New employee is hired. Name: ${employee.name}. Position: ${employee.position}`.trim();
    };

    bestDepartment() {
        let best;
        let avg = 0;
        for (const [key, value] of Object.entries(this.departments)) {
            let current = 0;
            for (const employe of Array.from(value)) {
                current += employe.salary;
            };
            current = current / value.length;
            if (avg < current) {
                avg = current;
                best = key;
            };
        };

        this.departments[best].sort((a, b) => {
            return b.salary - a.salary || a.name.localeCompare(b.name);
        })

        let output = `Best Department is: ${best}\nAverage salary: ${avg.toFixed(2)}\n`;
        for (const item of this.departments[best]) {
            output += `${item.name} ${item.salary} ${item.position}\n`
        };

        return output.trim();
    };
};


let c = new Company();
console.log(c.addEmployee('a', 2000, "engineer", "Construction"));
console.log(c.addEmployee("Pesho", 1500, "electrical engineer", "Construction"));
console.log(c.addEmployee("Slavi", 500, "dyer", "Construction"));
console.log(c.addEmployee("Stan", 2000, "architect", "Construction"));
console.log(c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing"));
console.log(c.addEmployee("Pesho", 1000, "graphical designer", "Marketing"));
console.log(c.addEmployee("Gosho", 1350, "HR", "Human resources"));
console.log(c.bestDepartment());
