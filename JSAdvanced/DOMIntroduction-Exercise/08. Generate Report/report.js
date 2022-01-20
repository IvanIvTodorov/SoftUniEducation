function generateReport() {
    let checkboxes = document.getElementsByTagName('input');
    let arr = [];
    for (let index = 0; index < checkboxes.length; index++) {
        if (checkboxes[index].checked) {
            arr.push({ [index]: checkboxes[index].name })
        }
    }
    console.log(arr);

    let rows = document.getElementsByTagName('tr');
    let output = [];
    let counter = 0;

    for (const row of rows) {
        if (counter != 0) {
            let temp = {};
            for (let index = 0; index < row.cells.length; index++) {
                
                for (const obj of arr) {
                    let [key, value] = Object.entries(obj);

                    if (key[0] == index) {
                       temp[key[1]] = row.cells[index].textContent
                    }
                }
                
            }
            output.push(temp);
        }

        counter++;
    }

    document.getElementById('output').textContent = JSON.stringify(output);
}
