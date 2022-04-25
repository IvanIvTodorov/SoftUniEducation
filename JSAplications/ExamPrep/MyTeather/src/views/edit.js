import { edit, getById } from '../api/data.js';
import { html } from '../lib.js';

const tamplate = (obj, onSubmit) => html`
<section id="editPage">
    <form @submit=${onSubmit}class="theater-form">
        <h1>Edit Theater</h1>
        <div>
            <label for="title">Title:</label>
            <input id="title" name="title" type="text" placeholder="Theater name" value="${obj.title}">
        </div>
        <div>
            <label for="date">Date:</label>
            <input id="date" name="date" type="text" placeholder="Month Day, Year" value="${obj.date}">
        </div>
        <div>
            <label for="author">Author:</label>
            <input id="author" name="author" type="text" placeholder="Author" value="${obj.author}">
        </div>
        <div>
            <label for="description">Theater Description:</label>
            <textarea id="description" name="description" placeholder="Description">${obj.description}</textarea>
        </div>
        <div>
            <label for="imageUrl">Image url:</label>
            <input id="imageUrl" name="imageUrl" type="text" placeholder="Image Url" value="${obj.imageUrl}">
        </div>
        <button class="btn" type="submit">Submit</button>
    </form>
</section>
`;


export async function editPage(ctx) {
    const obj = await getById(ctx.params.id);
    ctx.render(tamplate(obj, onSubmit));

    async function onSubmit(ev) {
        ev.preventDefault();

        const formData = new FormData(ev.target);

        const title = formData.get('title').trim();
        const date = formData.get('date').trim();
        const author = formData.get('author').trim();
        const imageUrl = formData.get('imageUrl').trim();
        const description = formData.get('description').trim();

        if (title == '' || description == '' || imageUrl == '' || date == '' || author == '') {
            return alert('All fields required!');
        };


        await edit(ctx.params.id, { title, date, author, imageUrl, description });

        ctx.page.redirect(`/details${obj._id}`);
    }
};