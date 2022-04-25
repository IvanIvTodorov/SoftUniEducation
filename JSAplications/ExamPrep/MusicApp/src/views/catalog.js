import { showAll } from '../api/data.js';
import { html} from '../lib.js';
import { getUserData } from '../util.js';

const tamplate = (obj , userData) => html`
<section id="catalogPage">
            <h1>All Albums</h1>

            ${obj.length == 0 ? html`<p>No Albums in Catalog!</p>`
              :  obj.map(elementTamplate)}
            }

</section>
`;

const elementTamplate = (obj) => html`
    <div class="card-box">
        <img src=${obj.imgUrl}>
        <div>
            <div class="text-center">
                <p class="name">Name: ${obj.name}</p>
                <p class="artist">Artist: ${obj.artist}</p>
                <p class="genre">Genre: ${obj.genre}</p>
                <p class="price">Price: ${obj.price}</p>
                <p class="date">Release Date: ${obj.releaseDate}</p>
            </div>
            <div class="btn-group">
                <a href="/details${obj._id}" id="details">Details</a>
            </div>
        </div>
    </div>
`;


export async function catalogPage(ctx){
    const obj = await showAll();

    const userData = getUserData();

    ctx.render(tamplate(obj, userData));

    if (!userData) {
        for (const el of document.getElementsByClassName('btn-group')) {
            el.style.display = 'none';
        };
    }
};