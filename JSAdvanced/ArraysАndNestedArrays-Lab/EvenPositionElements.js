function evenPositionElements(elements){
    const resultArray = [];
    for (let index = 0; index < elements.length; index += 2) {
        
        resultArray.push(elements[index]);
    }

    console.log(resultArray.join(' '));
}

evenPositionElements(['20', '30', '40', '50', '60'])