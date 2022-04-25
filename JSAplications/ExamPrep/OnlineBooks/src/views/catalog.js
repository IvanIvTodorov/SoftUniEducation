import { showAll } from '../api/data.js';
import { html} from '../lib.js';

const tamplate = (obj) => html`
<section id="dashboard-page" class="dashboard">
    <h1>Dashboard</h1>
    <ul class="other-books-list">
        ${obj.length == 0 ? html`<p class="no-books">No books in database!</p>` 
                        : obj.map(elementTamplate)}
    </ul>
</section>
`;

const elementTamplate = (obj) => html`
    <li class="otherBooks">
        <h3>${obj.title}</h3>
        <p>${obj.type}</p>
        <p class="img"><img src="${obj.imageUrl}"></p>
        <a class="button" href="/details${obj._id}">Details</a>
    </li>
`;

export async function catalogPage(ctx){
    const obj = await showAll();
    ctx.render(tamplate(obj));
};