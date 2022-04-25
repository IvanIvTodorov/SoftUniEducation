import { edit, getById } from '../api/data.js';
import { html } from '../lib.js';

const tamplate = (obj, onSubmit) => html`
    <section id="edit-page" class="auth">
        <form @submit=${onSubmit} id="edit">
            <div class="container">
    
                <h1>Edit Game</h1>
                <label for="leg-title">Legendary title:</label>
                <input type="text" id="title" name="title" value="${obj.title}">
    
                <label for="category">Category:</label>
                <input type="text" id="category" name="category" value="${obj.category}">
    
                <label for="levels">MaxLevel:</label>
                <input type="number" id="maxLevel" name="maxLevel" min="1" value="${obj.maxLevel}">
    
                <label for="game-img">Image:</label>
                <input type="text" id="imageUrl" name="imageUrl" value="${obj.imageUrl}">
    
                <label for="summary">Summary:</label>
                <textarea name="summary" id="summary">${obj.summary}</textarea>
                <input class="btn submit" type="submit" value="Edit Game">
    
            </div>
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
        const category = formData.get('category').trim();
        const maxLevel = formData.get('maxLevel').trim();
        const imageUrl = formData.get('imageUrl').trim();
        const summary = formData.get('summary').trim();

        if (title == '' || summary == '' || imageUrl == '' || maxLevel == '' || category == '') {
            return alert('All fields required!');
        };


        await edit(ctx.params.id, { title, category, maxLevel, imageUrl, summary });

        ctx.page.redirect('/catalog');
    }
};