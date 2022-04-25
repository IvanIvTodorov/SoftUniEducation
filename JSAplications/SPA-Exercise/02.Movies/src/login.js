import { onLoad } from "./app.js"
export function logIn(form, home, movies, body, h1, footer, registerForm){

    h1.remove();
    home.remove();
    movies.remove();
    registerForm.remove();

    body.appendChild(form);
    body.appendChild(footer);

    form.addEventListener('submit', login);
};

async function login(ev){
    ev.preventDefault();
    const url = `http://localhost:3030/users/login`
    let formData = new FormData(ev.target);

    const email = formData.get('email');
    const password = formData.get('password');

    try {
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

        const data = await res.json();

        console.log(data);
        let token = data.accessToken;
        let username = data.email;
        let id = data._id;

        localStorage.setItem('token', token);
        localStorage.setItem('username', username);
        localStorage.setItem('id', id);

        onLoad();
    } catch (error) {
        alert(error.message);
    }
};