var express = require('express');
var path = require('path');
var sql = require('mssql');
var dbConfig = require('../dbConfig');

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
        next();
    })
    .get((req, res, next) => {
        res.setHeader('Content-Type', 'text/html');
        res.sendFile(path.resolve('public', 'support.html'));
    })
    .post((req, res, next) => {
        var nom = req.body.nom;
        var prenom = req.body.prenom;
        var mail = req.body.mail;
        var message = req.body.message;

        const pool = new sql.ConnectionPool(dbConfig)

        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }
            var request = new sql.Request(pool);
            request.input('nomSup', nom);
            request.input('prenomSup', prenom);
            request.input('emailSup', mail);
            request.input('msgSup', message);
            request.execute('createSupport', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    return
                }

                console.log(recordsets);
                res.statusCode = 201;
                res.setHeader('Content-Type', 'text/plain');
                res.end(`Merci ${prenom}! Votre message a bien été transferé.`);
            });
        })
    })

module.exports = router;
