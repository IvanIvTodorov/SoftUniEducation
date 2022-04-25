import { del, getByID } from "../api/data.js";

const section = document.getElementById('descriptionPage');
section.remove();

let ctx = null;

export async function showDescriptionPage(ctxTarget, id){
    ctx = ctxTarget;
    ctx.showSection(section);
    show(id);
};

async function show(id){
    
    const element = await getByID(id);

    section.replaceChildren(createIt(element))

};

function createIt(el){
    const fragment = document.createDocumentFragment();

    const img = document.createElement('img');
    img.classList.add('det-img');
    img.src = el.img;

    const div = document.createElement('div');
    div.classList.add('desc');

    div.innerHTML = `<h2 class="display-5">${el.title}</h2>
    <p class="infoType">Description:</p>
    <p class="idea-description">${el.description}</p>`

    const divDel = document.createElement('div');
    divDel.classList.add('text-center');
    divDel.innerHTML = `<a class="btn detb" href="">Delete</a>`;
    divDel.addEventListener('click', onDel);

    fragment.appendChild(img);
    fragment.appendChild(div);

    const id = sessionStorage.getItem('id');
    if (id &&  id == el._ownerId) {
        fragment.appendChild(divDel);
    };

    return fragment;

    async function onDel(ev){
        ev.preventDefault();
        const confirmed = confirm('Do you want to delete it ?');

        if (confirmed) {
            await del(el._id);
            ctx.goTo('catalog');
        } 
    };
};

