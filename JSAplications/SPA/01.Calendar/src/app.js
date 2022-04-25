import { revealDays } from "./revealDays.js";
import { revealMonths } from "./revealMonths.js";

window.addEventListener('load', () => {
    var years = document.getElementById('years');
    let sections = document.getElementsByTagName('section');
    for (const section of sections) {

        section.style.display = 'none';
    };

    years.style.display = 'block';
    years.addEventListener('click', displayMonths);
});

let year;
let months;
let days;

function displayMonths(ev) {
    year = ev.target.textContent;
    
    months = revealMonths(ev.target.textContent);
    months.childNodes[1].children[0].addEventListener('click', getBack);
    years.style.display = 'none';

    months.addEventListener('click', displayDays);
};

function displayDays(ev) {
    if (!Number(ev.target.textContent)) {
        days = revealDays(ev.target.textContent, year);
        months.style.display = 'none';

        days.childNodes[1].children[0].addEventListener('click', getBack);
    };
};

function getBack(ev) {

    if (Number(ev.target.textContent)) {
        months.style.display = 'none';
        years.style.display = 'block';
    } else {
        days.style.display = 'none';
        months.style.display = 'block';
    };
};