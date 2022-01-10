function allWordsToUpper(word) {
    
    let spliters = /[^\w]+/
    let words = word.split(spliters).filter(r => r);

    console.log(words.join(", ").toUpperCase())

}

allWordsToUpper("Hi, how are you?")