import { createComment, getById, getComments, onDelete } from '../api/data.js';
import { html } from '../lib.js';
import { getUserData } from '../util.js';

const tamplate = (obj, flag, del, nonCreator, comments, onComment,loggedNonCreator) => html`
    <section id="game-details">
        <h1>Game Details</h1>
        <div class="info-section">
    
            <div class="game-header">
                <img class="game-img" src="${obj.imageUrl}" />
                <h1>${obj.title}</h1>
                <span class="levels">MaxLevel: ${obj.maxLevel}</span>
                <p class="type">${obj.category}</p>
            </div>
    
            <p class="text">
                ${obj.summary}
            </p>
    
            ${nonCreator ? html`
            <div class="details-comments">
                <h2>Comments:</h2>
                <ul>
                    ${comments.length == 0 ? html`<p class="no-comment">No comments.</p>`
                        : comments.map(elementTamplate)}
                </ul>
            </div>
            ` : null}
    
    
            ${flag ? html`<div class="buttons">
                <a href="/edit${obj._id}" class="button">Edit</a>
                <a @click=${del} href="#" class="button">Delete</a>
            </div>` : null}
    
            ${loggedNonCreator ? html`
            <article class="create-comment">
                <label>Add new comment:</label>
                <form @submit=${onComment} class="form">
                    <textarea name="comment" placeholder="Comment......"></textarea>
                    <input class="btn submit" type="submit" value="Add Comment">
                </form>
            </article>
            ` : null}
    </section>
`;


const elementTamplate = (comments) => html`
    <li class="comment">
        <p>Content: ${comments.comment}.</p>
    </li>
`


export async function detailsPage(ctx) {
    const obj = await getById(ctx.params.id);
    const comments = await getComments(obj._id);

    const userData = getUserData();
    const flag = userData && obj._ownerId == userData.id;
    let nonCreator = true;
    if (userData) {
        nonCreator = obj.ownerId != userData.id;
    };

    const loggedNonCreator = userData && obj._ownerId != userData.id;

    ctx.render(tamplate(obj, flag, del, nonCreator, comments, onComment,loggedNonCreator));

    async function onComment(ev) {
        ev.preventDefault();

        const formaData = new FormData(ev.target);

        const comment = formaData.get('comment');
        const gameId = obj._id;    
        await createComment({gameId, comment});

        ev.target.reset();
        ctx.page.redirect(`/details${obj._id}`);
    };

    async function del() {
        const choice = confirm('Do you want to delete this ?');

        if (choice) {
            await onDelete(ctx.params.id);
            ctx.page.redirect('/catalog');
        };
    };
};