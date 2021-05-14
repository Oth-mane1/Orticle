const express = require('express');
const path = require('path');
const sql = require('mssql');
const dbConfig = require('../dbConfig');

const router = express.Router();

/* GET users */
router.route('/:username')
    .get((req, res, next) => {
        var username = req.params.username;
        const pool = new sql.ConnectionPool(dbConfig)

        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }
            var request = new sql.Request(pool);
            request.input('username', username);
            request.execute('getUserInfos', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    res.end();
                    return
                }

                if (recordsets.recordset.length === 0) {
                    res.statusCode = 404;
                    res.setHeader('Content-Type', 'text/plain');
                    res.end('Utilisateur non trouvé');
                    return
                }

                res.setHeader('Content-Type', 'application/json');
                res.send(recordsets.recordset[0])
                res.end();
            });
        })
    })
    .put((req, res, next) => {
        var username = req.params.username;
        var userId = req.body.userId;
        var nom = req.body.nom;
        var prenom = req.body.prenom;
        var mail = req.body.mail;
        var mdp = req.body.mdp;

        const pool = new sql.ConnectionPool(dbConfig)

        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }
            var request = new sql.Request(pool);
            request.input('usrID', userId);
            request.input('nom', nom);
            request.input('prenom', prenom);
            request.input('usrname', username);
            request.input('mail', mail);
            request.input('mdp', mdp);
            request.execute('updateUser', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    res.end();
                    return
                }

                res.statusCode = 204;
                res.setHeader('Content-Type', 'text/plain');
                res.end(`Utilisateur ${username}! a bien été modifier.`);
            });
        })
    })

/* GET users favorite Category */
router.route('/:username/categories')
    .get((req, res, next) => {
        var username = req.params.username;
        const pool = new sql.ConnectionPool(dbConfig)

        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }

            var requestId = new sql.Request(pool);
            requestId.input('username', username);
            requestId.execute('getUserInfos', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    res.end();
                    return
                }

                if (recordsets.recordset.length === 0) {
                    res.statusCode = 404;
                    res.setHeader('Content-Type', 'text/plain');
                    res.end('LUtilisateur non trouvé');
                    return
                }

                var userId = recordsets.recordset[0].IdUtl

                var request = new sql.Request(pool);
                request.input('id', userId);
                request.execute('getUserFav', (err, recordsets) => {
                    if (err) {
                        console.log(err);
                        res.statusCode = 500;
                        res.end();
                        return
                    }

                    if (recordsets.recordset.length === 0) {
                        res.statusCode = 404;
                        res.setHeader('Content-Type', 'text/plain');
                        res.end('L\'utilisateur n\'a pas de catégorie préférée ');
                        return
                    }

                    res.statusCode = 200;
                    res.setHeader('Content-Type', 'application/json');
                    res.send(recordsets.recordset)
                    res.end();
                });
            });


        })
    })
    .post((req, res, next) => {
        var username = req.params.username;
        var cat1 = req.body.cat1;
        var cat2 = req.body.cat2;
        var cat3 = req.body.cat3;
        
        const pool = new sql.ConnectionPool(dbConfig)

        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }

            var requestId = new sql.Request(pool);
            requestId.input('username', username);
            requestId.execute('getUserInfos', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    res.end();
                    return
                }

                if (recordsets.recordset.length === 0) {
                    res.statusCode = 404;
                    res.setHeader('Content-Type', 'text/plain');
                    res.end('Utilisateur non trouvé');
                    return
                }

                var userID = recordsets.recordset[0].IdUtl
                var request = new sql.Request(pool);
                request.input('userId', userID);
                request.input('cat1', cat1);
                request.input('cat2', cat2);
                request.input('cat3', cat3);
                request.execute('createUserFav', (err, recordsets) => {
                    if (err) {
                        console.log(err);
                        res.statusCode = 500;
                        res.end();
                        return
                    }

                    res.statusCode = 201;
                    res.setHeader('Content-Type', 'text/plain');
                    res.end(`Utilisateur ${username}! a bien ajouter ses catégories.`);
                });
            });

        })
    })
    .put((req, res, next) => {
        var username = req.params.username;
        var cat1 = req.body.cat1;
        var cat2 = req.body.cat2;
        var cat3 = req.body.cat3;

        const pool = new sql.ConnectionPool(dbConfig)

        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }

            var requestId = new sql.Request(pool);
            requestId.input('username', username);
            requestId.execute('getUserInfos', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    res.end();
                    return
                }

                if (recordsets.recordset.length === 0) {
                    res.statusCode = 404;
                    res.setHeader('Content-Type', 'text/plain');
                    res.end('Utilisateur non trouvé');
                    return
                }

                var userID = recordsets.recordset[0].IdUtl
                var request = new sql.Request(pool);
                request.input('userId', userID);
                request.input('cat1', cat1);
                request.input('cat2', cat2);
                request.input('cat3', cat3);
                request.execute('updateUserFav', (err, recordsets) => {
                    if (err) {
                        console.log(err);
                        res.statusCode = 500;
                        res.end();
                        return
                    }

                    res.statusCode = 201;
                    res.setHeader('Content-Type', 'text/plain');
                    res.end(`Utilisateur ${username}! a bien modifier ses catégories.`);
                });
            });

        })
    })

module.exports = router;