import { getById, onDelete } from '../api/data.js';
import { html} from '../lib.js';
import { getUserData } from '../util.js';

const tamplate = (obj,flag, del) => html`
    <section id="meme-details">
        <h1>Meme Title: ${obj.title}</h1>
        <div class="meme-details">
            <div class="meme-img">
                <img alt="meme-alt" src="${obj.imageUrl}">
            </div>
            <div class="meme-description">
                <h2>Meme Description</h2>
                <p>
                   ${obj.description}
                </p>
                
                ${flag ? html`<a class="button warning" href="/edit${obj._id}">Edit</a>
                <button @click=${del} class="button danger">Delete</button>`
                : null}
            </div>
        </div>
    </section>
`;


export async function detailsPage(ctx){
    const obj = await getById(ctx.params.id);

    const userData = getUserData();
    const flag = userData && obj._ownerId == userData.id;

    ctx.render(tamplate(obj,flag, del));

    async function del(ev){
        ev.preventDefault();
        const choice = confirm('Do you want to delete this ?');

        if (choice) {
            await onDelete(ctx.params.id);
            ctx.page.redirect('/catalog');
        };
    };
};