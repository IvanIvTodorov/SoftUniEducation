import { getById, getLikes, isLiked, likeIt, onDelete } from '../api/data.js';
import { html} from '../lib.js';
import { getUserData } from '../util.js';

const tamplate = (obj,flag, del, nonCreator, onClick, likes) => html`
    <section id="details-page" class="details">
<div class="book-information">
    <h3>${obj.title}</h3>
    <p class="type">Type: ${obj.type}</p>
    <p class="img"><img src="${obj.imageUrl}"></p>
    <div class="actions">
    ${nonCreator ? html`<a @click=${onClick} id="likeBtn" class="button" href="/details${obj._id}">Like</a>` : html`<a id="likeBtn" class="button" href="/details${obj._id}" style="display:none">Like</a>`}
    ${flag ? html`<a class="button" href="/edit${obj._id}">Edit</a>
    <button @click=${del} class="button" href="/catalog">Delete</button>
        <div class="likes">
        <img class="hearts" src="/images/heart.png">
        <span id="total-likes">Likes: ${likes}</span>
        </div>`
        : html` <div class="likes">
        <img class="hearts" src="/images/heart.png">
        <span id="total-likes">Likes: ${likes}</span>
        </div>`
    }
    </div>
</div>
<div class="book-description">
    <h3>Description:</h3>
    <p>
        ${obj.description}
    </p>
</div>
</section>
`;


export async function detailsPage(ctx){
    const obj = await getById(ctx.params.id);

    const bookId = obj._id;
    const userData = getUserData();
    const flag = userData && obj._ownerId == userData.id;
    const nonCreator = userData && obj._ownerId != userData.id;
    const likes = await likeIt(bookId);
    let liked = null;
    

    ctx.render(tamplate(obj,flag, del, nonCreator, onClick, likes));

    if (userData) {
        liked = await isLiked(bookId, userData.id);
        if (liked != 0) {
            document.getElementById('likeBtn').style.display = "none";
            console.log(temp);
        };
    };
    
    async function del(){
        const choice = confirm('Do you want to delete this ?');

        if (choice) {
            await onDelete(ctx.params.id);
            ctx.page.redirect('/catalog');
        };
    };

    async function onClick(){
        const likes = await getLikes(bookId);
        await likeIt({bookId});

        ctx.page.redirect('/details');
    };
};