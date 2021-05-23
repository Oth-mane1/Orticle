const express = require('express');
const path = require('path');
const sql = require('mssql');
const Mercury = require('@postlight/mercury-parser');
const dbConfig = require('../dbConfig');

const router = express.Router();

/* GET article Page */
router.route('/')
    .get((req, res, next) => {
        const userid = req.session.userid;

        const pool = new sql.ConnectionPool(dbConfig)
        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }

            var request = new sql.Request(pool);
            request.input('id', userid);
            request.execute('getUserArticle', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    return res.end();
                }

                const userArticle = {
                    article: recordsets.recordset
                }

                res.statusCode = 200;
                res.render('article', { userArticle });
            });
        })
    })

/* GET add article Page */
router.route('/add')
    .get((req, res, next) => {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/html');
        res.sendFile(path.resolve('public', 'app', 'addArticle.html'));
    })
    .post((req, res) => {
        const { title, source, shortSrc, extrait } = req.body;
        const userid = req.session.userid;

        const pool = new sql.ConnectionPool(dbConfig)
        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }

            var request = new sql.Request(pool);
            request.input('IdUtl', userid);
            request.input('sourceArt', source);
            request.input('shortsrcArt', shortSrc);
            request.input('titreArt', title);
            request.input('extraitArt', extrait);
            request.execute('createArticle', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    return res.end();
                }

                res.statusCode = 201;
                res.end('l\'Article a bien ete creer')
            });
        })
    })

/* GET article Content */
router.route('/getContent')
    .post((req, res, next) => {
        const { link } = req.body;
        Mercury.parse(link, { contentType: 'text' }).then((result) => {
            res.statusCode = 200;
            res.json(JSON.stringify(
                {
                    title: result.title,
                    content: result.content,
                    url: result.url,
                    domain: result.domain
                }
            ))
        })
    })

/* GET article by id */
router.route('/get/:id')
    .get((req, res, next) => {
        const idArt = req.params.id

        const pool = new sql.ConnectionPool(dbConfig)
        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }

            var request = new sql.Request(pool);
            request.input('id', idArt);
            request.execute('getArticle', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    return res.end();
                }

                if (!recordsets.recordset[0]) {
                    res.statusCode = 404;
                    return res.end(`Article ${idArt} introuvable`)
                }

                res.statusCode = 200;
                res.setHeader('Content-Type', 'application/json');
                res.json(recordsets.recordset[0]);
            });
        })
    })

/* DELETE article by id */
router.route('/delete/:id')
    .delete((req, res, next) => {
        const idArt = req.params.id

        const pool = new sql.ConnectionPool(dbConfig)
        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }

            var request = new sql.Request(pool);
            request.input('id', idArt);
            request.execute('deleteArticle', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    return res.end();
                }

                if (!recordsets.rowsAffected[0]) {
                    res.statusCode = 404;
                    return res.end(`Article ${idArt} introuvable`)
                }

                res.statusCode = 204;
                res.setHeader('Content-Type', 'text/plain');
                res.end(`Article ${idArt} a bien été supprimer.`);
            });
        })
    })

module.exports = router;