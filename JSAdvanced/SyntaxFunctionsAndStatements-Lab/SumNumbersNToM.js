function calculate(first, second) {
    
    let result = 0;

    for (let index = Number(first); index <= Number(second); index++) {
        result += index 
    }

    console.log(result);
}

calculate('-8', '20');
calculate('-8', '50');
calculate('-8', '25');