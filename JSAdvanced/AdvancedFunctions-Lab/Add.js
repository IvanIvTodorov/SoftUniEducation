function solution(num){
    let current = 0;

    return function (current){
        current += num;
        return current;
    }
}

let add5 = solution(5);
console.log(typeof add5)
console.log(add5(2));
console.log(add5(3));
