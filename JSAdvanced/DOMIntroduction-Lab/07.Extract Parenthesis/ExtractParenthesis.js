function extract(content) {

    let text = document.getElementById(content).textContent;

    let myReg = new RegExp(/\(([\w\s]+)\)/g);
    let temp = text.match(myReg);
    
    let result = [];

    while (temp != null) {
        result.push(temp[1]);
        temp = myReg.exec(text);
    }
    return result.join(";");
}