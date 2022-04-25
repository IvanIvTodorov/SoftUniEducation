import { onLoad } from "./app.js";

export function showDetails(ev, section, home, movies, body, h1, footer, btn, data, editForm) {
    h1.remove();
    home.remove();
    movies.remove();
    btn.remove();

    body.appendChild(section);
    body.appendChild(footer);

    let form = editForm;
    let imgUrl = ev.target.parentNode.parentNode.parentNode.children[0].src;
    let title = ev.target.parentNode.parentNode.parentNode.children[1].children[0].textContent;
    let tempObj = Object.values(data).find(x => x.title == title)
    let description = tempObj.description;
    section.children[0].innerHTML = `
    <div class="row bg-light text-dark">
        <h1>Movie title: ${title}</h1>
        <div class="col-md-8">
            <img class="img-thumbnail" src="${imgUrl}"alt="Movie">
        </div>
        <div class="col-md-4 text-center">
            <h3 class="my-3 ">Movie Description</h3>
            <p>${description}</p>
            <a class="btn btn-danger" href="#">Delete</a>
            <a class="btn btn-warning" href="#">Edit</a>
            <a class="btn btn-primary" href="#">Like</a>
            <span class="enrolled-span">Liked 1</span>
        </div>
    </div>`;

    let owner = tempObj._ownerId;
    let movieId = tempObj._id;
    let del = document.getElementsByClassName('btn btn-danger')[0];
    let edit = document.getElementsByClassName('btn btn-warning')[0];
    let like = document.getElementsByClassName('btn btn-primary')[0];
    let liked = document.getElementsByClassName('enrolled-span')[0];
    liked.style.display = 'none';

    let id = localStorage.getItem('id');
    if (id != owner) {
        del.style.display = 'none';
        edit.style.display = 'none';
    };

    del.addEventListener('click', onDelete);
    edit.addEventListener('click', onEdit);
    like.addEventListener('click', likeIt);

    async function likeIt() {
        try {
            if (id == owner) {
                throw new Error('You can\'t like your movie');
            };

            let url = 'http://localhost:3030/data/likes';
            let token = localStorage.getItem('token');

            let result = await fetch(url, {
                method: 'post',
                headers: {
                    'Content-Type': 'application/js',
                    'X-Authorization': token
                },
                body: JSON.stringify({
                    movieId: movieId
                })
            });


            if (!result.ok) {
                const er = await result.json();
                throw new Error(er.message);
            };

            let curLikes = await fetch(`http://localhost:3030/data/likes?where=movieId%3D%22${movieId}%22&distinct=_ownerId&count`);
            let likes = await curLikes.json();

            liked.style.display = 'block';
            liked.textContent = `Liked ${likes}`;

            like.remove();
        } catch (error) {
            alert(error.message);
        }


    };

    async function onDelete() {
        const url = `http://localhost:3030/data/movies/${movieId}`
        let token = localStorage.getItem('token');

        try {
            const res = await fetch(url, {
                method: 'delete',
                headers: {
                    'Content-Type': 'application/js',
                    'X-Authorization': token
                },
            });


            if (!res.ok) {
                const er = await res.json();
                throw new Error(er.message);
            };

            onLoad();
        } catch (error) {
            alert(error.message);
        }

    }

    function onEdit() {
        body.appendChild(form);
        document.querySelector('input[id="title"').value = title;
        document.querySelector('textarea[name="description"').value = description;
        document.querySelector('input[id="imageUrl"').value = imgUrl;
        
        section.remove();
        body.appendChild(footer);

        form.addEventListener('submit', create)

        async function create(ev) {
            ev.preventDefault();
            const url = `http://localhost:3030/data/movies/${movieId}`
            let token = localStorage.getItem('token');
            let formData = new FormData(ev.target);

            let title = formData.get('title');
            let description = formData.get('description');
            let img = formData.get('imageUrl');

            try {
                const res = await fetch(url, {
                    method: 'put',
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

                let result = await fetch(url);
                data = await result.json();

                description = data.description;
                title = data.title;
                imgUrl = data.img;
                section.children[0].innerHTML = `
                <div class="row bg-light text-dark">
                <h1>Movie title: ${title}</h1>
                <div class="col-md-8">
                <img class="img-thumbnail" src="${imgUrl}"
                alt="Movie">
                </div>
                <div class="col-md-4 text-center">
                <h3 class="my-3 ">Movie Description</h3>
                <p>${description}</p>
                <a class="btn btn-danger" href="#">Delete</a>
                <a class="btn btn-warning" href="#">Edit</a>
                <a class="btn btn-primary" href="#">Like</a>
                <span class="enrolled-span">Liked 1</span>
                </div>
                </div>`;

                body.appendChild(section);
                body.appendChild(footer);
                form.remove();

                let del = document.getElementsByClassName('btn btn-danger')[0];
                let edit = document.getElementsByClassName('btn btn-warning')[0];
                let like = document.getElementsByClassName('btn btn-primary')[0];
                let liked = document.getElementsByClassName('enrolled-span')[0];
                liked.style.display = 'none';
                
                del.addEventListener('click', onDelete);
                edit.addEventListener('click', onEdit);
                like.addEventListener('click', likeIt);

                liked.style.display = 'none';
            } catch (error) {
                alert(error.message);
            }
        };
    };
};
