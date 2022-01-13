function sortArray(input){

    input.sort((a,b) => a.localeCompare(b));
    for (let index = 1; index <= input.length; index++) {
        console.log(`${index}.${input[index -1 ]}`);
    }
}

sortArray(["John", "Bob", "Christina", "Ema"]);