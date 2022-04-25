import { onLoad } from './app.js'
export function createMovie(form, home, movies, body, h1, footer, btn) {
    h1.remove();
    home.remove();
    movies.remove();
    btn.remove();

    body.appendChild(form);
    body.appendChild(footer);

    form.addEventListener('submit', create);
};

async function create(ev) {
    ev.preventDefault();
    const url = `http://localhost:3030/data/movies`
    let token = localStorage.getItem('token');
    let formData = new FormData(ev.target);

    const title = formData.get('title');
    const description = formData.get('description');
    const img = formData.get('imageUrl');

    try {
        const res = await fetch(url, {
            method: 'post',
            headers: {
                'Content-Type': 'application/js',
                'X-Authorization': token
            },
            body: JSON.stringify({
                title,
                description,
                img
            })
        });


        if (!res.ok) {
            const er = await res.json();
            throw new Error(er.message);
        };

        onLoad();
    } catch (error) {
        alert(error.message);
    }
};