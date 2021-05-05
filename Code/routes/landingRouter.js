var express = require('express');
var path = require('path');
var router = express.Router();

/* GET the index page */
router.get('/', (req, res, next) => {
    res.statusCode = 200;
    res.setHeader('Content-Type', 'text/html');
    res.sendFile(path.resolve('public', 'index.html'));
});

/* GET the download page */
router.get('/download', (req, res, next) => {
    res.statusCode = 200;
    res.setHeader('Content-Type', 'text/html');
    res.sendFile(path.resolve('public', 'download.html'));
});

/* GET the FAQ page */
router.get('/FAQ', (req, res, next) => {
    res.statusCode = 200;
    res.setHeader('Content-Type', 'text/html');
    res.sendFile(path.resolve('public', 'FAQ.html'));
});

/* GET the Termes and conditions page */
router.get('/conditions', (req, res, next) => {
    res.statusCode = 200;
    res.setHeader('Content-Type', 'text/html');
    res.sendFile(path.resolve('public', 'conditions.html'));
});

/* GET the support page */
router.route('/support')
    .all((req, res, next) => {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/html');;
        next();
    })
    .get((req, res, next) => {
        res.sendFile(path.resolve('public', 'support.html'));
    })
    .post((req, res, next) => {
        var nom = req.body.nom;
        var prenom = req.body.prenom;
        var mail = req.body.mail;
        var message = req.body.message;
        console.log(req.body)
        res.send('Thank you!');
    })

module.exports = router;
