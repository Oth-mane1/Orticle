const express = require('express');
const path = require('path');
const sql = require('mssql');
const dbConfig = require('../dbConfig');

const router = express.Router();

/* GET users Orticle */
router.route('/orticle')
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

                if (recordsets.recordset.length === 0) {
                    res.statusCode = 404;
                    res.setHeader('Content-Type', 'text/plain');
                    res.end('Orticle non trouvé');
                    return
                }

                res.setHeader('Content-Type', 'application/json');
                res.send(recordsets.recordset)
                res.end();
            });
        })
    })

/* GET users Orticle */
router.route('/article')
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
                    res.end();
                    return
                }

                if (recordsets.recordset.length === 0) {
                    res.statusCode = 404;
                    res.setHeader('Content-Type', 'text/plain');
                    res.end('Article non trouvé');
                    return
                }

                res.setHeader('Content-Type', 'application/json');
                res.send(recordsets.recordset)
                res.end();
            });
        })
    })

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
        var user = req.body.user;
        var mail = req.body.mail;
        var mdp = req.body.mdp;

        // Check that the user who want to delete his account is the one who is connected
        if (username == user) {
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
                request.input('usrname', user);
                request.input('mail', mail);
                request.input('mdp', mdp);
                request.execute('updateUser', (err, recordsets) => {
                    if (err) {
                        console.log(err);
                        res.statusCode = 500;
                        res.end();
                        return
                    }

                    if (recordsets.returnValue == -1) {
                        res.statusCode = 409;
                        return res.end('Le nom d\'utilisateur existe déja');
                    }

                    req.session.username = user
                    req.session.userlastn = prenom

                    res.statusCode = 204;
                    res.setHeader('Content-Type', 'text/plain');
                    res.end(`Utilisateur ${username}! a bien été modifier.`);
                });
            })
        } else {
            res.statusCode = 401;
            res.setHeader('Content-Type', 'text/plain');
            res.end(`vous n'avez pas l'autorisation de modifier l'utilisateur ${username}!`);
        }
    })
    .delete((req, res, next) => {
        const parUsername = req.params.username;
        const sesUsername = req.session.username;
        const userid = req.session.userid;

        // Check that the user who want to delete his account is the one who is connected
        if (parUsername == sesUsername) {
            const pool = new sql.ConnectionPool(dbConfig)

            pool.connect(err => {
                if (err) {
                    console.log(err)
                    res.statusCode = 401;
                    return
                }
                var request = new sql.Request(pool);
                request.input('id', userid);
                request.execute('deleteUser', (err, recordsets) => {
                    if (err) {
                        console.log(err);
                        res.statusCode = 500;
                        res.end();
                        return
                    }

                    req.session.destroy();
                    res.statusCode = 204;
                    res.setHeader('Content-Type', 'text/plain');
                    res.end(`L'utilisateur ${sesUsername} a bien été supprimer!`);
                });
            })
        } else {
            res.statusCode = 401;
            res.setHeader('Content-Type', 'text/plain');
            res.end(`vous n'avez pas l'autorisation de supprimer l'utilisateur ${username}!`);
        }
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
        var userId = req.body.userId;
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

            var request = new sql.Request(pool);
            request.input('userId', userId);
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
        })
    })

module.exports = router;