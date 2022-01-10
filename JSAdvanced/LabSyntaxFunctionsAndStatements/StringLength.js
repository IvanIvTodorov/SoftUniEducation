
function calculate(...params) {
    let sum = 0;
    params.forEach(element => sum += element.length);

    console.log(sum);
    console.log(Math.floor(sum / params.length))
}

calculate('chocolate', 'ice cream', 'cake')
calculate('pasta', '5', '22.3')