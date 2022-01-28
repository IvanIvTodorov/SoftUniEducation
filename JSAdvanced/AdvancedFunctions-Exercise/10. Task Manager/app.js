function solve() {
    let task = document.getElementById('task');
    let descrip = document.getElementById('description');
    let date = document.getElementById('date');
    let addBtn = document.getElementById('add');
    addBtn.type = 'button';

    addBtn.addEventListener('click', add);

    let sections = document.getElementsByTagName('section');
    let open = sections[1];
    let inProgress = sections[2];
    let complete = sections[3];
    
    function add() {
        if (task.value && descrip.value && date.value) {
            let article = document.createElement('article');
            let h3 = document.createElement('h3');
            let firstP = document.createElement('p');
            let secP = document.createElement('p');
            let div = document.createElement('div');
            let firstBtn = document.createElement('button');
            let secBtn = document.createElement('button');

            h3.textContent = task.value;
            firstP.textContent = `Description: ${descrip.value}`;
            secP.textContent = `Due Date: ${date.value}`;
            div.classList.add('flex');
            firstBtn.classList.add('green');
            firstBtn.textContent = 'Start';
            firstBtn.addEventListener('click', move);
            secBtn.classList.add('red');
            secBtn.textContent = 'Delete';
            secBtn.addEventListener('click', del);
            div.appendChild(firstBtn);
            div.appendChild(secBtn);

            article.appendChild(h3);
            article.appendChild(firstP);
            article.appendChild(secP);
            article.appendChild(div);

            open.children[1].appendChild(article);

            function move(ev) {
                let element = ev.target.parentNode.parentNode;
                let current = element.getElementsByTagName('div')[0];
                if (ev.target.textContent == 'Start') {
                    ev.target.remove();
                    current.appendChild(ev.target);

                    ev.target.classList.remove('green');
                    ev.target.classList.add('orange');
                    ev.target.textContent = 'Finish';

                    inProgress.children[1].appendChild(element);
                } else {
                    current.remove();
                    complete.children[1].appendChild(element);
                }
            };
            function del(ev) {
                let element = ev.target.parentNode.parentNode;

                element.remove();
            }
        }
    }
}