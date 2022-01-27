function getFibonator(){
    let first = 1;
    let second = 0;

    return function solve(){
        let current = first + second;
        first = second;
        second = current;

        return current;
    }; 
};

let fib = getFibonator();
console.log(fib()); // 1
console.log(fib()); // 1
console.log(fib()); // 2
console.log(fib()); // 3
console.log(fib()); // 5
console.log(fib()); // 8
console.log(fib()); // 13
