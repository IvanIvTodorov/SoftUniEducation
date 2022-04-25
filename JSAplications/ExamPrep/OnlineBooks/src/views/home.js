import { html } from '../lib.js';
import { getUserData } from '../util.js';

const tamplate = () => html`
`;

export async function homePage(ctx) {
    if (getUserData()) {
        ctx.page.redirect('/catalog');
    } else {
        ctx.render(tamplate());
    };
};