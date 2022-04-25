window.onload = () => {
    const form = document.querySelector('form');
    form.addEventListener('submit', onSubmit);
    
};

async function onSubmit(ev){
    ev.preventDefault();
    const url = `http://localhost:3030/users/login`
    let formData = new FormData(ev.target);

    const email = formData.get('email');
    const password = formData.get('password');

    try {
        const res = await fetch(url, {
            method: 'post',
            header: {
                "Content-Type": 'application/js'
            },
            body: JSON.stringify({email, password})
        });

        if (!res.ok) {
            let er = await res.json();
            throw new Error(er.message);
        };

        const data = await res.json();
        var token = data.accessToken;
        var id = data._id;

        console.log(data);
        localStorage.setItem('token', token);
        localStorage.setItem('id', id);
        localStorage.setItem('username', email);

        window.location = `/index.html`;
    } catch (error) {
        alert(error.message);
    }
};