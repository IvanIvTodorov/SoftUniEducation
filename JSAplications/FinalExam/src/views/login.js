import { login } from '../api/data.js';
import { html} from '../lib.js';

const tamplate = (onSubmit) => html`
  <section id="loginPage">
            <form @submit=${onSubmit} class="loginForm">
                <img src="./images/logo.png" alt="logo" />
                <h2>Login</h2>

                <div>
                    <label for="email">Email:</label>
                    <input id="email" name="email" type="text" placeholder="steven@abv.bg" value="">
                </div>

                <div>
                    <label for="password">Password:</label>
                    <input id="password" name="password" type="password" placeholder="********" value="">
                </div>

                <button class="btn" type="submit">Login</button>

                <p class="field">
                    <span>If you don't have profile click <a href="/register">here</a></span>
                </p>
            </form>
</section>
`;

export async function loginPage(ctx){

    ctx.render(tamplate(onSubmit));

    async function onSubmit(ev){
        ev.preventDefault();

        const formData = new FormData(ev.target);

        const email = formData.get('email').trim();
        const password = formData.get('password').trim();

        if (email == '' || password == '') {
           return alert('All fileds required !')
        }

        await login(email,password);
        
        ctx.updateNav();
        ctx.page.redirect('/catalog');
    }
};