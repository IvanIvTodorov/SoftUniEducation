window.addEventListener('load', generateAll);
const url = `http://localhost:3030/jsonstore/collections/books/`;
let tbody = document.getElementsByTagName('tbody')[0];
let data;
let id = '';
let label = document.getElementsByTagName('h3')[0];
let form = document.querySelector('form');

function generateAll(ev) {
    ev.preventDefault();
    tbody.innerHTML = '';
    const generateBtn = document.getElementById('loadBooks');

    generateBtn.addEventListener('click', generate);

    async function generate() {
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

            data = await res.json();

            for (const item of Object.keys(data)) {
                let tr = document.createElement('tr');

                let tdTitle = document.createElement('td');
                tdTitle.textContent = data[item].title;

                let tdName = document.createElement('td');
                tdName.textContent = data[item].author;

                let tdBtns = document.createElement('td');
                let editBtn = document.createElement('button');
                editBtn.textContent = 'Edit';
                editBtn.addEventListener('click', editOrDelete);

                let delBtn = document.createElement('button');
                delBtn.textContent = 'Delete';
                delBtn.addEventListener('click', editOrDelete);

                tr.appendChild(tdTitle);
                tr.appendChild(tdName);
                tdBtns.appendChild(editBtn);
                tdBtns.appendChild(delBtn);
                tr.appendChild(tdBtns);

                tbody.appendChild(tr);
            }
        } catch (error) {
            alert(error.message);
        }

        form.addEventListener('submit', submit);
    };


    async function editOrDelete(ev) {
        let title = document.querySelector('input[name=title');
        let name = document.querySelector('input[name=author');
        let titleVal = ev.target.parentNode.parentNode.children[0].textContent;
        let nameVal = ev.target.parentNode.parentNode.children[1].textContent;

        for (const item of Object.keys(data)) {
            if (data[item].title == titleVal) {
                id = item;
                break;
            }
        };
        if (ev.target.textContent == 'Edit') {
            title.value = titleVal;
            name.value = nameVal;

            form.getElementsByTagName('button')[0].textContent = 'EDIT';
            label.textContent = 'Edit FORM';

        } else {
            let res = await fetch(url + id, {
                method: 'delete',
                headers: {
                    'Content-Type': 'application/js'
                }
            });
            ev.target.parentNode.parentNode.remove();
        };

    };
    async function submit(ev) {
        ev.preventDefault();
        let formData = new FormData(ev.target);
        console.log(ev.target.lastElementChild);
        let name = formData.get('author');
        let title = formData.get('title');

        if (ev.target.lastElementChild.textContent == 'Submit') {
            try {
                let res = await fetch(url, {
                    method: 'post',
                    headers: {
                        'Content-Type': 'application/js'
                    },
                    body: JSON.stringify({
                        author: name,
                        title: title
                    })
                });

                if (!res.ok) {
                    const er = await res.json();
                    throw new Error(er.message);
                };
            } catch (error) {
                alert(er.message);
            };
        } else {
            try {
                let res = await fetch(url + id, {
                    method: 'put',
                    headers: {
                        'Content-Type': 'application/js'
                    },
                    body: JSON.stringify({
                        author: name,
                        title: title
                    })
                });

                if (!res.ok) {
                    const er = await res.json();
                    throw new Error(er.message);
                };

            } catch (error) {
                alert(error.message);
            }
        };

        ev.target.reset();
        label.textContent = 'SUBMIT';
        form.getElementsByTagName('button')[0].textContent = 'Submit';
        generate();
    };
};


