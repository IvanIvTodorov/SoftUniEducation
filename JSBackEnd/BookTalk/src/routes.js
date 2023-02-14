const router = require('express').Router();

const homeController = require('./controllers/homeController');
const userController = require("./controllers/userController");
const bookController = require("./controllers/bookController");

router.use(homeController);
router.use(userController);
router.use(bookController);

module.exports = router;