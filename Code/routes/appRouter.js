const express = require('express');
const exploreRouter = require('./exploreRouter');
const userRouter = require('./userRouter');
const orticleRouter = require('./orticleRouter');
const accountRouter = require('./accountRouter');
const router = express.Router();

// If user not authenticated redirect to signIn
router.use((req, res, next) => {
    if (!req.session.username) {
        res.statusCode = 401;
        return res.redirect('/signIn');
    }
    next()
})

// Set-up explore as the root of the app
router.route('/').get((req, res) => {
    res.redirect('/app/explore');
})

router.use('/explore', exploreRouter);
router.use('/orticle', orticleRouter);
router.use('/user', userRouter);
router.use('/account', accountRouter);

module.exports = router;
