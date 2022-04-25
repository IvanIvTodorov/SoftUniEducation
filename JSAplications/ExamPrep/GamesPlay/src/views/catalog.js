import { showAll } from '../api/data.js';
import { html} from '../lib.js';

const tamplate = (obj) => html`
    <section id="catalog-page">
                <h1>All Games</h1>
                ${obj.length == 0 ? html`<h3 class="no-articles">No articles yet</h3>` 
                : obj.map(elementTamplate)}
    </section>
`;


const elementTamplate = (obj) => html`
   <div class="allGames">
                <div class="allGames-info">
                    <img src="${obj.imageUrl}">
                    <h6>${obj.category}</h6>
                    <h2>${obj.title}</h2>
                    <a href="/details${obj._id}" class="details-button">Details</a>
                </div>
            </div>
`;

export async function catalogPage(ctx){
    const obj = await showAll();
    ctx.render(tamplate(obj));
};