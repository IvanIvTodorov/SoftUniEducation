const router = require("express").Router();
const userMidd = require('../middlewares/userMiddleware');
const bookService = require('../services/bookService');


router.get("/catalog", async (req, res) => {
    const books = await bookService.getAll();

    res.render('catalog', { books })
});

router.get('/create', userMidd.isAuthenticated, (req, res) => {
    res.render('create');
});

router.post('/create', userMidd.isAuthenticated, async (req, res) => {
    const { title, author, genre, stars, imageUrl, bookReview } = req.body;
    try {
        const owner = req.user._id;
        await bookService.create(title, author, genre, stars, imageUrl, bookReview, owner)
        res.redirect('/catalog');
    } catch (error) {
        res.render('create', { title, author, genre, stars, imageUrl, bookReview, error });
    }
});

router.get("/details/:bookId", async (req, res) => {
    const bookId = req.params.bookId;
    const book = await bookService.getBookById(bookId);
    let isAuthor = false;
    let wished = false;

    if (req.user) {
        isAuthor = book.owner == req.user._id;
        wished = await bookService.isWished(bookId, req.user._id);
    }

    res.render('details', { book, isAuthor, wished })
});

router.get('/edit/:bookId', userMidd.isAuthenticated, async (req, res) => {
    const bookId = req.params.bookId;
    const book = await bookService.getBookById(bookId)

    res.render('edit', { book });
});

router.post('/edit/:bookId', userMidd.isAuthenticated, async (req, res) => {
    const { title, author, genre, stars, imageUrl, review } = req.body;
    const bookId = req.params.bookId;
    const book = await bookService.getBookById(bookId);
    try {
        await bookService.editBook(bookId, { title, author, genre, stars, imageUrl, review })
        res.redirect(`/details/${bookId}`);

    } catch (error) {
        res.render('edit', { book, error })
    }

});

router.get('/delete/:bookId', userMidd.isAuthenticated, async (req, res) => {
    const bookId = req.params.bookId;

    await bookService.deleteBook(bookId);

    res.redirect('/catalog');
});


router.get('/wish/:bookId', userMidd.isAuthenticated, async (req, res) => {
    const bookId = req.params.bookId;
    const userId = req.user._id;
    const book = await bookService.getBookById(bookId);

    await bookService.addToWish(bookId, userId);

    let isAuthor = false;
    let wished = false;

    if (req.user) {
        isAuthor = book.owner == req.user._id;
        wished = await bookService.isWished(bookId, req.user._id);
    }

    res.render('details', { book, isAuthor, wished })
})

module.exports = router;