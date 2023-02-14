const router = require("express").Router();
const userService = require('../services/userService');
const bookService = require('../services/bookService');

const userMidd = require('../middlewares/userMiddleware');


router.get('/login',userMidd.isLoggedIn, (req, res) => {
    res.render("user/login");
});

router.post('/login',userMidd.isLoggedIn, async (req, res) => {
    const { email, password } = req.body;

    try {
        const token = await userService.login(email, password);
        res.cookie('user', token, { httpOnly: true });
        res.redirect("/");
    } catch (error) {
        res.render('user/login', {error});
    }
});

router.get('/register',userMidd.isLoggedIn, (req, res) => {
    res.render("user/register");
});

router.post('/register',userMidd.isLoggedIn, async (req, res) => {
    const { email, username, password, repeatPassword } = req.body;

    try {
        const token = await userService.register(email, username, password, repeatPassword);
        res.cookie('user', token, { httpOnly: true });
        res.redirect("/");

    } catch (error) {
        res.render('user/register', {error});
    }

});


router.get("/logout", userMidd.isAuthenticated, (req, res) => {
    res.clearCookie('user');

    res.redirect('/');
})

router.get("/profile", userMidd.isAuthenticated, async (req, res ) => {
    const userId = req.user._id;
    const wishList = await bookService.wishList(userId);

    res.render("profile", {wishList});
})

module.exports = router;