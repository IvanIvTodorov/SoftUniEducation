function sumFirstAndLast(numbers){

    const first = Number(numbers.shift());
    const last = Number(numbers.pop());

    return first + last;
}