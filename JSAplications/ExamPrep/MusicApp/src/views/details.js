import { getById, onDelete } from '../api/data.js';
import { html} from '../lib.js';
import { getUserData } from '../util.js';

const tamplate = (obj,flag, del) => html`
    <section id="detailsPage">
            <div class="wrapper">
                <div class="albumCover">
                    <img src="${obj.imgUrl}">
                </div>
                <div class="albumInfo">
                    <div class="albumText">

                        <h1>Name: ${obj.name}</h1>
                        <h3>Artist: ${obj.artist}</h3>
                        <h4>Genre: ${obj.genre}</h4>
                        <h4>Price: ${obj.price}</h4>
                        <h4>Date: ${obj.releaseDate}</h4>
                        <p>Description: ${obj.description}</p>
                    </div>
                    
                    ${flag ? html` <div class="actionBtn">
                        <a href="/edit${obj._id}" class="edit">Edit</a>
                        <a @click=${del} href="" class="remove">Delete</a>
                    </div>` : null}                 
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