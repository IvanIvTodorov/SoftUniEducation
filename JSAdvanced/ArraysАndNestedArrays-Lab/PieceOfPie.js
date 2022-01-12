function pieces(input, start, end){

    let from = input.indexOf(start);
    let to = input.indexOf(end);

    return  input.splice(from, to - from + 1);
}

console.log(pieces(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'
))