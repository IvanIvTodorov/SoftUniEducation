import { onLoad } from "./app.js"
export function register(form, home, movies, body, h1, footer, loginForm) {
    h1.remove();
    home.remove();
    movies.remove();
    loginForm.remove();

    body.appendChild(form);
    body.appendChild(footer);

    form.addEventListener('submit', registration);
};

async function registration(ev){
    ev.preventDefault();
    const url = `http://localhost:3030/users/register`
    let formData = new FormData(ev.target);

    const email = formData.get('email');
    const password = formData.get('password');
    const rePass = formData.get('repeatPassword');

    try {
        if (rePass != password) {
            throw new Error('Passwords should match!')
        };

        const res = await fetch(url, {
            method: 'post',
            headers: {
                'Content-Type': 'application/js'
            },
            body: JSON.stringify({
                email,
                password
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