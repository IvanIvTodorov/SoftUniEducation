function calculate(first, second, operator){

    switch (operator) {
        case '+':
            console.log(first + second);
            break;
        case '-':
            console.log(first - second);
            break;
        case '*':
            console.log(first * second);
            break;
         case '/':
            console.log(first / second);
            break;
        case '**':
            console.log(first ** second);
            break;
        case '%':
            console.log(first % second);
            break;
    }
}
