function oddPositionsArray(numbers) {

    return numbers
        .filter((v , i) => i % 2 == 1)
        .map(n => n *= 2)
        .reverse()
        .join(" ");
}

console.log(oddPositionsArray([10, 15, 20, 25]));
console.log(oddPositionsArray([3, 0, 10, 4, 7, 3]));