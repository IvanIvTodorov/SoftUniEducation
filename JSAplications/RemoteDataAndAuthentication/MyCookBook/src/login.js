window.addEventListener('load', async () => {
    const form = document.querySelector('form');
    form.addEventListener('submit', login);
});

async function login(ev){
    ev.preventDefault();
    const url = 'http://localhost:3030/users/login';
    const formData = new FormData(ev.target);

    const email = formData.get('email').trim();
    const password = formData.get('password').trim();

    try {
        let res = await fetch(url , {
            method: 'post',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({email, password})
        });

        if (res.ok == false) {
            const error = await res.json();

            throw new Error(error.messsage);
        };

        let data = await res.json();
        let token = data.accessToken;

        localStorage.setItem('token', token);

        window.location = '/index.html'

    } catch (error) {
        alert(error.message);
    }

};