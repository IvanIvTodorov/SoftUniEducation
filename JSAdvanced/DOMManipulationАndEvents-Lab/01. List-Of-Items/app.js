function addItem() {
    let elementValue = document.getElementById('newItemText').value;
    let elements = document.getElementById('items');
    let newElement = document.createElement('li');

    newElement.textContent = elementValue;
    elements.appendChild(newElement);
}