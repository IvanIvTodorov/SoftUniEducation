export async function showAll(movies) {
    let div = movies.children[0].children[0].children[0];
    let url = `http://localhost:3030/data/movies`
    let data;
    try {
        const res = await fetch(url);

        if (!res.ok) {
            const er = await res.json();
            throw new Error(er.message);
        };

        data = await res.json();
        div.innerHTML = '';
        let text = ''
        for (const item of Object.values(data)) {
            text += `<div class="card mb-4">
            <img class="card-img-top" src="${item.img}"
                alt="Card image cap" width="400">
            <div class="card-body">
                <h4 class="card-title">${item.title}</h4>
            </div>
            <div class="card-footer">
                <a href="#/details/6lOxMFSMkML09wux6sAF">
                    <button type="button" class="btn btn-info">Details</button>
                </a>
            </div>

        </div>`;
        };

        div.innerHTML = text;
    } catch (error) {
        alert(error.message);
    }

    return [div, data];
};