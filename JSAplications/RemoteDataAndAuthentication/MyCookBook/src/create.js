window.addEventListener('load', async () => {
    if (!localStorage.getItem('token')) {
        window.location = `/login.html`
    };
    const form = document.querySelector('form');
    form.addEventListener('submit', create);


});

async function create(ev){
    ev.preventDefault();

    const formData = new FormData(ev.target);

    const name = formData.get('name').trim();
    const img = formData.get('img').trim();
    const ingred = formData.get('ingredients').trim().split('\n');
    const steps = formData.get('steps').trim().split('\n');

    let bodyObj = {
        name,
        img,
        ingred,
        steps
    };
    
    const url = `http://localhost:3030/data/recipes`;
    const token = localStorage.getItem('token');
    try {
        let res = await fetch(url, {
            method: 'post',
            headers: {
                'Content-Type': 'application/js',
                'X-Authorization': token
            },
            body: JSON.stringify(bodyObj)
        });

        if (res.ok == false) {
            let error = res.json();
            throw new Error(error.message);
        };

        let data = await res.json();
        window.location = '/index.html'
    } catch (error) {
        alert(error.message);
    }
};