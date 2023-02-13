const express = require('express');
const config = require('./config/initial');
const routes = require('./routes');
const userMiddleware = require('./middlewares/userMiddleware');
const cookieParser = require('cookie-parser');

const initDb = require('./config/databaseConfig'); 
const viewEngine = require('./config/viewEngine');

const app = express();
viewEngine(app);

app.use(express.static('src/public'));
app.use(cookieParser());
app.use(express.urlencoded({extended: false})); 
app.use(userMiddleware.authentication);
app.use(routes);
  
initDb()
 .then(() => app.listen(config.PORT, () => console.log(`Server is running on port ${config.PORT}... `)))
 .catch((err) => console.error(err.message));