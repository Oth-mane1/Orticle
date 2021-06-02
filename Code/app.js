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

// view engine setup
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'hbs');

// Register switch helper
hbs.registerHelper('switch', function (value, options) {
    this.switch_value = value;
    return options.fn(this);
});

hbs.registerHelper('case', function (value, options) {
    if (value == this.switch_value) {
        return options.fn(this);
    }
});

// Register helpers
hbs.registerHelper(helpers)

app.use(logger('dev'));
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cookieParser());

// Serve static files
app.use('/styles', express.static(path.join(__dirname, 'public', 'styles')));
app.use('/scripts', express.static(path.join(__dirname, 'public', 'scripts')));
app.use('/images', express.static(path.join(__dirname, 'public', 'images')));
app.use('/icons', express.static(path.join(__dirname, 'icons')));
app.use('/manifest.json', express.static(path.join(__dirname, 'manifest.json')));
app.use('/pwa.js', express.static(path.join(__dirname, 'pwa.js')));
app.use('/service-worker.js', express.static(path.join(__dirname, 'service-worker.js')));

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
