window.addEventListener('load', (ev) => {
    ev.preventDefault();
    let form = document.getElementsByTagName('form')[0];

    form.addEventListener('submit', postOrCancel);
});


async function postOrCancel(ev) {
    ev.preventDefault();
    let url = `http://localhost:3030/jsonstore/collections/myboard/posts`;
    let formData = new FormData(ev.target);
    let topicName = formData.get('topicName');
    let username = formData.get('username');
    let postText = formData.get('postText');
    let today = new Date();
    if (document.activeElement.textContent == 'Post') {
        try {
            let res = await fetch(url, {
                method: 'post',
                headers: {
                    'Content-Type': "application/js"
                },
                body: JSON.stringify({
                    topicName,
                    username,
                    postText,
                    date: `${today.getFullYear()}-${today.getMonth()+1}-${today.getDate()} ${today.getHours()}:${today.getMinutes()}:${today.getSeconds()}`
                })
            });

            if (!res.ok) {
                let er = res.json();
                throw new Error(er.message);
            }
        } catch (error) {
            alert(error.message);
        }

        window.location = 'theme-content.html'
    };

    ev.target.reset();

};