function extractArray(input) {

    let output = [];
    let max = Number.NEGATIVE_INFINITY;
    for (let element of input) {
        if (element >= max) {
            output.push(element);
            max = element;
        }
    }
    return output;
}

console.log(extractArray([1,
    3,
    8,
    4,
    10,
    12,
    3,
    2,
    24]
))