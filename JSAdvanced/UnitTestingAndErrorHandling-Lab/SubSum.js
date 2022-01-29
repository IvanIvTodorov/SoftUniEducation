function calculate(arr, start, end) {
    let sum = 0;

    if (start < 0) {
        start = 0;
    };
    if (end > arr.length - 1) {
        end = arr.length - 1;
    };

    for (let index = start; index <= end; index++) {
        sum += Number(arr[index]);      
    }

    return sum;
}

console.log(calculate([10, 20, 30, 40, 50, 60], 3, 300));
console.log(calculate([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1));
console.log(calculate([10, 'twenty', 30, 40], 0, 2));
console.log(calculate([], 1, 2));
console.log(calculate('text', 0, 2));