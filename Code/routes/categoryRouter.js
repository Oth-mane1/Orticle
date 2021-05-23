const express = require('express');
const path = require('path');
const sql = require('mssql');
const dbConfig = require('../dbConfig');

const router = express.Router();

/* GET category page */
router.route('/')
    .get((req, res, next) => {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/html');
        res.sendFile(path.resolve('public', 'app', 'category.html'));
    });

/* GET each category page */
router.route('/:idcat')
    .get((req, res, next) => {
        const idcat = req.params.idcat;

        const pool = new sql.ConnectionPool(dbConfig)
        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }
            var request = new sql.Request(pool);
            request.input('id', idcat);
            request.input('max', 1);
            request.execute('getCategory', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    res.end();
                    return
                }
                
                let ispushed = false
                recordsets.recordsets[1].forEach(ort => {                    
                    ort.idee = new Array()
                });

                recordsets.recordsets[1].forEach(ort => {                    
                    recordsets.recordsets[2].forEach(idee => {
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

                const catInfos = {
                    title: recordsets.recordsets[0][0].nomCat,
                    orticle: recordsets.recordsets[1]
                }
                res.statusCode = 200;
                res.render('showCategory', { catInfos });
            });
        })
    });

module.exports = router;