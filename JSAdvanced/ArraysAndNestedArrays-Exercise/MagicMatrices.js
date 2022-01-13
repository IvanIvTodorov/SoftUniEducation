function isMagic(matrix) {

    let sum = 0;
    let colSum = 0;

    for (let row = 0; row < matrix.length; row++) {
        let current = 0;
        for (let col = 0; col < matrix[row].length; col++) {
            if (row == 0) {
                sum += matrix[row][col];
                current = sum;
            } else {
                current += matrix[row][col];
            }
        }
        if (sum != current) {
            return false;
        }
    }

    for (let col = 0; col < matrix[0].length; col++) {
        let colCurrent = 0;
        for (let row = 0; row < matrix.length; row++) {
            if (col == 0) {
                colSum += matrix[row][col];
                colCurrent = colSum;
            } else {
                colCurrent += matrix[row][col];
            }
        }

        if (colSum != colCurrent) {
            return false
        }
    }
    return true;
}

console.log(isMagic([[11, 32, 45],
[21, 0, 1],
[21, 1, 1]]
))

console.log(isMagic([[4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]]
   ))
console.log(isMagic([[1, 0, 0],
    [0, 0, 1],
    [0, 1, 0]]
   ))