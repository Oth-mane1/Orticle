const express = require('express');
const path = require('path');
const sql = require('mssql');
const dbConfig = require('../dbConfig');

const router = express.Router();

// Redirect to explore if authenticated
router.use((req, res, next) => {
    if (req.session.username) {        
        res.redirect('/app/explore');
        res.end();
    }
    else{
        next();
    }
})

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
                            
                res.statusCode = 200;
                req.session.username = user;
                res.redirect('app/explore');
                res.end();
            });
        })
    })

module.exports = router;