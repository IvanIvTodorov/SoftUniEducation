import { edit, getById } from '../api/data.js';
import { html} from '../lib.js';

const tamplate = (obj, onSubmit) => html`
    <section id="edit-meme">
        <form @submit=${onSubmit} id="edit-form">
            <h1>Edit Meme</h1>
            <div class="container">
                <label for="title">Title</label>
                <input id="title" type="text" placeholder="Enter Title" name="title" .value=${obj.title}>
                <label for="description">Description</label>
                <textarea id="description" placeholder="Enter Description" name="description" .value=${obj.description}></textarea>
                <label for="imageUrl">Image Url</label>
                <input id="imageUrl" type="text" placeholder="Enter Meme ImageUrl" name="imageUrl" .value=${obj.imageUrl}>
                <input type="submit" class="registerbtn button" value="Edit Meme">
            </div>
        </form>
    </section>
`;


export async function editPage(ctx){
    const obj = await getById(ctx.params.id);
    ctx.render(tamplate(obj, onSubmit));

    async function onSubmit(ev) {
        ev.preventDefault();

        const formData = new FormData(ev.target);

        const title = formData.get('title').trim();
        const description = formData.get('description').trim();
        const imageUrl = formData.get('imageUrl').trim();

        if (title == '' || description == '' || imageUrl == '') {
            return alert('All fields required!');
        };


        await edit(ctx.params.id ,{title, description, imageUrl});

        ctx.page.redirect('/catalog');
    }
};