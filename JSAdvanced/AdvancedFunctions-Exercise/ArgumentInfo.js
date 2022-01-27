function solve(...args){
    let output = [];

    for (const item of args) {
        console.log(`${typeof item}: ${item}`)
        let temp = output.find(obj => obj[typeof item]);

        if (temp) {       
            temp[typeof item] += 1; 
        }else
        output.push({
            [typeof item]: 1
        })
    }
    output.sort((a ,b) => Object.values(b) - Object.values(a));

    for (const item of output) {
        console.log(`${Object.keys(item)} = ${Object.values(item)}`)
    }
};

solve('cat', 'rat', 58, function () { console.log('Hello world!'); })