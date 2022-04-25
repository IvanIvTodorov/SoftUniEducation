import { createMovie } from "./createMovie.js";
import { logIn } from "./login.js";
import { register } from "./register.js";
import { showAll } from "./showAllMovies.js";
import { showDetails } from "./showDetails.js";

// navigation elements
let greetings = document.querySelectorAll('.nav-item')[0].children[0];
let logout = document.querySelectorAll('.nav-item')[1];
let loginBtn = document.querySelectorAll('.nav-item')[2];
let registerBtn = document.querySelectorAll('.nav-item')[3];
let homeBtn = document.getElementsByTagName('nav')[0].children[0];

//addBtn
let addBtn = document.getElementById('add-movie-button');

// h1 element
let h1 = document.querySelector('h1[class="text-center"]');

// all sections
let body = document.getElementsByTagName('body')[0];
let nav = document.getElementsByTagName('nav')[0];
let homepage = document.getElementsByTagName('section')[0];
let movies = document.getElementsByTagName('section')[2];
let addMovie = document.getElementsByTagName('section')[3];
let movieDetails = document.getElementsByTagName('section')[4];
let editMovie = document.getElementsByTagName('section')[5];
let loginForm = document.getElementsByTagName('section')[6];
let registerForm = document.getElementsByTagName('section')[7];
let arr = [addMovie, movieDetails, editMovie, loginForm, registerForm];

// footer
let footer = document.getElementsByTagName('footer')[0];

// tempData
let data;
export function onLoad() {
    let token = localStorage.getItem('token');
    let greetUsername = localStorage.getItem('username');
    if (token) {
        loginBtn.style.display = 'none';
        registerBtn.style.display = 'none';
        logout.style.display = 'inline-block';
        greetings.style.display = 'inline-block';
        greetings.textContent = `Welcome, ${greetUsername}`;
        addBtn.style.display = 'block';

    } else {
        loginBtn.style.display = 'inline-block';
        registerBtn.style.display = 'inline-block';
        logout.style.display = 'none';
        greetings.style.display = 'none';
        addBtn.style.display = 'none';
    };

    for (const item of arr) {
        item.remove();
    };

    body.appendChild(nav);
    body.appendChild(homepage);
    body.appendChild(h1);
    body.appendChild(addBtn);
    body.appendChild(movies);
    body.appendChild(footer);

    registerBtn.addEventListener('click', onRegister);
    loginBtn.addEventListener('click', onLogin);
    addBtn.addEventListener('click', onCreate);
    homeBtn.addEventListener('click', onHome);
    logout.addEventListener('click', onLogout);
    loading();
};

function onLogout() {
    localStorage.clear();

    onLoad();
}

async function loading() {
    let [curMovies, tempData] = await showAll(movies);
    let detailBtns = curMovies.querySelectorAll('button');
    data = tempData;
    for (const btn of detailBtns) {
        btn.addEventListener('click', onDetails);
    };
};

function onHome() {
    onLoad();
};

function onDetails(ev) {
    let token = localStorage.getItem('token');
    if (token) {
        showDetails(ev, movieDetails, homepage, movies, body, h1, footer, addBtn, data, editMovie);
    };
};

function onCreate() {
    createMovie(addMovie, homepage, movies, body, h1, footer, addBtn);
};

function onLogin() {
    logIn(loginForm, homepage, movies, body, h1, footer, registerForm);
};

function onRegister() {
    register(registerForm, homepage, movies, body, h1, footer, loginForm);
};

onLoad();