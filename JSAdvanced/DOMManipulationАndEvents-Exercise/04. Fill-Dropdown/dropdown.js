function addItem() {

    let text = document.getElementById('newItemText');
    let inputVal = document.getElementById('newItemValue');
  
    let element = document.createElement('option');

    element.textContent = text.value;
    element.value = inputVal.value;

    document.getElementById('menu').appendChild(element);

    text.value = '';
    inputVal.value = '';
}