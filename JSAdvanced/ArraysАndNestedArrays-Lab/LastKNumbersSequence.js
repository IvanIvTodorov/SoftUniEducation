function sumLastKNumbers(length, numsToSum) {

    const output = [1];

    for (let index = 0; index < length - 1; index++) {

        let lastKNumbers = output.slice(-numsToSum)
        let sum = 0;

        for (let i = 0; i < lastKNumbers.length; i++) {

            sum += lastKNumbers[i];
        }

        output.push(sum);
    }

    return output;
}

console.log(sumLastKNumbers(6, 3));
console.log(sumLastKNumbers(8, 2));