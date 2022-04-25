import { showAll } from '../api/data.js';
import { html} from '../lib.js';

const tamplate = (obj) => html`
  <section id="dashboard">
            <h2 class="dashboard-title">Services for every animal</h2>
            <div class="animals-dashboard">
        
                ${obj.length == 0 ? html`<p class="no-pets">No pets in dashboard</p>` 
                    : obj.map(elementTamplate)
                }
                
            </div>
        </section>
`;

const elementTamplate = (obj) => html`
    <div class="animals-board">
                    <article class="service-img">
                        <img class="animal-image-cover" src="${obj.image}">
                    </article>
                    <h2 class="name">${obj.name}</h2>
                    <h3 class="breed">${obj.breed}</h3>
                    <div class="action">
                        <a class="btn" href="/details${obj._id}">Details</a>
                    </div>
    </div>
`;

export async function catalogPage(ctx){
    const obj = await showAll();
    ctx.render(tamplate(obj));
};