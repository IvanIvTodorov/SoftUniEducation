import { getYourOwn } from '../api/data.js';
import { html} from '../lib.js';
import { getUserData } from '../util.js';

const tamplate = (obj) => html`
    <section id="my-books-page" class="my-books">
            <h1>My Books</h1>
            <ul class="my-books-list">         
            ${obj.length == 0 ? html`<p class="no-books">No books in database!</p>` 
            : obj.map(elementTamplate)}
            </ul>
        </section>
`;



const elementTamplate = (obj) => html`
    <li class="otherBooks">
        <h3>${obj.title}</h3>
        <p>Type: ${obj.type}</p>
        <p class="img"><img src="${obj.imageUrl}"></p>
        <a class="button" href="/details${obj._id}">Details</a>
    </li>
`;


export async function profilePage(ctx){
    const userData = getUserData();
    const obj = await getYourOwn(userData.id);
    ctx.render(tamplate(obj, userData));
};