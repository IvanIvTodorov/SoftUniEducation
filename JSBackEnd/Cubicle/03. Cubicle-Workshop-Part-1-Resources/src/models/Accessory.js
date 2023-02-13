const mongoose = require('mongoose');

const Schema = mongoose.Schema;

const accessory = new Schema({
    name: {
        type: String,
        required: true,
    },
    imageUrl: {
        type: String,
        required: true,
    },
    description: {
        type: String,
        required: true,
        maxLength: 50
    }
});

const Accessory = mongoose.model('Accessory', accessory);

module.exports = Accessory;