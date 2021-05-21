const express = require('express');
const path = require('path');
const sql = require('mssql');
const dbConfig = require('../dbConfig');

const router = express.Router();

// Redirect to explore if authenticated
router.use((req, res, next) => {
    if (req.session.username) {
        return res.redirect('/app/explore');
    }
    next();
})

/* GET the SignIn page */
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
                return res.end();
            }

            var request = new sql.Request(pool);
            request.input('usrname', user);
            request.input('mdp', mdp);
            request.execute('connectUser', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    return res.end();
                }

                if (recordsets.returnValue == -1) {
                    res.statusCode = 404;
                    return res.end('Le nom d\'utilisateur n\'existe pas');
                }

                if (recordsets.returnValue == 0) {
                    res.statusCode = 401;
                    return res.end('Le nom d\'utilisateur ou le mot de passe sont incorrects');
                }

                var requestInfo = new sql.Request(pool);
                requestInfo.input('username', user);
                requestInfo.execute('getUserInfos', (err, recordsets) => {
                    if (err) {
                        console.log(err);
                        res.statusCode = 500;
                        return res.end();
                    }

                    if (recordsets.recordset.length === 0) {
                        res.statusCode = 404;
                        res.setHeader('Content-Type', 'text/plain');
                        return res.end('Utilisateur non trouvé');
                    }

                    req.session.username = user;
                    req.session.userid = recordsets.recordset[0].IdUtl;
                    req.session.userlastn = recordsets.recordset[0].prenomUtl;
                    
                    res.status(200).redirect('app/explore');
                });
            });
        })
    })

module.exports = router;