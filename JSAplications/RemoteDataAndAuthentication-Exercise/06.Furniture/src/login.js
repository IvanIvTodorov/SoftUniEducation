window.addEventListener('load', (ev) => {
    ev.preventDefault();

    let regForm = document.getElementsByTagName('form')[0];
    let logForm = document.getElementsByTagName('form')[1];

    logForm.addEventListener('submit', logIn);
    regForm.addEventListener('submit', register);
});

async function register(ev){
    ev.preventDefault();
    const url = `http://localhost:3030/users/register`;
    let formData = new FormData(ev.target);

    const email = formData.get('email');
    const password = formData.get('password');
    const rePass = formData.get('rePass');

    
    try {
        if (password != rePass) {
            throw new Error('Passwords should match!')
        };

        const res = await fetch(url, {
            method: 'post',
            headers: {
                "Content-Type": "application/js"
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

        ev.target.reset();

    } catch (error) {
        alert(error.message);
    }
};

async function logIn(ev){
    ev.preventDefault();
    const url = `http://localhost:3030/users/login`;
    let formData = new FormData(ev.target);

    const email = formData.get('email');
    const password = formData.get('password');

    try {
        const res = await fetch(url, {
            method: 'post',
            headers: {
                "Content-Type": "application/js"
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

        const token = data.accessToken;

        localStorage.setItem('token', token);
        localStorage.setItem('id', data._id);

        window.location = `/homeLogged.html`;

    } catch (error) {
        alert(error.message);
    }
};