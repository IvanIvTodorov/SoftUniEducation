function sortNumbers(numbers){
    
    let result = [];
    numbers.forEach(v => v < 0 ? result.unshift(v) : result.push(v));

   console.log(result.join('\n'))
}

sortNumbers([7, -2, 8, 9]);
sortNumbers([3, -2, 0, -1]);