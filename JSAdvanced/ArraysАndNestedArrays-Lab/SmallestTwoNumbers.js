function smallestTwoNums(numbers){

    let first = Math.min(...numbers);
    let indexOfFirst = numbers.indexOf(first);
    numbers.splice(indexOfFirst, 1);
    let second = Math.min(...numbers);

    console.log(`${first} ${second}`);
}

smallestTwoNums([30, 15, 50, 5]);
smallestTwoNums([3, 0, 10, 4, 7, 3]);