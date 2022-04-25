import { getRecentGames } from '../api/data.js';
import { html } from '../lib.js';

const tamplate = (obj) => html`
<section id="welcome-world">
    <div class="welcome-message">
        <h2>ALL new games are</h2>
        <h3>Only in GamesPlay</h3>
    </div>
    <img src="./images/four_slider_img01.png" alt="hero">

    <div id="home-page">
        <h1>Latest Games</h1>

        ${obj.length == 0 ? html`<p class="no-articles">No games yet</p>` 
        : obj.map(elementTamplate)}
        
    </div>
</section>
`;


const elementTamplate = (obj) => html`
    <div class="game">
        <div class="image-wrap">
            <img src="${obj.imageUrl}">
        </div>
        <h3>${obj.title}</h3>
        <div class="rating">
            <span>☆</span><span>☆</span><span>☆</span><span>☆</span><span>☆</span>
        </div>
        <div class="data-buttons">
            <a href="/details${obj._id}" class="btn details-btn">Details</a>
        </div>
    </div>
`;

export async function homePage(ctx) {   
    const obj = await getRecentGames(); 
    ctx.render(tamplate(obj));
};