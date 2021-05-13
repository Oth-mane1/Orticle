const express = require('express');
const router = express.Router();

router.route('/')
    .get((req, res, next) => {
        req.session.destroy(err => {
            if (err) {
                res.statusCode = 500;
                res.end();
                return
            }
            
            res.statusCode = 200;
            res.setHeader('Content-Type', 'text/html');
            res.redirect('/');
            res.end();
        })
    });

module.exports = router;