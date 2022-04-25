import { showAll } from '../api/data.js';
import { html} from '../lib.js';

const tamplate = (obj) => html`
<section id="meme-feed">
            <h1>All Memes</h1>
            <div id="memes">
                ${obj.length == 0 ? html`<p class="no-memes">No memes in database.</p>` 
                : obj.map(elementTamplate)}
			</div>
        </section>
`;

const elementTamplate = (obj) => html`
    <div class="meme">
        <div class="card">
            <div class="info">
                <p class="meme-title">${obj.title}</p>
                <img class="meme-image" alt="meme-img" src=${obj.imageUrl}>
            </div>
            <div id="data-buttons">
                <a class="button" href="/details${obj._id}" >Details</a>
            </div>
        </div>
    </div>
`;

export async function catalogPage(ctx){
    const obj = await showAll();
    ctx.render(tamplate(obj));
};