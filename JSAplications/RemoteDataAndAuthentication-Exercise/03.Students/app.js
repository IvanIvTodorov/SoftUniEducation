window.addEventListener('load', load);
const url = `http://localhost:3030/jsonstore/collections/students`;
let tbody = document.getElementsByTagName('tbody')[0];
let form = document.querySelector('form');
form.addEventListener('submit', onSubmit);

async function load() {
    tbody.innerHTML = '';
    try {
        const res = await fetch(url, {
            method: 'get',
            headers: {
                'Content-Type': 'applicaton/js'
            }
        });

        if (!res.ok) {
            const er = await res.json();
            throw new Error(er.message);
        };

        const data = await res.json();

        for (const item of Object.keys(data)) {
            let tr = document.createElement('tr');

            let thFirst = document.createElement('th');
            thFirst.textContent = data[item].firstName;

            let thLast = document.createElement('th');
            thLast.textContent = data[item].lastName;

            let thNum = document.createElement('th');
            thNum.textContent = data[item].facultyNumber;

            let thGrade = document.createElement('th');
            thGrade.textContent = data[item].grade;

            tr.appendChild(thFirst);
            tr.appendChild(thLast);
            tr.appendChild(thNum);
            tr.appendChild(thGrade);

            tbody.appendChild(tr);
        }
    } catch (error) {
        alert(error.message);
    }
};

async function onSubmit(ev) {
    ev.preventDefault();

    const formData = new FormData(ev.target);

    let firstName = formData.get('firstName').trim();
    let lastName = formData.get('lastName').trim();
    let facultyNumber = formData.get('facultyNumber').trim();
    let grade = formData.get('grade').trim();

    if (!firstName || !lastName || !facultyNumber || !grade) {
        throw new Error('You have empty row!')
    };

    if (isNaN(facultyNumber) || isNaN(grade)) {
        throw new Error('Number and grade should be numbers!')
    };

    try {
        let obj = {
            firstName,
            lastName,
            facultyNumber,
            grade
        };

        let res = await fetch(url, {
            method: 'post',
            headers: {
                'Content-Type': 'application/js'
            },
            body: JSON.stringify(obj)
        });

        if (!res.ok) {
            const er = await res.json();
            throw new Error(er.message);
        };

        form.reset();
        load();
    } catch (error) {
        alert(error.message);
    }

};