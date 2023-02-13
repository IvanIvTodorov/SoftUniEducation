const router = require("express").Router();
const userService = require('../services/userService');

router.get('/login', (req, res) => {
    res.render("user/login");
});

router.post('/login', async(req, res) => {
    const {username, password} = req.body;

    try {
        const token = await userService.login(username,password);
        res.cookie('user', token, {httpOnly: true});
        res.redirect("/");
    } catch (error) {
        res.redirect('/404');
    }
});

router.get('/register', (req, res) => {
    res.render("user/register");
});

router.post('/register', async (req, res) => {
    const { username, password, repeatPassword} = req.body;

    if (password !== repeatPassword) {
        return res.redirect('/404');
    }

    const isExsisting = await userService.userIsExsiting(username);

    if (isExsisting) {
        return res.redirect('/404');
    }

    await userService.register(username,password);

    res.redirect('/login');
});


router.get("/logout", (req, res) => {
    res.clearCookie('user');

    res.redirect('/');
})

module.exports = router;