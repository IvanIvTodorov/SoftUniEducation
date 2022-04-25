import { getYourOwn } from '../api/data.js';
import { html} from '../lib.js';
import { getUserData } from '../util.js';

const tamplate = (obj,userData) => html`
     <section id="profilePage">
            <div class="userInfo">
                <div class="avatar">
                    <img src="./images/profilePic.png">
                </div>
                <h2>${userData.email}</h2>
            </div>
          
            <div class="board">
            ${obj.length == 0 ? html` 
                <div class="no-events">
                    <p>This user has no events yet!</p>
                </div>`
             : 
                obj.map(elementTamplate)
             }          
            </div>
        </section>
`;



const elementTamplate = (obj) => html`
    <div class="eventBoard">
        <div class="event-info">
            <img src="${obj.imageUrl}">
            <h2>${obj.title}</h2>
            <h6>${obj.date}</h6>
            <a href="/details${obj._id}" class="details-button">Details</a>
        </div>
    </div>
`;

export async function profilePage(ctx){
    const userData = getUserData();
    const obj = await getYourOwn(userData.id);
    ctx.render(tamplate(obj, userData));
};