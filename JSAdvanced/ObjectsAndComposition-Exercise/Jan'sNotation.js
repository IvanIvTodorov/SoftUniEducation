function calculate(input) {
    let nums = input.filter(Number);
    let operands = input.filter(n => n != parseInt(n));
    
    if (nums.length - operands.length >= 2) {
        console.log("Error: too many operands!");
    } else if (nums.length - operands.length < 1) {
        console.log("Error: not enough operands!");
    } else {
        while (input.length > 1) {
            for (const index in input) {

                if (input[index] == "+") {
                    calc = input[index - 2] + input[index - 1];
                } else if (input[index] == "-") {
                    calc = input[index - 2] - input[index - 1];
                } else if (input[index] == "*") {
                    calc = input[index - 2] * input[index - 1];
                } else {
                    calc = input[index - 2] / input[index - 1];
                }

                if (typeof input[index] === 'string') {
                    input.splice(index - 2, 3, calc);
                    break;
                }
            }
        }  
        console.log(Number(input));
    }
}

calculate([31,
    2,
    '+',
    11,
    "/"
]
);
calculate([5,
    3,
    4,
    '*',
    '-']
);
calculate([7,
    33,
    8,
    '-']
);
calculate([15,
    '/']
);