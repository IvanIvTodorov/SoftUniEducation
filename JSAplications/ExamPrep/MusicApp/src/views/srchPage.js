import { afterSearch } from '../api/data.js';
import { html } from '../lib.js';
import { getUserData } from '../util.js';

const tamplate = (onSearch) => html`
<section id="searchPage">
            <h1>Search by Name</h1>

            <div class="search">
                <input id="search-input" type="text" name="search" placeholder="Enter desired albums's name">
                <button @click=${onSearch} class="button-list">Search</button>
            </div>

            <h2>Results:</h2>       
        </section>
`;


const searchTamplate = (obj, onSearch) => html`
<section id="searchPage">
            <h1>Search by Name</h1>

            <div class="search">
                <input id="search-input" type="text" name="search" placeholder="Enter desired albums's name">
                <button @click=${onSearch} class="button-list">Search</button>
            </div>

            <h2>Results:</h2>
            
                <div class="search-result">
                    ${obj.length == 0 ? html` <p class="no-result">No result.</p>` 
                    
                    : obj.map(elementTamplate)
                    }
                </div>    

        </section>
`

const elementTamplate = (obj) => html`
     <div class="card-box">
        <img src="${obj.imgUrl}">
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
`


export async function searchPage(ctx) {
    
    ctx.render(tamplate(onSearch));

    
    async function onSearch(ev){
        ev.preventDefault();
        const data = document.querySelector('#search-input').value;

        const obj = await afterSearch(data);

        ctx.render(searchTamplate(obj, onSearch))

        const userData = getUserData();

        if (!userData) {
            for (const el of document.getElementsByClassName('btn-group')) {
                el.style.display = 'none';
            };
        };
    
    };
};