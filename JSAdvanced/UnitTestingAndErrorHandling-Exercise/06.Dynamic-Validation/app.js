function validate() {
    let inputField = document.getElementById('email');
    inputField.addEventListener('change', onChange);
    let regex = /[a-z]+\@[a-z]+\.[a-z]+/;

    function onChange() {
        if (!regex.test(inputField.value)) {
            inputField.classList.add('error');
        }else{
            inputField.classList.remove('error');
        }
    }
}