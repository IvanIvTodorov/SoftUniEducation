const router = require("express").Router();

router.get('/', async (req, res) => {
    res.render('home');
});

router.get('/404', async (req, res) => {
    res.render('404');
});

module.exports = router;
