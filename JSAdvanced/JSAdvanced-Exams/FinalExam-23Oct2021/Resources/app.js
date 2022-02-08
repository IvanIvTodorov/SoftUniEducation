window.addEventListener('load', solve);

function solve() {
    let allHits = document.getElementsByClassName('all-hits-container')[0];
    let genre = document.getElementById('genre');
    let name = document.getElementById('name');
    let author = document.getElementById('author');
    let date = document.getElementById('date');
    let tempLikes = 1;
    let addBtn = document.getElementById('add-btn');
    addBtn.type = 'button';

    addBtn.addEventListener('click', onClick);

    function onClick() {
        if (genre.value && name.value && author.value && date.value) {
            let div = document.createElement('div');
            div.classList.add('hits-info');

            let img = document.createElement('img');
            img.src = './static/img/img.png'

            let h2Genre = document.createElement('h2');
            h2Genre.textContent = `Genre: ${genre.value}`;

            let h2Name = document.createElement('h2');
            h2Name.textContent = `Name: ${name.value}`;

            let h2Author = document.createElement('h2');
            h2Author.textContent = `Author: ${author.value}`;

            let h3Date = document.createElement('h3');
            h3Date.textContent = `Date: ${date.value}`;

            let save = document.createElement('button');
            save.classList.add('save-btn');
            save.textContent = 'Save song';

            let like = document.createElement('button');
            like.classList.add('like-btn');
            like.textContent = 'Like song';

            let del = document.createElement('button');
            del.classList.add('delete-btn');
            del.textContent = "Delete"

            let btns = [save, like, del];

            for (const btn of btns) {
                btn.addEventListener('click', action);
            }

            div.appendChild(img);
            div.appendChild(h2Genre)
            div.appendChild(h2Name);
            div.appendChild(h2Author);
            div.appendChild(h3Date);
            div.appendChild(save);
            div.appendChild(like);
            div.appendChild(del);


            allHits.appendChild(div);

            let p = document.getElementsByClassName('likes')[0].children[0];
            let savedContainer = document.getElementsByClassName('saved-container')[0];

            function action(ev) {
                if (ev.target.textContent == 'Save song') {
                    save.remove();
                    like.remove();
                    savedContainer.appendChild(div);

                } else if (ev.target.textContent == 'Like song') {

                    p.textContent = `Total Likes: ${tempLikes}`;
                    ev.target.disabled = true;
                    ev.target.style.color = 'gray';
                    tempLikes++
                } else {
                    div.remove();
                }
            }

            genre.value = '';
            name.value = '';
            author.value = '';
            date.value = '';
        }
    }
}