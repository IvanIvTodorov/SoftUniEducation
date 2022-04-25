import { register } from '../api/data.js';
import { html } from '../lib.js';

const tamplate = (onSubmit) => html`
    <section id="registerPage">
            <form @submit=${onSubmit} class="registerForm">
                <img src="./images/logo.png" alt="logo" />
                <h2>Register</h2>
                <div class="on-dark">
                    <label for="email">Email:</label>
                    <input id="email" name="email" type="text" placeholder="steven@abv.bg" value="">
                </div>

                <div class="on-dark">
                    <label for="password">Password:</label>
                    <input id="password" name="password" type="password" placeholder="********" value="">
                </div>

                <div class="on-dark">
                    <label for="repeatPassword">Repeat Password:</label>
                    <input id="repeatPassword" name="repeatPassword" type="password" placeholder="********" value="">
                </div>

                <button class="btn" type="submit">Register</button>

                <p class="field">
                    <span>If you have profile click <a href="/login">here</a></span>
                </p>
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
        const rePass = formData.get('repeatPassword').trim();

        if (email == '' || password == '') {
            return alert('All fields required!');
        };

        if (password != rePass) {
            return alert('Passwords should match!');
        };

        await register(email, password);

        ctx.updateNav();
        ctx.page.redirect('/catalog');
    }
};