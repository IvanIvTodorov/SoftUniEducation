function area(r) {
    
    if (typeof r == "number") {
        let result = r ** 2 * Math.PI;

    console.log(result.toFixed(2));
    } else {
        console.log(`We can not calculate the circle area, because we receive a ${typeof r}.`)
    }
}

area(5)
area("sdfa")