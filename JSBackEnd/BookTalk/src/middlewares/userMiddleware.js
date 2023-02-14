const jwt = require("../lib/jsonwebtoken");
const config = require('../config/initial');

exports.authentication = async (req, res, next) => {
    const token = req.cookies.user;

    if (token) {
        try {
            const decodedToken = await jwt.verify(token, config.SECRET);
            req.user = decodedToken;
            req.isAuthenticated = true;

            res.locals.user = decodedToken;
            res.locals.isAuthenticated = true;
        } catch (error) {
            res.clearCookie('user'); 
            res.redirect('/404');
        }
    }

    next()
}

exports.isAuthenticated = (req, res, next) => {
    if (!req.isAuthenticated ) {
        return res.redirect('/404');
    }

    next();
}

exports.isLoggedIn = (req, res, next) => {
    if (req.isAuthenticated) {
        return res.redirect('/');
    }

    next();
}