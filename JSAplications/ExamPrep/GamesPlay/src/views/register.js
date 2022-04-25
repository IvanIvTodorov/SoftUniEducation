import { register } from '../api/data.js';
import { html } from '../lib.js';

const tamplate = (onSubmit) => html`
   <section id="register-page" class="content auth">
            <form @submit=${onSubmit} id="register">
                <div class="container">
                    <div class="brand-logo"></div>
                    <h1>Register</h1>
                    <label for="email">Email:</label>
                    <input type="email" id="email" name="email" placeholder="maria@email.com">

                    <label for="pass">Password:</label>
                    <input type="password" name="password" id="register-password">

                    <label for="con-pass">Confirm Password:</label>
                    <input type="password" name="confirm-password" id="confirm-password">

                    <input class="btn submit" type="submit" value="Register">

                    <p class="field">
                        <span>If you already have profile click <a href="/login">here</a></span>
                    </p>
                </div>
            </form>
        </section>
`;

export async function registerPage(ctx) {

    ctx.render(tamplate(onSubmit));

    async function onSubmit(ev) {
        ev.preventDefault();

        const formData = new FormData(ev.target);

        const email = formData.get('email').trim();
        const password = formData.get('password').trim();
        const rePass = formData.get('confirm-password').trim();

        if (email == '' || password == '') {
            return alert('All fields required!');
        };

        if (password != rePass) {
            return alert('Passwords should match!');
        };

        await register(email, password);

        ctx.updateNav();
        ctx.page.redirect('/');
    }
};