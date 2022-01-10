function logSquare(size = 5) {

    for (let i = 0; i < size; i++) {
        let result = "";

        for (let j = 0; j < size; j++) {

            result += '* ';
        }
        console.log(result);
    }
}

logSquare()