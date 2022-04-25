window.addEventListener('load', function solve() {

    if (window.location.pathname == '/home.html') {
        let token = this.localStorage.getItem('token');
        let redirect = this.document.getElementById('guest').children[0];
        if (token) {
            redirect.textContent = "List";
            redirect.href = "homeLogged.html";
        }
    } else {
        let tBody = this.document.getElementsByTagName('tbody')[0];
        tBody.innerHTML = '';
        let form = document.getElementsByTagName('form')[0];
        form.addEventListener('submit', createElement);

        let logOutBtn = this.document.getElementById('logoutBtn');
        logOutBtn.addEventListener('click', logOut);
        let cataloug = this.document.getElementsByTagName('a')[0];
        cataloug.addEventListener('click', redirect);
        let spanItems = document.getElementsByTagName('span')[0];
        let spanPrice = document.getElementsByTagName('span')[1];
        spanItems.textContent = '';
        spanPrice.textContent = '';
    }

    loadAll()

    let buyBtn = this.document.getElementsByTagName('button')[1];
    let finishBtn = this.document.getElementsByTagName('button')[2];

    buyBtn.addEventListener('click', buyAll);
    finishBtn.addEventListener('click', finish);
});

var price = 0;
var items = [];

function buyAll() {
    let checkBoxes = document.querySelectorAll('input[type="checkbox"]');

    for (const box of Array.from(checkBoxes)) {

        if (box.checked) {
            let row = box.parentNode.parentNode;
            price += Number(row.children[2].textContent);
            items.push(row.children[1].textContent);
            box.checked = false;
        }
    };
};

function finish() {
    let spanItems = document.getElementsByTagName('span')[0];
    let spanPrice = document.getElementsByTagName('span')[1];

    spanItems.textContent = items.join(',');
    spanPrice.textContent = `${[price]} $`
};

function redirect() {
    window.location = `/home.html`;
}

async function loadAll() {
    const url = `http://localhost:3030/data/furniture`;
    let tBody = this.document.getElementsByTagName('tbody')[0];
    try {
        const res = await fetch(url, {
            method: 'get',
            headers: {
                'Content-Type': "applicaton/js"
            }
        });

        if (!res.ok) {
            const er = res.json();
            throw new Error(er.message);
        };

        const data = await res.json();
        let text = '';
        for (const key of Object.keys(data)) {
            text += `<tr>
            <td>
                <img
                    src="${data[key].img}">
            </td>
            <td>
                <p>${data[key].name}</p>
            </td>
            <td>
                <p>${data[key].price}</p>
            </td>
            <td>
                <p>${data[key].factor}</p>
            </td>
            <td>
                <input type="checkbox"/>
            </td>
        </tr>`
        };

        tBody.innerHTML = text;

        if (window.location.pathname == '/home.html'){
            let checkBoxes = document.querySelectorAll('input[type="checkbox"]');

            for (const box of checkBoxes) {
                box.disabled = true;
            }
        }
    } catch (error) {
        alert(error.message);
    }
}

async function logOut() {
    localStorage.clear();

    window.location = `/home.html`;
};

async function createElement(ev) {
    ev.preventDefault();
    const url = `http://localhost:3030/data/furniture`;
    const token = localStorage.getItem('token');
    let formData = new FormData(ev.target);

    const name = formData.get('name');
    const price = formData.get('price');
    const factor = formData.get('factor');
    const img = formData.get('img');

    try {
        if (!Number(price) || !Number(factor)) {
            throw new Error('Price and factor should be numbers!');
        }
        const res = await fetch(url, {
            method: 'post',
            headers: {
                "Content-Type": "application/js",
                'X-Authorization': token
            },
            body: JSON.stringify({
                name,
                price,
                factor,
                img
            })
        });

        if (!res.ok) {
            const er = await res.json();
            throw new Error(er.message);
        };

        ev.target.reset();

        loadAll();
    } catch (error) {
        alert(error.message);
    }
};