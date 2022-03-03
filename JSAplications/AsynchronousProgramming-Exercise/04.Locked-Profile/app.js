async function lockedProfile() {
    let text = '';
    let main = document.getElementById('main');

    let response = await fetch(`http://localhost:3030/jsonstore/advanced/profiles`);
    let data = await response.json();


    for (const item of Object.values(data)) {
        console.log(item);
        text += `<div class="profile">
        <img src="./iconProfile2.png" class="userIcon" />
        <label>Lock</label>
        <input type="radio" name="user1Locked" value="lock" checked>
        <label>Unlock</label>
        <input type="radio" name="user1Locked" value="unlock"><br>
        <hr>
        <label>Username</label>
        <input type="text" name="user1Username" value="${item.username}" disabled readonly />
        <div class="hiddenInfo">
            <hr>
            <label>Email:</label>
            <input type="email" name="user1Email" value="${item.email}" disabled readonly />
            <label>Age:</label>
            <input type="email" name="user1Age" value="${item.age}" disabled readonly />
        </div>
        
        <button>Show more</button>
    </div>`;
    };

    main.innerHTML = text;

    let btns = document.getElementsByTagName('button');

    for (const btn of btns) {

        btn.addEventListener('click', onClick);
    };

   

    function onClick(ev) {
        let unlocked = ev.target.parentNode.querySelector('input[value=unlock]');
        let hiddenEmail = ev.target.parentNode.querySelector('input[name=user1Email]');
        let hiddenAge = ev.target.parentNode.querySelector('input[name=user1Age]');
        let div = ev.target.parentNode.getElementsByTagName('div')[0];
        if (unlocked.checked) {
            if (ev.target.textContent == 'Show more') {
                hiddenEmail.style.display = 'block'
                div.style.display = 'block'
                hiddenAge.style.display = 'block'
                ev.target.textContent = 'Hide it'
            }else{
                hiddenEmail.style.display = 'none'
                hiddenAge.style.display = 'none'
                div.style.display = 'none'
                ev.target.textContent = 'Show more'
            }  
        }             
    }
};