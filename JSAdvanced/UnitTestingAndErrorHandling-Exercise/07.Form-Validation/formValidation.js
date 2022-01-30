function validate() {
    let username = document.getElementById('username');
    let email = document.getElementById('email');
    let password = document.getElementById('password');
    let rePassword = document.getElementById('confirm-password');
    let btn = document.getElementById('company');
    let companyInfo = document.getElementById('companyInfo');
    let companyNumber = document.getElementById('companyNumber');
    let submit = document.getElementById('submit');
    let div = document.getElementById('valid');
    let arr = [username, email, password, rePassword, btn, companyNumber];
    submit.addEventListener('click', changed);

    const usernameValidation = /^[a-zA-Z0-9]{3,20}$/;
    const emailValidation = /^[^@.]+@[^@]*\.[^@]*$/;
    const passwordValidation = /^\w{5,15}$/;
    const companyNumberValidation = /^[0-9]{4}$/;

    function changed(ev) {
        ev.preventDefault();
        let flag = true;
        if (usernameValidation.test(username.value)) {
            username.style.borderColor = 'none';
        } else {
            username.style.borderColor = 'red';
            flag = false;
        };

        if (emailValidation.test(email.value)) {
            email.style.borderColor = 'none';
        } else {
            email.style.borderColor = 'red';
            flag = false;
        };

        if (passwordValidation.test(password.value)) {
            password.style.borderColor = 'none';

        } else {
            password.style.borderColor = 'red';
            flag = false;
        };

        if (passwordValidation.test(rePassword.value)) {
            rePassword.style.borderColor = 'none';
        } else {
            rePassword.style.borderColor = 'red';
            flag = false;
        };

        if (btn.checked) {
            if (companyNumberValidation.test(companyNumber.value)) {
                companyNumber.style.borderColor = 'none';
            } else {
                companyNumber.style.borderColor = 'red';
                flag = false;
            };
        };

        if (rePassword.value != password.value) {
            rePassword.style.borderColor = 'red';
            password.style.borderColor = 'red';
            flag = false;
        }

        if (flag) {
            div.style.display = 'block';
        } else {
            div.style.display = 'none';
        }
    }
    btn.addEventListener('change', onChange);

    function onChange() {

        if (btn.checked) {
            companyInfo.style.display = 'block';
        } else {
            companyInfo.style.display = 'none';
        }
    }
}
