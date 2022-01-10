function startCook(...params) {
    
    let number = Number(params[0]);

    params.slice(1).forEach(element => {
        if (element == 'chop') {
            number /= 2;
        }else if (element == 'dice') {
            number = Math.sqrt(number);
        } else if (element == 'spice') {
            number += 1;
        } else if (element == 'bake') {
            number *= 3;
        }else {
            number -= number * 0.2;
        }
        console.log(number);
    });
}

//startCook('32', 'chop', 'chop', 'chop', 'chop', 'chop')
startCook('9', 'dice', 'spice', 'chop', 'bake', 'fillet')