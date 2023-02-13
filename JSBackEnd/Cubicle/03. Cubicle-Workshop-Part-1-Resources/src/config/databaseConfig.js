const mongoose = require('mongoose');
const initial = require('./initial');

const url = initial.DB_URI;

async function initDatabase(){
    mongoose.set('strictQuery', false);
    await mongoose.connect(url);
    console.log('Db connected');
};

module.exports = initDatabase;