function biggerHalf(numbers){

    numbers.sort((a,b) => a- b);

    let calculateHalf = Math.ceil(numbers.length / 2);

    return numbers.splice(-calculateHalf);

}

console.log(biggerHalf([4, 7, 2, 5]))
console.log(biggerHalf([3, 19, 14, 7, 2, 19, 6]))