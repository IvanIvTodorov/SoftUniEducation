function deleteByEmail() {
    let table = document.querySelectorAll('tbody tr');
    let input = document.getElementsByName('email')[0];

    let flag = false;
    console.log(table);
    for (const row of table) {
        let rowValue = row.getElementsByTagName('td');

        if (rowValue[1].textContent == input.value) {
            row.remove();
            flag = true;
        }
    }

    if (flag) {
        document.getElementById('result').textContent = 'Deleted.';
    } else {
        document.getElementById('result').textContent = 'Not found.';
    }
}