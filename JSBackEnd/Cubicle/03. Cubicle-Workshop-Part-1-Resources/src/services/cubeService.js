const Cube = require('../models/Cube');

exports.getCube = (cubeId) => Cube.findById(cubeId);

exports.updateCube = (cubeId, data) => Cube.findByIdAndUpdate(cubeId, data, {runValidators: true});

exports.deleteCube = (cubeId) => Cube.findByIdAndDelete(cubeId);