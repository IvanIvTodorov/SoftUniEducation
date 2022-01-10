function roadRadar(speed, place) {
    
    let residental = 20
    let city = 50;
    let highway = 130;
    let interstate = 90;
    let typeOfSpeed = "";
    let result = 0;

    switch (place) {
        case 'residential':
            if (speed <= residental) {
                console.log(`Driving ${speed} km/h in a ${residental} zone`)
            } else {
                result = speed - residental;
                
                if (result <= 20) {
                    typeOfSpeed = 'speeding';
                } else if (result <= 40) {
                    typeOfSpeed = 'excessive speeding';
                } else {
                    typeOfSpeed = 'reckless driving';
                }
                console.log(`The speed is ${result} km/h faster than the allowed speed of ${residental} - ${typeOfSpeed}`)
            }
            break;
        case "city":
                if (speed  <= city) {
                    console.log(`Driving ${speed} km/h in a ${city} zone`)
                } else {
                    result = speed - city;
                
                    if (result <= 20) {
                        typeOfSpeed = 'speeding';
                    } else if (result <= 40) {
                        typeOfSpeed = 'excessive speeding';
                    } else {
                        typeOfSpeed = 'reckless driving';
                    }
                    console.log(`The speed is ${result} km/h faster than the allowed speed of ${city} - ${typeOfSpeed}`)
                }
            break;
        case "motorway":
                if (speed <= highway) {
                    console.log(`Driving ${speed} km/h in a ${highway} zone`)
                } else {
                    result = speed - highway;
                
                    if (result <= 20) {
                        typeOfSpeed = 'speeding';
                    } else if (result <= 40) {
                        typeOfSpeed = 'excessive speeding';
                    } else {
                        typeOfSpeed = 'reckless driving';
                    }
                    console.log(`The speed is ${result} km/h faster than the allowed speed of ${highway} - ${typeOfSpeed}`)
                }
            break;
        case "interstate":
                if (speed <= interstate) {
                    console.log(`Driving ${speed} km/h in a ${interstate} zone`)
                } else {
                    result = speed - interstate;
                
                    if (result <= 20) {
                        typeOfSpeed = 'speeding';
                    } else if (result <= 40) {
                        typeOfSpeed = 'excessive speeding';
                    } else {
                        typeOfSpeed = 'reckless driving';
                    }
                    console.log(`The speed is ${result} km/h faster than the allowed speed of ${interstate} - ${typeOfSpeed}`)
                }
            break;
        default:
            break;
    }
}

roadRadar(40, 'city')
roadRadar(21, 'residential')
roadRadar(120, 'interstate')
roadRadar(200, 'motorway')