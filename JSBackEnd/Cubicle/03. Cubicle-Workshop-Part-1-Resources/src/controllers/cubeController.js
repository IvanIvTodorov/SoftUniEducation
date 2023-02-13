const Cube = require('../models/Cube');
const Accessory = require('../models/Accessory');
const cubeService = require('../services/cubeService');


exports.getCreateCube = (req, res) => {
    res.render('cube/create');
}

exports.createCube = async (req, res) => {
    let { name, description, imageUrl, difficultyLevel } = req.body;

    let cube = new Cube({ 
        name, 
        description, 
        imageUrl, 
        difficultyLevel, 
        owner: req.user._id
    });

    await cube.save();

    res.redirect('/');
}

exports.getCubeDetails = async (req, res) => {
    const cube = await Cube.findById(req.params.cubeId).populate('accessories').lean();

    if (!cube) {
        return res.redirect('/404')
    }

    const isOwner = cube.owner == req.user._id;

    res.render('cube/details', { cube, isOwner });
}

exports.attachCubeAccesssory = async (req, res) => {
    const cube = await Cube.findById(req.params.cubeId).lean();
    const accessory = await Accessory.find({ _id: { $nin: cube.accessories } }).lean();
    console.log(accessory);

    res.render('cube/attach', { cube, accessory });
}

exports.postAttachCubeAccesssory = async (req, res) => {
    const cube = await Cube.findById(req.params.cubeId);
    const accessoryId = req.body.accessory;

    cube.accessories.push(accessoryId);

    cube.save();
 
    res.redirect(`/cubes/${cube._id}/details`);
}


exports.editCube = async (req, res) => {
    const cube = await cubeService.getCube(req.params.cubeId).lean();

    const level1 = Boolean(cube.difficultyLevel == 1);
    const level2 = Boolean(cube.difficultyLevel == 2);
    const level3 = Boolean(cube.difficultyLevel == 3);
    const level4 = Boolean(cube.difficultyLevel == 4);
    const level5 = Boolean(cube.difficultyLevel == 5);
    const level6 = Boolean(cube.difficultyLevel == 6);

    res.render("cube/edit", {cube, level1, level2, level3, level4, level5, level6});   
};

exports.postEditCube = async (req,res) => {
    let { name, description, imageUrl, difficultyLevel } = req.body;

    await cubeService.updateCube(req.params.cubeId, {name, description, imageUrl, difficultyLevel});

    res.redirect(`/cubes/${req.params.cubeId}/details`);
}

exports.deleteCube = async (req, res) => {
    const cube = await cubeService.getCube(req.params.cubeId).lean();

    const level1 = Boolean(cube.difficultyLevel == 1);
    const level2 = Boolean(cube.difficultyLevel == 2);
    const level3 = Boolean(cube.difficultyLevel == 3);
    const level4 = Boolean(cube.difficultyLevel == 4);
    const level5 = Boolean(cube.difficultyLevel == 5);
    const level6 = Boolean(cube.difficultyLevel == 6);
    
    res.render("cube/delete", {cube,level1, level2, level3, level4, level5, level6})
};

exports.postDeleteCube = async (req, res) => {

    await cubeService.deleteCube(req.params.cubeId);
        
    res.redirect('/');
}