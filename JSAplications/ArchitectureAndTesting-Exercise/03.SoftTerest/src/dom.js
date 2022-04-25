const main = document.querySelector('main');

export function showSection(section){
    main.replaceChildren(section);
};