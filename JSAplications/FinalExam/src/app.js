import {page, render} from './lib.js';
import { homePage } from './views/home.js';
import { catalogPage } from './views/catalog.js';
import { getUserData } from './util.js';
import { loginPage } from './views/login.js';
import { registerPage } from './views/register.js';
import { logout } from './api/data.js';
import { createPage } from './views/create.js';
import { detailsPage } from './views/details.js';
import { editPage } from './views/edit.js';
import { profilePage } from './views/profile.js';

const root = document.querySelector('main');

updateNav();

page(decorateContext);
page('/', homePage);
page('/catalog', catalogPage);
page('/login', loginPage);
page('/register', registerPage);
page('/edit:id', editPage);
page('/profile', profilePage);
page('/details:id', detailsPage);
page('/create', createPage);
page.start();

function decorateContext(ctx, next){
    ctx.render = (content) => render(content, root);
    ctx.updateNav = updateNav;
    next();
};

document.getElementById('logoutBtn').addEventListener('click', async function (ev){
    ev.preventDefault();
    await logout();
    updateNav()
    page.redirect('/');

});
function updateNav(){
    const userData = getUserData();

    if (userData) {
        const user = document.getElementsByClassName('user')
        const guest = document.getElementsByClassName('guest')

        for (const item of user) {
            item.style.display = "inline-block"
        }
        for (const item of guest) {
            item.style.display = "none"
        }
    }else{
        const user = document.getElementsByClassName('user');
        const guest = document.getElementsByClassName('guest');

        for (const item of user) {
            item.style.display = "none"
        }
        for (const item of guest) {
            item.style.display = "inline-block"
        }
    }
};


