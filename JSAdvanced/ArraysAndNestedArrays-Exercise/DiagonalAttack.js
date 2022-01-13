function sumDiagonals(input) {
    let matrix = [];
    for (let r = 0; r < input.length; r++) {
        let rowSymbols = input[r].split(' ').map(a => Number(a));

        matrix.push(rowSymbols);
    }

    let i = 1;
    let firstSum = 0;
    let secSum = 0;

    for (let index = 0; index < matrix.length; index++) {
        firstSum += matrix[index][index];
        secSum += matrix[index][matrix.length - i++];
    }

    if (firstSum === secSum) {
        i = 1;
        for (let r = 0; r < matrix.length; r++) {
            for (let c = 0; c < matrix[r].length; c++) {
                if (r != c && c != matrix.length - i) {
                    matrix[r][c] = firstSum;
                }

            }
            i++;
        }
    }

    for (let start = 0; start < matrix.length; start++) {
        console.log(matrix[start].join(" "));
    }
}

sumDiagonals(['5 3 12 3 1',
    '11 4 23 2 5',
    '101 12 3 21 10',
    '1 4 5 2 2',
    '5 22 33 11 1']
)