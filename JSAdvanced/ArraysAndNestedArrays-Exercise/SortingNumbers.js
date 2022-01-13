function sortNumbers(input) {

    let output = [];
    let size = input.length;
    input.sort((a, b) => a - b);

    for (let index = 0; index < size; index++) {
        if (index % 2 == 0) {
            output.push(input.shift());
        } else {
            output.push(input.pop());
        }
    }
    return output;
}

console.log(sortNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18]))