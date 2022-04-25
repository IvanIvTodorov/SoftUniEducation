let user = document.getElementById('user');
let guest = document.getElementById('guest');
let span = document.getElementsByTagName('span')[0];
let logout = document.getElementById('logout');
let catches = document.getElementById('catches');
let loadBtn = document.querySelector('.load');
let addBtn = document.querySelector('.add');
let addForm = document.getElementById('addForm');


window.addEventListener('DOMContentLoaded', () => {
    logout.addEventListener('click', onLogout);
    loadBtn.addEventListener('click', generate);
    catches.style.display = 'none';
    let token = localStorage.getItem('token');
    if (token) {
        user.style.display = 'inline-block';
        guest.style.display = 'none';
        span.textContent = localStorage.getItem('username');
        addBtn.disabled = false;

    } else {
        guest.style.display = 'inline-block';
        user.style.display = 'none';
    };

    addForm.addEventListener('submit', onSubmit);
});

async function generate() {

    try {
        const res = await fetch(`http://localhost:3030/data/catches`, {
            method: 'get',
            headers: {
                'Content-Type': 'application/js'
            }
        });


        if (!res.ok) {
            let er = await res.json();
            throw new Error(er.message);
        };

        const data = await res.json();
        let id = localStorage.getItem('id');
        catches.innerHTML = '';
        let text = '';

        for (const item of Object.keys(data)) {
            if (id == data[item]._ownerId) {
                text +=
                    `<div class="catch">
            <label>Angler</label>
            <input type="text" class="angler" value="${data[item].angler}">
            <label>Weight</label>
            <input type="text" class="weight" value="${data[item].weight}">
            <label>Species</label>
            <input type="text" class="species" value="${data[item].species}">
            <label>Location</label>
            <input type="text" class="location" value="${data[item].location}">
            <label>Bait</label>
            <input type="text" class="bait" value="${data[item].bait}">
            <label>Capture Time</label>
            <input type="number" class="captureTime" value="${data[item].captureTime}">
            <button class="update" data-id="${data[item]._id}">Update</button>
            <button class="delete" data-id="${data[item]._id}">Delete</button>
            </div>`

            } else {
                text +=
                    `<div class="catch">
            <label>Angler</label>
            <input type="text" class="angler" value="${data[item].angler}" disabled>
            <label>Weight</label>
            <input type="text" class="weight" value="${data[item].weight}" disabled>
            <label>Species</label>
            <input type="text" class="species" value="${data[item].species}" disabled>
            <label>Location</label>
            <input type="text" class="location" value="${data[item].location}" disabled>
            <label>Bait</label>
            <input type="text" class="bait" value="${data[item].bait}" disabled>
            <label>Capture Time</label>
            <input type="number" class="captureTime" value="${data[item].captureTime}" disabled>
            <button class="update" data-id="${data[item]._id}" disabled>Update</button>
            <button class="delete" data-id="${data[item]._id}"disabled>Delete</button>
            </div>`
            };
        }

        catches.innerHTML = text;
        catches.style.display = 'block';

        let delBtn = document.getElementsByClassName('delete');
        for (const btn of delBtn) {
            btn.addEventListener('click', deleteIt);
        };

        let upBtn = document.getElementsByClassName('update');
        for (const btn of upBtn) {
            btn.addEventListener('click', updateIt);
        }
    } catch (error) {
        alert(error.message);
    }
};

async function deleteIt(ev) {
    ev.preventDefault();
    let token = localStorage.getItem('token');
    try {
        const res = await fetch(`http://localhost:3030/data/catches/${ev.target.getAttribute('data-id')}`, {
            method: 'delete',
            headers: {
                'Content-Type': `application/js`,
                "X-Authorization": token
            }
        });

        if (!res.ok) {
            const er = await res.json();
            throw new Error(er.message);
        };

    } catch (error) {
        alert(error.message);
    }

    ev.target.parentNode.remove();
};

async function updateIt(ev) {
    ev.preventDefault();
    let token = localStorage.getItem('token');
    let field = ev.target.parentNode;

    const angler = field.children[1].value;
    const weight = field.children[3].value;
    const species = field.children[5].value;
    const location = field.children[7].value;
    const bait = field.children[9].value;
    const captureTime = field.children[11].value;

    console.log(token)

    try {
        if (!angler || !weight || !species || !location || !bait || !captureTime) {
            throw new Error('You have empty field !');
        };
        const res = await fetch(`http://localhost:3030/data/catches/${ev.target.getAttribute('data-id')}`, {
            method: 'put',
            headers: {
                'Content-Type': `application/js`,
                "X-Authorization": token
            },
            body: JSON.stringify({
                angler,
                weight,
                species,
                location,
                bait,
                captureTime
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
async function onSubmit(ev) {
    ev.preventDefault();
    let formData = new FormData(ev.target);
    let token = localStorage.getItem('token');
    const angler = formData.get("angler");
    const weight = formData.get("weight");
    const species = formData.get("species");
    const location = formData.get("location");
    const bait = formData.get("bait");
    const captureTime = formData.get("captureTime");

    try {
        if (!angler || !weight || !species || !location || !bait || !captureTime) {
            throw new Error('You have empty field !');
        };
        const res = await fetch(`http://localhost:3030/data/catches`, {
            method: 'post',
            headers: {
                'Content-Type': 'application/js',
                'X-Authorization': token
            },
            body: JSON.stringify({
                angler,
                weight,
                species,
                location,
                bait,
                captureTime
            })
        });

        if (!res.ok) {
            const er = await res.json();
            throw new Error(er.message);
        };

        ev.target.reset();
        generate();
    } catch (error) {
        alert(error.message);
    }
};

function onLogout(ev) {
    ev.preventDefault();
    localStorage.clear();
    window.location = '/index.html'
};
