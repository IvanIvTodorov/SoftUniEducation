import { getById, isLiked, likeIt, onDelete, totalLikes } from '../api/data.js';
import { html} from '../lib.js';
import { getUserData } from '../util.js';

const tamplate = (obj,flag, del, onLike,likes,nonCreator) => html`
     <section id="detailsPage">
            <div id="detailsBox">
                <div class="detailsInfo">
                    <h1>Title: ${obj.title}</h1>
                    <div>
                        <img src="${obj.imageUrl}" />
                    </div>
                </div>

                <div class="details">
                    <h3>Theater Description</h3>
                    <p>${obj.description}</p>
                    <h4>Date: ${obj.date}</h4>
                    <h4>Author: ${obj.author}</h4>
                    <div class="buttons">
                    ${flag ? html` 
                        <a @click=${del} class="btn-delete" href="#">Delete</a>
                        <a class="btn-edit" href="/edit${obj._id}">Edit</a>` : null
                    }

                    ${nonCreator ? html`
                            <a @click=${onLike} id="likeBtn" class="btn-like" href="#">Like</a>`
                            : null
                    }
                    </div>
                    <p class="likes">Likes: ${likes}</p>
                </div>
            </div>
        </section>
`;


export async function detailsPage(ctx){
    const obj = await getById(ctx.params.id);
    console.log(obj._id);
    const theaterId = obj._id;
    const userData = getUserData();
    const flag = userData && obj._ownerId == userData.id;
    const likes = await totalLikes(theaterId);
    const nonCreator = userData && obj._ownerId != userData.id;

    ctx.render(tamplate(obj,flag, del, onLike,likes,nonCreator));

    if (userData) {
        const liked = await isLiked(theaterId, userData.id);
        if (liked != 0) {
            document.getElementById('likeBtn').style.display = "none";
        };
    };

    async function onLike(ev){
        ev.preventDefault();
        await likeIt({theaterId})

        ctx.page.redirect(`/details${obj._id}`);
    };

    async function del(ev){
        ev.preventDefault();
        const choice = confirm('Do you want to delete this ?');

        if (choice) {
            await onDelete(ctx.params.id);
            ctx.page.redirect('/profile');
        };
    };
};