function editElement(document,match,replacer) {

    let regEx = new RegExp(match, 'g')
    let text = document.textContent;
    return document.textContent = text.replace(regEx, replacer);
}