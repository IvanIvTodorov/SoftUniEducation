function add(first) {
    
    function sum(second) {
        first += second;
        return sum;
    }

    sum.toString = function(){
        return first;
    }

    return sum;
}
console.log(Number(add(1)(6)(-3)))