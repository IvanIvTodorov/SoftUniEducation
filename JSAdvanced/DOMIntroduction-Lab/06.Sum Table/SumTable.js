function sumTable() {
    let extracted = document.querySelectorAll('tbody tr');

    let sum = 0;

    for (let index = 1; index < extracted.length; index++) {
        
        sum += Number(extracted[index].lastElementChild.textContent);

        if (index == extracted.length  - 1) {
            extracted[index].lastElementChild.textContent = sum;
        }
    }
}