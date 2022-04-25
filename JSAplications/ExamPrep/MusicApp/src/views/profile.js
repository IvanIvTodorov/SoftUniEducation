import { html} from '../lib.js';
import { getUserData } from '../util.js';

const tamplate = (obj,userData) => html`
    <section id="user-profile-page" class="user-profile">
        <article class="user-info">
            <img id="user-avatar-url" alt="user-profile" src="/images/${userData.gender}.png">
            <div class="user-content">
                <p>Username: ${userData.username}</p>
                <p>Email: ${userData.email}</p>
                <p>My memes count: ${obj.length}</p>
            </div>
        </article>
        <h1 id="user-listings-title">User Memes</h1>
        <div class="user-meme-listings">
        ${obj.length == 0 ? html`<p class="no-memes">No memes in database.</p>` 
                : obj.map(elementTamplate)}
        </div>
    </section>
`;



const elementTamplate = (obj) => html`
    <div class="user-meme">
        <p class="user-meme-title">${obj.title}</p>
        <img class="userProfileImage" alt="meme-img" src=${obj.imageUrl}">
        <a class="button" href="/details${obj._id}">Details</a>
    </div>
`;

export async function profilePage(ctx){
    const userData = getUserData();
    const obj = await getYourOwn(userData.id);
    ctx.render(tamplate(obj, userData));
};