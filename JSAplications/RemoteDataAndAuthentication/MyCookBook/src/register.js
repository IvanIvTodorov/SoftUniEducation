window.addEventListener('load', async () => {
    const form = document.querySelector('form');
    form.addEventListener('submit', register);
});

async function register(ev) {
    ev.preventDefault();
    console.log(ev);
    const url = `http://localhost:3030/users/register`;
    const form = ev.target;
    const formData = new FormData(form);


    const email = formData.get('email').trim();
    const password = formData.get('password').trim();;
    const rePass = formData.get('rePass').trim();

    try {

        if (password != rePass) {
            throw new Error('Passwords did not match !')
        };

        let response = await fetch(url, {
            method: 'post',
            headers: {
                'Content-Type': 'aplication/json'
            },
            body: JSON.stringify({email, password})
        });

        if (response.ok == false) {
            let error = await response.json();
            throw new Error(error.message);
        };

        let data = await response.json();
        let token = data.accessToken;

        localStorage.setItem('token', token);

        window.location = '/index.html';

    } catch (error) {
        alert(error.message);
    }
};