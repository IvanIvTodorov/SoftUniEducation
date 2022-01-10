function logNums(params) {
    
    let result = 0;

    params.forEach(element => result += element);
    console.log(result);

    result = 0;

    params.forEach(element => result += 1 / element);

    console.log(result);

    let output = "";

    params.forEach(element => output += `${element}`);

    console.log(output);
}

logNums([1,2,3])
logNums([2,4,8,16])