const router = require('express').Router();

const homeController = require('./controllers/homeController');
const userController = require("./controllers/userController");
const {isAuthenticated} = require("./middlewares/userMiddleware");

router.use('/', userController);

router.get('/', homeController.getHomePage);
router.get('/about', homeController.getAboutPage);
router.get('/404', homeController.getErrorPage);


// router.get('/cubes/create', isAuthenticated, cubeController.getCreateCube);
// router.post('/cubes/create', isAuthenticated, cubeController.createCube);
// router.get('/cubes/:cubeId/details', cubeController.getCubeDetails);
// router.get('/cubes/:cubeId/attach', isAuthenticated, cubeController.attachCubeAccesssory);
// router.post('/cubes/:cubeId/attach', isAuthenticated, cubeController.postAttachCubeAccesssory);
// router.get('/cubes/:cubeId/edit', isAuthenticated, cubeController.editCube);
// router.get('/cubes/:cubeId/delete', isAuthenticated, cubeController.deleteCube);
// router.post('/cubes/:cubeId/edit', isAuthenticated, cubeController.postEditCube);
// router.post('/cubes/:cubeId/delete', isAuthenticated, cubeController.postDeleteCube);


// router.use('/accessories', accessoryController); 


module.exports = router;