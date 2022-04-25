window.onload = () => {
    const form = document.querySelector('form');
    form.addEventListener('submit', onRegister);
};

async function onRegister(ev) {
    ev.preventDefault();
    const url = `http://localhost:3030/users/register`;
    let formData = new FormData(ev.target);

    const email = formData.get('email');
    const password = formData.get('password');
    const rePas = formData.get('rePass');

    try {
        if (password != rePas) {
            throw new Error('Passwords should match!')
        };

        let res = await fetch(url, {
            method: 'post',
            headers: {
                "Content-Type": 'application/js'
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

        window.location = '/login.html'
    } catch (error) {
        alert(error.message);
    }
};
