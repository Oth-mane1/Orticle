const createError = require('http-errors');
const express = require('express');
const session = require('express-session');
const fileStore = require('session-file-store')(session);
const path = require('path');
const cookieParser = require('cookie-parser');
const hbs = require('hbs');
const helpers = require('handlebars-helpers')('math');
const logger = require('morgan');

const landingRouter = require('./routes/landingRouter');
const appRouter = require('./routes/appRouter');

const app = express();

// Debug middleware for render | send
app.use((req, res, next) => {
    const render = res.render;
    const send = res.send;
    res.render = function renderWrapper(...args) {
        Error.captureStackTrace(this);
        return render.apply(this, args);
    };

    res.send = function sendWrapper(...args) {
        try {
            send.apply(this, args);
        } catch (err) {
            console.error(`Error in res.send | ${err.code} | ${err.message} | ${res.stack}`);
        }
    };
    next();
});

// view engine setup
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'hbs');

hbs.registerHelper(helpers)

app.use(logger('dev'));
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cookieParser());

// Serve static files
app.use('/styles', express.static(path.join(__dirname, 'public', 'styles')));
app.use('/scripts', express.static(path.join(__dirname, 'public', 'scripts')));
app.use('/images', express.static(path.join(__dirname, 'public', 'images')));

// Session setup
app.use(session({
    name: 'Orticle-Session',
    secret: 'orticle-secret-sesseion',
    saveUninitialized: false,
    resave: false,
    store: new fileStore({ logFn: () => { } })
}))

app.use('/', landingRouter);
app.use('/app', appRouter);

// catch 404 and forward to error handler
app.use((req, res, next) => {
    next(createError(404));
});

// error handler
app.use(async (err, req, res, next) => {
    // set locals, only providing error in development
    res.locals.message = err.message;
    res.locals.error = req.app.get('env') === 'development' ? err : {};

    // render the error page
    res.status(err.status || 500);
    return await res.render('error');
});

module.exports = app;
