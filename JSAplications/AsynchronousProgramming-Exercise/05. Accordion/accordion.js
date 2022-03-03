window.onlaod = solution();

async function solution() {

    let titles = await fetch(`http://localhost:3030/jsonstore/advanced/articles/list`);
    let data = await titles.json();
    let main = document.getElementById('main');
    let text = '';

    for (const item of data) {
        let response = await fetch(`http://localhost:3030/jsonstore/advanced/articles/details`);
        let result = await response.json();
        for (const obj of Object.keys(result)) {
            console.log(result[obj]);
            text += `<div class="accordion">
            <div class="head">
                <span>${result[obj].title}</span>
                <button class="button" id="${result[obj]._id}">More</button>
            </div>
            <div class="extra">
                <p>${result[obj].content}</p>
            </div>
        </div>`
        console.log(result[obj]._id)
        };
        break;
    };

    main.innerHTML = text;

    let btns = document.getElementsByClassName('button');

    for (const btn of btns) {
        btn.addEventListener('click', onClick);
    };

    function onClick(ev){

        let element = ev.target.parentNode.parentNode.getElementsByClassName('extra')[0];
        
        if (ev.target.textContent == 'More') {
            ev.target.textContent = 'Less'
            element.style.display = 'block';
        }else{
            ev.target.textContent = 'More'
            element.style.display = 'none';
        };
    };
};