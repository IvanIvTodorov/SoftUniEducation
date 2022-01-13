function orbit(input) {
    const size = input[0];
    const starRow = input[2];
    const starCol = input[3];

    const matrix = [];
    for (let r = 0; r < size; r++) {
        matrix.push(Array(size).fill("-"))
    }

    for (let row = 0; row < size; row++) {
        for (let col = 0; col < size; col++) {
            matrix[row][col] = Math.max(Math.abs(row - starRow), Math.abs(col - starCol)) + 1;
        }
    }

    for (const element of matrix) {
        console.log(element.join(" "));
    }
}

orbit([4, 4, 2, 2])