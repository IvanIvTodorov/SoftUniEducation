import { showAll } from '../api/data.js'

const section = document.getElementById('dashboard-holder');
section.remove();
section.addEventListener('click', onDetails);

let ctx = null;

export async function showCatalogPage(ctxTarget) {
    ctx = ctxTarget;
    ctx.showSection(section);
    show();
};

async function show() {
    const elements = await showAll();

    if (elements.length == 0) {
        section.innerHTML = '<h1>No ideas yet! Be the first one :)</h1>'
    } else {
        const fragment = document.createDocumentFragment();

        elements.map(createIt).forEach(i => fragment.appendChild(i));

        section.replaceChildren(fragment);
    };
};

function createIt(element) {
    const div = document.createElement('div');
    div.classList.add('card');
    div.classList.add('overflow-hidden');
    div.classList.add('current-card');
    div.classList.add('details');

    div.style.width = '20rem';
    div.style.height = '18rem';

    div.innerHTML =
        `<div class="card-body">
            <p class="card-text">${element.title}</p>
        </div>
        <img class="card-image" src="${element.img}" alt="Card image cap">
        <a data-id="${element._id}" class="btn" href="">Details</a>`;

    return div
};

function onDetails(ev) {
    if (ev.target.tagName == 'A') {
        const id = ev.target.dataset.id;
        ev.preventDefault();
        ctx.goTo('description', id);
    };
};
