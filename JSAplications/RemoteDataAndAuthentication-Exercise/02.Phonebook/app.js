function attachEvents() {
    let load = document.getElementById('btnLoad');
    let create = document.getElementById('btnCreate');
    let person = document.getElementById('person');
    let phone = document.getElementById('phone');
    let phonebook = document.getElementById('phonebook');

    let url = 'http://localhost:3030/jsonstore/phonebook';
    let data;
    load.addEventListener('click', onLoad);

    async function onLoad(){
        phonebook.innerHTML = '';
        try {
            const res = await fetch(url, {
                method: 'get',
                headers: {
                    'Content-Type': "application/js"
                }
            });
    
            if (!res.ok) {
                const er = await res.json();
                throw new Error(er.message)
            };

            data = await res.json();

            for (const item of Object.keys(data)) {
                let li = document.createElement('li');
                let btn = document.createElement('button');
                btn.textContent = 'Delete';
                btn.addEventListener('click', deleteIt);

                li.textContent = `${data[item].person}: ${data[item].phone}`;

                li.appendChild(btn);
                phonebook.appendChild(li);
            };
        } catch (error) {
            alert(error.message);
        }
    };

    create.addEventListener('click', createIt);

    async function createIt(){
        let obj = {
            person: person.value,
            phone: phone.value
        };
        try {
            const res = await fetch(url, {
                method: 'post',
                headers: {
                    'Content-Type': 'application/js'
                },
                body: JSON.stringify(obj)
            });

            if (!res.ok) {
                const er = await res.json();
                throw new Error(er.message);
            };

        } catch (error) {
            alert(error.message)
        };

        onLoad();
        person.value = '';
        phone.value = '';
    };


    async function deleteIt(ev){
        const name = ev.target.parentNode.textContent.split(':')[0];
        
        let record = Object.values(data).find(x => x.person == name);
        let id = '/' + record._id;

        try {
            let res = await fetch(url + id , {
                method: 'delete',
                headers: {
                    'Content-Type': 'application/js'
                }
            });

            if (!res.ok) {
                const er = await res.json();
                throw new Error(er.message);
            }
        } catch (error) {
            alert(error.message);
        }      

        ev.target.parentNode.remove();
    };
}

attachEvents();