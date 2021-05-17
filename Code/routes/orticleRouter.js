const express = require('express');
const path = require('path');
const sql = require('mssql');
const dbConfig = require('../dbConfig');

const router = express.Router();

/* GET orticle Page */
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
            request.execute('getUserOrticle', (err, recordsets) => {
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

                const userOrticle = {
                    orticle: recordsets.recordsets[0]
                }
                res.statusCode = 200;
                res.render('orticle', { userOrticle });
            });
        })
    })

/* GET add orticle Page */
router.route('/add')
    .get((req, res, next) => {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/html');
        res.sendFile(path.resolve('public', 'app', 'addOrticle.html'));
    })
    .post((req, res) => {
        const { title, source, shortSrc, category, idees } = req.body;
        const userid = req.session.userid;

        const pool = new sql.ConnectionPool(dbConfig)
        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }

            var request = new sql.Request(pool);
            request.input('IdCat', category);
            request.input('IdUtl', userid);
            request.input('sourceOrt', source);
            request.input('shortsrcOrt', shortSrc);
            request.input('titreOrt', title);
            request.execute('createOrticle', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    return res.end();
                }
                const idOrt = recordsets.returnValue;
                console.log(idOrt)
                console.log(idees)

                const table = new sql.Table('idee')
                table.create = false
                table.columns.add('IdOrt', sql.Int, { nullable: false })
                table.columns.add('titreIde', sql.NVarChar(255), { nullable: false })
                table.columns.add('corpsIde', sql.NVarChar(255), { nullable: false })
                idees.forEach(element => {
                    table.rows.add(idOrt, element[0], element[1])
                });

                var requestIdee = new sql.Request(pool);
                requestIdee.bulk(table, (err, recordsets) => {
                    if (err) {
                        console.log(err);
                        res.statusCode = 500;
                        return res.end();
                    }

                    res.statusCode = 201;
                    res.end(`Idees bien cree pour l'orticle ${idOrt}`);
                });
            });
        })
    })

/* GET orticle */
router.route('/:id')
    .get((req, res, next) => {
        const idOrt = req.params.id

        const pool = new sql.ConnectionPool(dbConfig)
        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }

            var request = new sql.Request(pool);
            request.input('id', idOrt);
            request.execute('getOrticle', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    return res.end();
                }

                const orticle = {
                    infos: recordsets.recordsets[0][0],
                    idee: recordsets.recordsets[1]
                }

                var requestSim = new sql.Request(pool);
                requestSim.input('id', orticle.infos.idCat);
                requestSim.input('max', 4);
                requestSim.execute('getCategory', (err, recordsets) => {
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

                    orticle.orticleSim = {
                        orticle: recordsets.recordsets[1]
                    }

                    res.statusCode = 200;
                    res.render('showOrticle', { orticle });
                });
            });
        })
    })

/* GET orticle by id */
router.route('/get/:id')
    .get((req, res, next) => {
        const idOrt = req.params.id

        const pool = new sql.ConnectionPool(dbConfig)
        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }

            var request = new sql.Request(pool);
            request.input('id', idOrt);
            request.execute('getOrticle', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    return res.end();
                }

                if (!recordsets.recordset[0]) {
                    res.statusCode = 404;
                    return res.end(`Orticle ${idOrt} introuvable`)
                }

                res.statusCode = 200;
                res.setHeader('Content-Type', 'application/json');
                res.json({
                    orticleInfos: recordsets.recordsets[0][0],
                    orticleIdee: recordsets.recordsets[1]
                });
            });
        })
    })


module.exports = router;