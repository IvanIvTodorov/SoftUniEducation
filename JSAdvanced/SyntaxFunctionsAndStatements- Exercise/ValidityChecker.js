function check(firstX, firstY, secondX, secondY) {
    
    if (Number.isInteger(Math.sqrt(Math.pow(firstX, 2) + Math.pow(firstY, 2)))) {
        console.log(`{${firstX}, ${firstY}} to {0, 0} is valid`);
    } else {
        console.log(`{${firstX}, ${firstY}} to {0, 0} is invalid`);
    }


    if (Number.isInteger(Math.sqrt(Math.pow(secondX, 2) + Math.pow(secondY, 2)))) {
        console.log(`{${secondX}, ${secondY}} to {0, 0} is valid`);
    } else {
        console.log(`{${secondX}, ${secondY}} to {0, 0} is invalid`);
    }

    let distance = Math.sqrt(Math.pow((firstX - secondX), 2) + Math.pow((firstY - secondY), 2));
    if (Number.isInteger(distance)) {
        console.log(`{${firstX}, ${firstY}} to {${secondX}, ${secondY}} is valid`);
    } else {
        console.log(`{${firstX}, ${firstY}} to {${secondX}, ${secondY}} is invalid`);
    }
}

check(3, 0, 0, 4)