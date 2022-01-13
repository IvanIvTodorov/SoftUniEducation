function addOrRemoveElements(input) {

    let output = [];
    for (let index = 1; index <= input.length; index++) {
        switch (input[index - 1]) {
            case 'add':
                output.push(index);
                break;
            case 'remove':
                output.pop();
                break;
        }
    }
    if (output.length > 0) {
        return output.join("\n");
    } else {
        return "Empty";
    }
}

console.log(addOrRemoveElements(['add',
    'add',
    'add',
    'add']
))

console.log(addOrRemoveElements(['remove',
    'remove',
    'remove']
))

console.log(addOrRemoveElements(['add',
    'add',
    'remove',
    'add',
    'add']
))