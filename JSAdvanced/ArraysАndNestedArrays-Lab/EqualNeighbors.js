function equal(matrix) {

    let result = 0;
    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            if (row < matrix.length - 1) {
                if (matrix[row][col] === matrix[row + 1][col]) {
                    result++;
                }
            }
            if (row > 0) {
                if (matrix[row][col] === matrix[row - 1][col]) {
                    result++;
                }
            }
            if (col < matrix[row].length) {
                if (matrix[row][col] === matrix[row][col + 1]) {
                    result++;
                }
            }
            if (col > 0) {
                if (matrix[row][col] === matrix[row][col - 1]) {
                    result++;
                }
            }
            matrix[row][col] = "-";
        }
    }

    return result;
}
console.log(equal([['2', '3', '4', '7', '0'], ['4', '0', '5', '3', '4'], ['2', '3', '5', '4', '2'], ['9', '8', '7', '5', '4']]))
console.log(equal([['test', 'yes', 'yo', 'ho'],
['well', 'done', 'yo', '6'],
['not', 'done', 'yet', '5']]
))