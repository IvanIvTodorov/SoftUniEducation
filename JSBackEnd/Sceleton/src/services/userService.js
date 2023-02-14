const User = require("../models/User");
const config = require("../config/initial");
const jwt = require("../lib/jsonwebtoken");

exports.register = (email, username, password) => User.create({ email, username, password });

exports.userIsExsiting = (username) => User.findOne({ username });

exports.login = async (username, password) => {
    const user = await this.userIsExsiting(username);

    if (!user) {
        throw "Invalid data!"
    };

    const isValid = await user.validatePassword(password);
    if (!isValid) {
        throw "Invalid data!"
    };

    const payload = { _id: user._id, username: user.username, email: user.email };

    const token = await jwt.sign(payload, config.SECRET, {expiresIn: '2h'});

    return token;
};