function calculate(matrix) {

    let first = 0;
    let second = 0;
    let i = 1;
    for (let index = 0; index < matrix.length; index++) {

        first += matrix[index][index];
        second += matrix[index][matrix.length - i++]
    }

    return `${first} ${second}`
}

console.log(calculate([[20, 40], [10, 60]]))
console.log(calculate([[3, 5, 17], [-1, 7, 14], [1, -8, 89]]))