const express = require('express');
const path = require('path');
const router = express.Router();

router.route('/')
    .get((req, res, next) => {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/html');
        res.sendFile(path.resolve('public', 'app', 'explore.html'));
    });

module.exports = router;