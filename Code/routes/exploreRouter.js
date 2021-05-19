const express = require('express');
const path = require('path');
const router = express.Router();

router.route('/')
    .get((req, res, next) => {
        res.statusCode = 200;
        res.render('explore', { name: req.session.userlastn });
    });

module.exports = router;