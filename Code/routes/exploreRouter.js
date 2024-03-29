const express = require('express');
const path = require('path');
const sql = require('mssql');
const hbs = require('hbs');
const dbConfig = require('../dbConfig');

const router = express.Router();

/* GET explore page */
router.route('/')
    .get((req, res, next) => {
        const userid = req.session.userid;
        const name = req.session.userlastn;

        const pool = new sql.ConnectionPool(dbConfig)
        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                res.end();
                return
            }

            var requestOrticle = new sql.Request(pool);
            requestOrticle.execute('getDayOrticle', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    res.end();
                    return
                }

                let ispushed = false
                recordsets.recordsets[0].forEach(ort => {
                    ort.idee = new Array()
                });

                recordsets.recordsets[0].forEach(ort => {
                    recordsets.recordsets[1].forEach(idee => {
                        if (idee.IdOrt === ort.IdOrt) {
                            ort.idee.push(idee)
                            ispushed = true
                        }
                        else {
                            if (ispushed) {
                                return
                            }
                            ispushed = false
                        }
                    });
                });

                const dayOrticle = {
                    orticle: recordsets.recordsets[0][0]
                }

                var requestArticle = new sql.Request(pool);
                requestArticle.execute('getDayArticle', (err, recordsets) => {
                    if (err) {
                        console.log(err);
                        res.statusCode = 500;
                        res.end();
                        return
                    }

                    const dayArticle = {
                        article: recordsets.recordsets[0][0]
                    }

                    var requestRecommended = new sql.Request(pool);
                    requestRecommended.input('idUser', userid);
                    requestRecommended.input('min', 0);
                    requestRecommended.input('max', 6);
                    requestRecommended.execute('getUserExplore', (err, recordsets) => {
                        if (err) {
                            console.log(err);
                            res.statusCode = 500;
                            res.end();
                            return
                        }
                        let ispushed = false

                        recordsets.recordsets[0].forEach(ort => {
                            ort.idee = new Array()
                        });

                        recordsets.recordsets[0].forEach(ort => {
                            recordsets.recordsets[1].forEach(idee => {
                                if (idee.IdOrt === ort.IdOrt) {
                                    ort.idee.push(idee)
                                    ispushed = true
                                }
                                else {
                                    if (ispushed) {
                                        return
                                    }
                                    ispushed = false
                                }
                            });
                        });

                        const recOrticle = {
                            orticle: recordsets.recordsets[0]
                        }

                        var requestSuggest = new sql.Request(pool);
                        requestSuggest.input('offset', 0);
                        requestSuggest.input('count', 6);
                        requestSuggest.execute('getUserSuggest', (err, recordsets) => {
                            if (err) {
                                console.log(err);
                                res.statusCode = 500;
                                res.end();
                                return
                            }
                            let ispushed = false

                            recordsets.recordsets[0].forEach(ort => {
                                ort.idee = new Array()
                            });

                            recordsets.recordsets[0].forEach(ort => {
                                recordsets.recordsets[1].forEach(idee => {
                                    if (idee.IdOrt === ort.IdOrt) {
                                        ort.idee.push(idee)
                                        ispushed = true
                                    }
                                    else {
                                        if (ispushed) {
                                            return
                                        }
                                        ispushed = false
                                    }
                                });
                            });

                            const suggest = []
                            for (let i = 0; i < 2; i++) {
                                suggest.push([recordsets.recordsets[0][i], recordsets.recordsets[2][i]])
                            }

                            res.statusCode = 200;
                            res.render('explore', { name, dayOrticle, dayArticle, recOrticle, suggest });
                        })
                    })
                })
            });
        })
    });

/* GET more suggestion */
router.route('/suggest/:offset/:count')
    .get((req, res, next) => {
        const { offset, count } = req.params;

        const pool = new sql.ConnectionPool(dbConfig)
        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                res.end();
                return
            }

            var requestSuggest = new sql.Request(pool);
            requestSuggest.input('offset', offset);
            requestSuggest.input('count', count);
            requestSuggest.execute('getUserSuggest', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    res.end();
                    return
                }

                let ispushed = false
                if (!recordsets.rowsAffected[0] && !recordsets.rowsAffected[2]) {
                    res.statusCode = 404;
                    console.log('sala dak lhzaq')
                    res.setHeader('Content-Type', 'text/plain');
                    res.end('Le max du suggestion a été tenter.');
                    return
                }

                recordsets.recordsets[0].forEach(ort => {
                    ort.idee = new Array()
                });

                recordsets.recordsets[0].forEach(ort => {
                    recordsets.recordsets[1].forEach(idee => {
                        if (idee.IdOrt === ort.IdOrt) {
                            ort.idee.push(idee)
                            ispushed = true
                        }
                        else {
                            if (ispushed) {
                                return
                            }
                            ispushed = false
                        }
                    });
                });

                const suggest = []
                for (let i = 0; i < count; i++) {
                    suggest.push([recordsets.recordsets[0][i], recordsets.recordsets[2][i]])
                }

                res.render('suggest', { suggest }, (err, html) => {
                    if (err) {
                        console.log(err);
                        res.statusCode = 500;
                        return res.end();
                    }

                    res.statusCode = 200;
                    res.setHeader('Content-Type', 'text/html');
                    res.send(html);
                });
            })
        })
    });

module.exports = router;