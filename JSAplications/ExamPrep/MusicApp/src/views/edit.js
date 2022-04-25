import { edit, getById } from '../api/data.js';
import { html} from '../lib.js';

const tamplate = (obj, onSubmit) => html`
     <section class="editPage">
            <form @submit=${onSubmit}>
                <fieldset>
                    <legend>Edit Album</legend>

                    <div class="container">
                        <label for="name" class="vhide">Album name</label>
                        <input id="name" name="name" class="name" type="text" value="${obj.name}">

                        <label for="imgUrl" class="vhide">Image Url</label>
                        <input id="imgUrl" name="imgUrl" class="imgUrl" type="text" value="${obj.imgUrl}">

                        <label for="price" class="vhide">Price</label>
                        <input id="price" name="price" class="price" type="text" value="${obj.price}">

                        <label for="releaseDate" class="vhide">Release date</label>
                        <input id="releaseDate" name="releaseDate" class="releaseDate" type="text"
                            value="${obj.releaseDate}">

                        <label for="artist" class="vhide">Artist</label>
                        <input id="artist" name="artist" class="artist" type="text" value="${obj.artist}">

                        <label for="genre" class="vhide">Genre</label>
                        <input id="genre" name="genre" class="genre" type="text" value="${obj.genre}">

                        <label for="description" class="vhide">Description</label>
                        <textarea name="description" class="description" rows="10"
                            cols="10">${obj.description}</textarea>

                        <button class="edit-album" type="submit">Edit Album</button>
                    </div>
                </fieldset>
            </form>
        </section>
`;


export async function editPage(ctx){
    const obj = await getById(ctx.params.id);
    ctx.render(tamplate(obj, onSubmit));

    async function onSubmit(ev) {
        ev.preventDefault();

        const formData = new FormData(ev.target);

        const name = formData.get('name').trim();
        const price = formData.get('price').trim();
        const releaseDate = formData.get('releaseDate').trim();
        const artist = formData.get('artist').trim();
        const genre = formData.get('genre').trim();
        const description = formData.get('description').trim();
        const imgUrl = formData.get('imgUrl').trim();

        if (name == '' || description == '' || imgUrl == '' || price == '' || artist == '' || genre == '' || releaseDate == '') {
            return alert('All fields required!');
        };


        await edit(ctx.params.id ,{name, imgUrl, price, releaseDate, artist, genre, description});

        ctx.page.redirect('/catalog');
    }
};