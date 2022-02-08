class SummerCamp {
    constructor(organizer, location) {
        this.organizer = organizer;
        this.location = location;
        this.priceForTheCamp = {
            child: 150,
            student: 300,
            collegian: 500
        };
        this.listOfParticipants = [];
    };

    registerParticipant(name, condition, money) {
        if (!Object.keys(this.priceForTheCamp).includes(condition)) {
            throw new Error('Unsuccessful registration at the camp.');
        };

        if (this.listOfParticipants.find(x => x.name == name)) {
            return `The ${name} is already registered at the camp.`;
        };

        if (money < this.priceForTheCamp[condition]) {
            return `The money is not enough to pay the stay at the camp.`;
        };

        this.listOfParticipants.push({
            name,
            condition,
            money,
            power: 100,
            wins: 0
        });

        return `The ${name} was successfully registered.`
    };

    unregisterParticipant(name) {
        if (!this.listOfParticipants.find(x => x.name == name)) {
            throw new Error(`The ${name} is not registered in the camp.`);
        };

        let temp = this.listOfParticipants.find(x => x.name == name);
        let index = this.listOfParticipants.indexOf(temp);

        this.listOfParticipants.splice(index, 1);

        return `The ${name} removed successfully.`
    };

    timeToPlay(typeOfGame, participant1, participant2) {
        let first = this.listOfParticipants.find(x => x.name == participant1);
        let second = this.listOfParticipants.find(x => x.name == participant2);

        if (!first) {
            throw new Error(`Invalid entered name/s.`);
        };

        if (typeOfGame == 'WaterBalloonFights') {
            if (!first || !second) {
                throw new Error(`Invalid entered name/s.`);
            };

            if (first.condition != second.condition) {
                throw new Error(`Choose players with equal condition.`);
            };

            if (first.power > second.power) {
                first.wins += 1;
                return `The ${first.name} is winner in the game ${typeOfGame}.`
            } else if (second.power > first.power) {
                second.wins += 1;
                return `The ${second.name} is winner in the game ${typeOfGame}.`
            } else {
                return 'There is no winner.';
            }


        } else {
            first.power += 20;

            return `The ${first.name} successfully completed the game ${typeOfGame}.`
        };
    };


    toString() {
        this.listOfParticipants.sort((a, b) => b.wins - a.wins);
        let temp = '';

        for (const item of this.listOfParticipants) {
            temp += `${item.name} - ${item.condition} - ${item.power} - ${item.wins}\n`;
        };

        return `${this.organizer} will take ${this.listOfParticipants.length} participants on camping to ${this.location}\n` + temp.trimEnd();
    }
}

const summerCamp = new SummerCamp("Jane Austen", "Pancharevo Sofia 1137, Bulgaria");
console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
console.log(summerCamp.timeToPlay("Battleship", "Petar Petarson"));
console.log(summerCamp.registerParticipant("Sara Dickinson", "child", 200));
//console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Sara Dickinson"));
console.log(summerCamp.registerParticipant("Dimitur Kostov", "student", 300));
console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Dimitur Kostov"));

console.log(summerCamp.toString());




