import { register } from '../api/data.js';
import { html } from '../lib.js';

const tamplate = (onSubmit) => html`
    <section id="registerPage">
            <form @submit=${onSubmit}>
                <fieldset>
                    <legend>Register</legend>

                    <label for="email" class="vhide">Email</label>
                    <input id="email" class="email" name="email" type="text" placeholder="Email">

                    <label for="password" class="vhide">Password</label>
                    <input id="password" class="password" name="password" type="password" placeholder="Password">

                    <label for="conf-pass" class="vhide">Confirm Password:</label>
                    <input id="conf-pass" class="conf-pass" name="conf-pass" type="password"
                        placeholder="Confirm Password">

                    <button type="submit" class="register">Register</button>

                    <p class="field">
                        <span>If you already have profile click <a href="/login">here</a></span>
                    </p>
                </fieldset>
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
        const rePass = formData.get('conf-pass').trim();

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