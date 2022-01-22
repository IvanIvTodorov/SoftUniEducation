function lockedProfile() {
    let profiles = Array.from(document.getElementsByClassName('profile'));
    console.log(profiles);
    for (const profile of profiles) {

        profile.lastElementChild.addEventListener('click', onClick);
    }

    function onClick(ev) {
        let parent = ev.target.parentNode;  
        let unlocked = parent.children[4];
        let hidden = parent.children[9];

        if (unlocked.checked) {
            if (ev.target.textContent == 'Show more') {
                hidden.style.display = 'block';
                ev.target.textContent = 'Hide it'
            }else{
                hidden.style.display = 'none';
                ev.target.textContent = 'Show more'
            }  
        }             
    }
}