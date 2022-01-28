function solve() {
    let divInputs = document.getElementById('container');

    let name = divInputs.children[0];
    let hall = divInputs.children[1];
    let ticketPrice = divInputs.children[2];

    let buttons = document.getElementsByTagName('button');

    let onScreen = buttons[0];
    onScreen.type = 'button';
    onScreen.addEventListener('click', onClick);

    let moviesSection = document.getElementById('movies');
    let ul = moviesSection.children[1];

    function onClick() {
        if (name.value.length != 0 && hall.value.length != 0 && Number(ticketPrice.value)) {
            let li = document.createElement('li');
            let span = document.createElement('span');
            let strong = document.createElement('strong');
            let div = document.createElement('div');
            let strongDiv = document.createElement('strong');
            let input = document.createElement('input');
            let btn = document.createElement('button');

            span.textContent = name.value;
            strong.textContent = `Hall: ${hall.value}`;
            strongDiv.textContent = Number(ticketPrice.value).toFixed(2);
            input.placeholder = 'Tickets Sold';
            btn.textContent = 'Archive';

            btn.addEventListener('click', archive);

            li.appendChild(span);
            li.appendChild(strong);
            div.appendChild(strongDiv);
            div.appendChild(input);
            div.appendChild(btn);
            li.appendChild(div);

            ul.appendChild(li);
        }

        name.value = '';
        hall.value = '';
        ticketPrice.value = '';
    }
    let archiveUl = document.getElementById('archive').children[1];
    function archive(ev) {
        let ticketsSold = ev.target.previousElementSibling;
        
        if (Number(ticketsSold.value)) {
            let name = ev.target.parentNode.parentNode.firstChild;
            let liToDelete = ev.target.parentNode.parentNode;
            let price = ev.target.parentNode.firstChild;
            
            let li = document.createElement('li');
            let span = document.createElement('span');
            let strong = document.createElement('strong');
            let btn = document.createElement('button');

            btn.addEventListener('click', del);

            span.textContent = name.textContent;
            strong.textContent = `Total amount: ${Number(ticketsSold.value * price.textContent).toFixed(2)}`
            btn.textContent = 'Delete';

            li.appendChild(span);
            li.appendChild(strong);
            li.appendChild(btn);

            archiveUl.appendChild(li);
            liToDelete.remove();       
        }
    }

    function del(ev){
        let element = ev.target.parentNode;

        element.remove();
    }

    let clearBtn = buttons[1];
    clearBtn.addEventListener('click' ,delAll);

    function delAll(){
        let all = archiveUl.getElementsByTagName('li');
        let size = all.length;

        for (let index = 0; index < size; index++) {
          all[0].remove();       
        }
    }
}