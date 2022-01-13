function printNthElement(input, step){
    let output = [];

    for (let i = 0; i < input.length; i+= step) {
        output.push(input[i]);
    }

    return output;
}

console.log(printNthElement(['5', 
'20', 
'31', 
'4', 
'20'], 
2
))

console.log(printNthElement(['dsa',
'asd', 
'test', 
'tset'], 
2
))
