window.addEventListener('load', solve);

function solve() {
    let tempPrice = 0;
    let model = document.getElementById('model');
    let year = document.getElementById('year');
    let description = document.getElementById('description');
    let price = document.getElementById('price');
    let addBtn = document.getElementById('add');
    addBtn.type = 'button';

    addBtn.addEventListener('click', onClick);

    let tBody = document.getElementById('furniture-list');
    function onClick() {

        if (model.value && year.value > 0 && description.value && price.value > 0) {
            let trInfo = document.createElement('tr');
            trInfo.classList.add('info');

            let tdModel = document.createElement('td');
            tdModel.textContent = model.value;

            let tdPrice = document.createElement('td');
            tdPrice.textContent = Number(price.value).toFixed(2);

            let td = document.createElement('td');

            let moreBtn = document.createElement('button');
            moreBtn.textContent = 'More Info';
            moreBtn.classList.add('moreBtn');

            let buyBtn = document.createElement('button');
            buyBtn.textContent = 'Buy it';
            buyBtn.classList.add('buyBtn');

            let trHide = document.createElement('tr');
            trHide.classList.add('hide');

            let tdYear = document.createElement('td');
            tdYear.textContent = `Year: ${year.value}`;

            let tdDescr = document.createElement('td');
            tdDescr.textContent = `Description: ${description.value}`;
            tdDescr.colSpan = '3';


            trInfo.appendChild(tdModel);
            trInfo.appendChild(tdPrice);
            td.appendChild(moreBtn);
            td.appendChild(buyBtn);
            trInfo.appendChild(td);
            trHide.appendChild(tdYear);
            trHide.appendChild(tdDescr);

            tBody.appendChild(trInfo);
            tBody.appendChild(trHide);

            moreBtn.addEventListener('click', more);

            function more(ev){

                if (ev.target.textContent == 'More Info') {
                    ev.target.textContent = 'Less Info';

                    trHide.style.display = 'contents';
                }else{
                    ev.target.textContent = 'More Info';

                    trHide.style.display = 'none';
                }
            }

            buyBtn.addEventListener('click', buy);

            let totalPrice = document.getElementsByClassName('total-price')[0];

            function buy(){
                tempPrice += Number(tdPrice.textContent);

                totalPrice.textContent = Number(tempPrice).toFixed(2);

                trInfo.remove();
                trHide.remove();
            };
        } 
        model.value = '';
        price.value = '';
        description.value = '';
        year.value = '';   
    }
}
