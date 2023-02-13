const mongoose = require('mongoose');

const Schema = mongoose.Schema;

const cubeSchema = new Schema({
    name: {
        type: String,
        required: true,
    },
    description: {
        type: String,
        required: true,
        maxLength: 50
    },
    imageUrl: {
         type: String,
         required: true,
    },
    difficultyLevel: {
        type: Number,
        required: true,
        max: 6,
        min: 1 
    },
    accessories: [{
        type: mongoose.Types.ObjectId,
        ref: 'Accessory',
    }],
    owner: {
        type: mongoose.Types.ObjectId,
        ref: 'User',
    }
});

const Cube = mongoose.model('Cube', cubeSchema);

module.exports = Cube