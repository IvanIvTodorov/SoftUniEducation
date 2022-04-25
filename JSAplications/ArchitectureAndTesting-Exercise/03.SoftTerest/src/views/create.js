import { create } from "../api/data.js";

const section = document.getElementById('createPage');
section.remove();

let ctx = null;

const form = section.querySelector('form');
form.addEventListener('submit', onSubmit);

export async function showCreatePage(ctxTarget){
    ctx = ctxTarget;
    ctx.showSection(section);
};

async function onSubmit(ev){
    ev.preventDefault();

    const formData = new FormData(form);

    const title = formData.get('title').trim();
    const description = formData.get('description').trim();
    const img = formData.get('imageURL').trim();

    if (title.length < 6 ) {
        return alert('Title must be at least 6 symbols');
    };

    if (description.length < 10 ) {
        return alert('Description must be at least 6 symbols');
    };

    if (img.length < 6 ) {
        return alert('Image must be at least 6 symbols');
    };

    create({title, description, img})
    form.reset();
    ctx.goTo('catalog');
};