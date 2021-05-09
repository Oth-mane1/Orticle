const express = require('express');
const path = require('path');
const router = express.Router();
const sql = require('mssql');
const dbConfig = require('../dbConfig');

/* GET the SignUp page */
router.route('/')
    .get((req, res, next) => {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/html');
        res.sendFile(path.resolve('public', 'signIn.html'));
    })
    .post((req, res, next) => {
        var user = req.body.user;
        var mdp = req.body.mdp;

        const pool = new sql.ConnectionPool(dbConfig)
        pool.connect(err => {
            if (err) {
                console.log(err)
                res.statusCode = 401;
                return
            }

            var request = new sql.Request(pool);
            request.input('usrname', user);
            request.input('mdp', mdp);
            request.execute('connectUser', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    res.end();
                    return
                }

                if (recordsets.returnValue == -1) {
                    res.statusCode = 404;
                    res.end('Le nom d\'utilisateur n\'existe pas');
                    return
                }

                if (recordsets.returnValue == 0) {
                    res.statusCode = 401;
                    res.end('Le nom d\'utilisateur ou le mot de passe sont incorrects');
                    return
                }
                //TODO: sesseion
                res.statusCode = 200;
                res.setHeader('Content-Type', 'text/plain');
                // res.send(`Welcome ${user}!`);
                res.sendFile(path.resolve('public', 'app', 'explore.html'))
                res.end();
            });
        })
    })

module.exports = router;