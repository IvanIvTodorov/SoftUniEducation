const mongoose = require('mongoose');
const User = require('./User');

const booksSchema = new mongoose.Schema({
    title: {
        type: String,
        required: true,
        minLength: 2,
    },
    author: {
        type: String,
        required: true,
        minLength: 5,
    },
    imageUrl: {
        type: String,
        required: true,
    },
    bookReview: {
        type: String,
        required: true,
        minLength: 10,
    },
    genre: {
        type: String,
        required: true,
        minLength: 3
    },
    stars: {
        type: Number,
        required: true,
        min: 1,
        max: 5
    },
    wishingList: [{
        type: mongoose.Types.ObjectId, 
        ref: "User"
    }],
    owner: {
        type: mongoose.Types.ObjectId,  
        ref: "User"
    }
})

const Book = mongoose.model('Book', booksSchema);

module.exports = Book;