import { showCatalogPage } from "./views/catalog.js";
import { showCreatePage } from "./views/create.js";
import { showDescriptionPage } from "./views/description.js";
import { showHomePage } from "./views/home.js";
import { showLoginPage } from "./views/login.js";
import { showRegisterPage } from "./views/register.js";
import { showSection } from "./dom.js";
import { logout } from "./api/data.js";

const links = {
    "homeLink": 'home',
    "startedLink": "home",
    "createLink": 'create',
    "loginLink": "login",
    "registerLink": "register",
    "catalogLink": "catalog"
};

const views = {
    "home": showHomePage,
    "create": showCreatePage,
    "login": showLoginPage,
    'register': showRegisterPage,
    'catalog': showCatalogPage,
    'description': showDescriptionPage
};

document.getElementById('logoutLink').addEventListener('click', async (ev) => {
    ev.preventDefault();
    await logout();
    updateNav();
    goTo('home');
});

const nav = document.querySelector('nav');
nav.addEventListener('click', onNavigate);

const ctx = {
    goTo,
    showSection,
    updateNav
};

updateNav();
goTo('home');


function onNavigate(ev) {
    const name = links[ev.target.id];
    if (name) {
        ev.preventDefault();
        goTo(name);
    };
};

function goTo(name, ...params) {
    const view = views[name];
    if (typeof view == 'function') {
        view(ctx, ...params)
    };
};

function updateNav() {
    const token = sessionStorage.getItem('token');

    if (token != null) {
        [...nav.querySelectorAll('.user')].forEach(i => i.style.display = 'block');
        [...nav.querySelectorAll('.guest')].forEach(i => i.style.display = 'none');

    } else {
        [...nav.querySelectorAll('.user')].forEach(i => i.style.display = 'none');
        [...nav.querySelectorAll('.guest')].forEach(i => i.style.display = 'block');
    };
};

