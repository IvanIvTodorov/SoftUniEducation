const User = require("../models/User");
const config = require("../config/initial");
const jwt = require("../lib/jsonwebtoken");
const bcrypt = require('bcrypt');

exports.register = async (email, username, password, repeatPassword) => {
    if (password !== repeatPassword) {
        throw new Error('Password missmatch!');
    };

    const exsisting = await this.userIsExsiting(email);

    if (exsisting) {
        throw new Error('User with such email alredy exist!');
    }

    const securePass = await bcrypt.hash(password, 10);

    await User.create({ username, email, password: securePass });

    return this.login(email, password); 
} 

exports.userIsExsiting = (email) => User.findOne({ email });

exports.login = async (email, password) => {
    const user = await this.userIsExsiting(email);

    if (!user) {
        throw new Error("Invalid data!");
    };

    const isValid = await bcrypt.compare(password, user.password);

    if (!isValid) {
        throw new Error("Invalid data!");

    };

    const payload = { _id: user._id, username: user.username, email: user.email };

    const token = await jwt.sign(payload, config.SECRET);

    return token;
};