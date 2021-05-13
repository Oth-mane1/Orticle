const createError = require('http-errors');
const express = require('express');
const session = require('express-session');
const fileStore = require('session-file-store')(session);
const path = require('path');
const cookieParser = require('cookie-parser');
const logger = require('morgan');

const landingRouter = require('./routes/landingRouter');
const appRouter = require('./routes/appRouter');

const app = express();
app.use(session({
    name: 'Orticle-Session',
    secret: 'orticle-secret-sesseion',
    saveUninitialized: false,
    resave: false,
    store: new fileStore({logFn:()=>{}})
}))

// view engine setup
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'hbs');

app.use(logger('dev'));
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cookieParser());

// Serve static files
app.use('/styles', express.static(path.join(__dirname, 'public', 'styles')));
app.use('/scripts', express.static(path.join(__dirname, 'public', 'scripts')));
app.use('/images', express.static(path.join(__dirname, 'public', 'images')));

app.use('/', landingRouter);
app.use('/app', appRouter);

// catch 404 and forward to error handler
app.use((req, res, next) => {
    next(createError(404));
});

// error handler
app.use((err, req, res, next) => {
    // set locals, only providing error in development
    res.locals.message = err.message;
    res.locals.error = req.app.get('env') === 'development' ? err : {};

    // render the error page
    res.status(err.status || 500);
    res.render('error');
});

module.exports = app;
