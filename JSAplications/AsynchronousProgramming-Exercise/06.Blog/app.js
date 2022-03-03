function attachEvents() {
    let load = document.getElementById('btnLoadPosts');
    let input = document.getElementById('posts');
    let view = document.getElementById('btnViewPost');
    let title = document.getElementById('post-title');
    let text = document.getElementById('post-body');
    let list = document.getElementById('post-comments');
    
    load.addEventListener('click', loadIt);
    view.addEventListener('click', viewIt);

    let data;

    async function loadIt(){
        let response = await fetch(`http://localhost:3030/jsonstore/blog/posts`);
        data = await response.json();

        for (const obj of Object.keys(data)) {
            let option = document.createElement('option');
            option.value = obj
            option.textContent = data[obj].title;

            input.appendChild(option);
        };
    };

    async function viewIt(){
        list.innerHTML = '';
        console.log(input.value);
        let res = await fetch(`http://localhost:3030/jsonstore/blog/comments/`);
        let result = await res.json();
        console.log(data);

        let current = Object.values(result).filter(x => x.postId === input.value);
        
        for (const comment of current) {
            let li = document.createElement('li');

            li.id = comment.id;
            li.textContent = comment.text;

            list.appendChild(li);
        };
        text.textContent = data[input.value].body;
        title.textContent = data[input.value].title
    }; 
};

attachEvents();