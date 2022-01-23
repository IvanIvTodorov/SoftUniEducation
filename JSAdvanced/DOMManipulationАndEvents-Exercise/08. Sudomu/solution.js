function solve() {
    
    let tr = document.getElementsByTagName('tr');
    let rows = Array.from(tr).splice(2, 3);
    
    let border = document.getElementsByTagName('table')[0];
    let result = document.getElementById('check').firstElementChild;

    let buttons = document.getElementsByTagName('button');
    let clearBtn = buttons[1];
    let checkBtn = buttons[0];

    clearBtn.addEventListener('click', clearTable);

    function clearTable(){
        for (let index = 0; index < rows.length; index++) {
            let row  = rows[index];
            for (let cell = 0; cell < row.cells.length; cell++) {
                row.cells[cell].firstElementChild.value = '';
            }
        }

        border.style.border = 'none';
        result.textContent = '';
    }

    checkBtn.addEventListener('click', checkTable);

    function checkTable(){
        let flag = true;

        for (let index = 0; index < rows.length; index++) {
            let row  = rows[index];
            let compare = row.cells[0].firstElementChild.value;
            if(compare > 3){
                flag = false;
                break;
            }
            for (let cell = 1; cell < row.cells.length; cell++) {
                let element = row.cells[cell].firstElementChild.value

                if (compare == element || element > 3) {
                    flag = false
                    break;
                }
            }
            if (!flag) {
                break;
            }
        }
        if (flag) {
            for (let col = 0; col < rows.length; col++) {
                let compare = rows[0].cells[col].firstElementChild.value;
                if(compare > 3){
                    flag = false;
                    break;
                }
               for (let row = 1; row < rows.length; row++) {
                   let element = rows[row].cells[col].firstElementChild.value;
                   
                   if (compare == element || element > 3) {
                       flag = false;
                       break;
                   }
               }
                if (!flag) {
                    break;
                }
            }
        }

        if (flag) {
            border.style.border = '2px solid green';
            result.style.color = 'green';
            result.textContent = 'You solve it! Congratulations!';
        }else{
            border.style.border = '2px solid red';
            result.style.color = 'red';
            result.textContent = 'NOP! You are not done yet...';
        }
    }
}