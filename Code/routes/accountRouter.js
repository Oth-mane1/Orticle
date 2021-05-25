const express = require('express');
const path = require('path');
const sql = require('mssql');
const dbConfig = require('../dbConfig');

const router = express.Router();

router.route('/')
    .get((req, res, next) => {
        const { username, userid } = req.session;

        var userInfos
        var orticle = { count: 0 }
        var article = { count: 0 }

        const pool = new sql.ConnectionPool(dbConfig)
        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }
            var reqInfos = new sql.Request(pool);
            reqInfos.input('username', username);
            reqInfos.execute('getUserInfos', (err, recordsets) => {
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
                userInfos = {
                    IdUtl: recordsets.recordset[0].IdUtl,
                    nom: recordsets.recordset[0].nomUtl,
                    prenom: recordsets.recordset[0].prenomUtl,
                    username: recordsets.recordset[0].usernUtl,
                    email: recordsets.recordset[0].emailUtl,
                    mdp: recordsets.recordset[0].mdpUtl
                }

                var reqCount = new sql.Request(pool);
                reqCount.query(`SELECT count(*) AS 'OrticleCount' FROM Orticle WHERE idUtl = ${userid}`, (err, recordsets) => {
                    if (err) {
                        console.log(err);
                        res.statusCode = 500;
                        res.end();
                        return
                    }
                    orticle.count = recordsets.recordset[0].OrticleCount;

                    var reqCount = new sql.Request(pool);
                    reqCount.query(`SELECT count(*) AS 'ArticleCount' FROM Article WHERE idUtl = ${userid}`, (err, recordsets) => {
                        if (err) {
                            console.log(err);
                            res.statusCode = 500;
                            res.end();
                            return
                        }

                        article.count = recordsets.recordset[0].ArticleCount;
                        res.statusCode = 200;
                        res.render('account', { user: userInfos, orticle, article });
                    });
                });
            });
        });
    });

module.exports = router;