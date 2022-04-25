function attachEvents() {
    let author = document.querySelector('input[name=author');
    let content = document.querySelector('input[name=content');
    let output = document.getElementById('messages');

    let submit = document.getElementById('submit');
    let refresh = document.getElementById('refresh');

    const url = 'http://localhost:3030/jsonstore/messenger';

    submit.addEventListener('click', onSubmit);
   
    async function onSubmit(){
        let obj = {
            author: author.value,
            content: content.value
        };
        try {
            const res = await fetch(url, {
                method: 'post',
                headers: {
                    'Content-Type': "application/json"
                },
                body: JSON.stringify(obj)
            });

            if (res.ok == false) {
                const er = await res.json();
                throw new Error(er.message);
            };
        } catch (error) {
            alert(error.message);
        }
    };

    refresh.addEventListener('click', showAll)

    async function showAll(){
        try {
            const res = await fetch(url, {
                method: 'get',
                headers: {
                    'Content-Type': "application/json"
                }
            });

            if (res.ok == false) {
                const er = await res.json();
                throw new Error(er.message);
            };

            const data = await res.json();
            let text = '';
            for (const item of Object.keys(data)) {
                text += `${data[item].author}: ${data[item].content}\n`;
            };

            output.textContent = text.trimEnd();
        } catch (error) {
            alert(error.message);
        }

    };
}

attachEvents();