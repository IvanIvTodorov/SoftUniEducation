function addItem() {
    let elementValue = document.getElementById('newItemText');
    let elements = document.getElementById('items');

    let newElement = document.createElement('li');
    newElement.textContent = elementValue.value;

    const button = document.createElement('a');
    button.textContent = "[Delete]";
    button.href = "#";
    button.addEventListener('click', removeElement);


    function removeElement(ev) {

        let parent = ev.target.parentNode;
        parent.remove();

    }

    newElement.appendChild(button);

    elements.appendChild(newElement);

    elementValue.value = "";
}