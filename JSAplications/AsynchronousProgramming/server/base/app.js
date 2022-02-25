window.addEventListener('load', () => {
    myFunc();
});

async function myFunc() {
    let main = document.getElementsByTagName('main')[0];
    main.innerHTML = '';
    console.log(main);
    try {
        const response = await fetch(`http://localhost:3030/jsonstore/cookbook/recipes`);
        const data = await response.json();

        if (response.ok == false) {
            throw new Error();
        };

        for (const item of Object.values(data)) {
            let article = document.createElement('article');
            article.classList.add('preview');

            let div = document.createElement('div');
            div.classList.add('title');

            let h2 = document.createElement('h2');
            h2.textContent = item.name;

            let divSmall = document.createElement('div');
            divSmall.classList.add('small');

            let img = document.createElement('img');
            img.src = item.img;

            div.appendChild(h2);
            divSmall.appendChild(img);
            article.appendChild(div);
            article.appendChild(divSmall);

            main.appendChild(article);

            article.addEventListener('click', () => onClick(article, item._id));
        };
    } catch (error) {

    }

    async function onClick(article, id) {
        try {
            const res = await fetch(`http://localhost:3030/jsonstore/cookbook/details/${id}`);
            const data2 = await res.json();
            
            article.innerHTML = '';

            let h2 = document.createElement()

        } catch (error) {

        }




    };
};