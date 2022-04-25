import { doDonation, getById, isDonated, onDelete, totalDonations } from '../api/data.js';
import { html} from '../lib.js';
import { getUserData } from '../util.js';

const tamplate = (obj, flag, del, donation, donate) => html`
    <section id="detailsPage">
            <div class="details">
                <div class="animalPic">
                    <img src="${obj.image}">
                </div>
                <div>
                    <div class="animalInfo">
                        <h1>Name: ${obj.name}</h1>
                        <h3>Breed: ${obj.breed}</h3>
                        <h4>Age: ${obj.age}</h4>
                        <h4>Weight: ${obj.weight}</h4>
                        <h4 class="donation">Donation: ${donation * 100}$</h4>
                    </div>

                    <div id="regUser" class="actionBtn">

                        ${flag ? html`
                            <a href="/edit${obj._id}" class="edit">Edit</a>
                            <a @click=${del} href="#" class="remove">Delete</a>
                        ` : html`<a id="donateBtn" @click=${donate} href="#" class="donate">Donate</a>`}
                    </div>
                </div>
            </div>
        </section>
`;


export async function detailsPage(ctx){
    const obj = await getById(ctx.params.id);

    const userData = getUserData();
    const flag = userData && obj._ownerId == userData.id;
    const petId = obj._id;
    const donation = await totalDonations(petId)

    ctx.render(tamplate(obj,flag, del, donation, donate));

    if (!userData) {
        document.querySelector('#regUser').style.display = "none";
    };

    if (userData) {
        const donated = await isDonated(petId, userData.id)

        if (donated != 0) {
            document.querySelector('#donateBtn').style.display = "none";
        }
    }

    async function donate(ev){
        ev.preventDefault();

        await doDonation({petId});

        ctx.page.redirect(`/details${obj._id}`)
    };

    async function del(ev){
        ev.preventDefault();
        const choice = confirm('Do you want to delete this ?');

        if (choice) {
            await onDelete(ctx.params.id);
            ctx.page.redirect('/catalog');
        };
    };
};