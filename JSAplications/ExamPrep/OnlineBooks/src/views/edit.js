import { edit, getById } from '../api/data.js';
import { html} from '../lib.js';

const tamplate = (obj, onSubmit) => html`
   <section id="edit-page" class="edit">
            <form @submit=${onSubmit} id="edit-form" action="#" method="">
                <fieldset>
                    <legend>Edit my Book</legend>
                    <p class="field">
                        <label for="title">Title</label>
                        <span class="input">
                            <input type="text" name="title" id="title" value="${obj.title}">
                        </span>
                    </p>
                    <p class="field">
                        <label for="description">Description</label>
                        <span class="input">
                            <textarea name="description"
                                id="description">${obj.description}</textarea>
                        </span>
                    </p>
                    <p class="field">
                        <label for="image">Image</label>
                        <span class="input">
                            <input type="text" name="imageUrl" id="image" value="${obj.imageUrl}">
                        </span>
                    </p>
                    <p class="field">
                        <label for="type">Type</label>
                        <span class="input">
                            <select id="type" name="type" value=${obj.type}>
                                <option value="Fiction">Fiction</option>
                                <option value="Romance">Romance</option>
                                <option value="Mistery">Mistery</option>
                                <option value="Classic">Clasic</option>
                                <option value="Other">Other</option>
                            </select>
                        </span>
                    </p>
                    <input class="button submit" type="submit" value="Save">
                </fieldset>
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
        const type = formData.get('type').trim();

        if (title == '' || description == '' || imageUrl == '' || type == '') {
            return alert('All fields required!');
        };


        await edit(ctx.params.id ,{title, description, imageUrl, type});

        ctx.page.redirect('/catalog');
    }
};