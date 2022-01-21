function validate() {
    let value = document.getElementById('email');

    value.addEventListener('change', onChange);
    let pattern = /[a-z]+\@[a-z]+\.[a-z]+/;

    function onChange(ev) {
        if (pattern.test(ev.target.value)) {
            value.classList.remove('error');
        } else {
            value.classList.add('error');
        }
    }
}