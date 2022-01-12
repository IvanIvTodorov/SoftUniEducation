function returnBiggest(matrix) {

    let max = Number.NEGATIVE_INFINITY;

    for (const row of matrix) {
        for (const element of row) {
            if (element > max) {
                max = element;
            }
        }
    }

    return max;
}

console.log(returnBiggest([[20, 50, 10], [8, 33, 145]]))