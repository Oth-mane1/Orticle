const express = require('express');
const exploreRouter = require('./exploreRouter');
const userRouter = require('./userRouter');
const router = express.Router();

router.use('/explore', exploreRouter);
router.use('/user', userRouter);

module.exports = router;
