const Book = require('../models/Book');

exports.getAll = async () => {
    const books = await Book.find().lean();

    return books;
};

exports.create = async (title, author, genre, stars, imageUrl, bookReview, owner) => {
    let book = new Book({
        title,
        author,
        imageUrl,
        bookReview,
        genre,
        stars,
        owner
    });

    await book.save();
}

exports.getBookById = async (bookId) => {
    const book = Book.findById(bookId).lean();

    return book;
};

exports.editBook = async (bookId, data) => Book.findByIdAndUpdate(bookId, data, {runValidators: true});

exports.deleteBook = async (bookId) => Book.findByIdAndDelete(bookId);

exports.addToWish = async (bookId, userId) => {

    const book = await Book.findById(bookId);
    
    book.wishingList.push(userId);

    await book.save();
}

exports.isWished = async (bookId, userId) => {
    

    let isWished = await Book.findById(bookId).find({wishingList: {$in: userId}}).lean();

    return isWished;
}

exports.wishList = async (userId) => {
    const wishList = await Book.find().where({wishingList: {$in: userId}}).lean();

    return wishList;
}