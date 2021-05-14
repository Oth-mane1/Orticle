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
        res.sendFile(path.resolve('public', 'signUp.html'));
    })
    .post((req, res, next) => {
        var nom = req.body.nom;
        var prenom = req.body.prenom;
        var user = req.body.user;
        var mail = req.body.mail;
        var mdp = req.body.mdp;

        const pool = new sql.ConnectionPool(dbConfig)

        pool.connect(err => {
            if (err) {
                console.log(err)
                return res.statusCode = 401;                
            }
            var request = new sql.Request(pool);
            request.input('nom', nom);
            request.input('prenom', prenom);
            request.input('usrname', user);
            request.input('mail', mail);
            request.input('mdp', mdp);
            request.execute('createUser', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    return res.end();                    
                }

                if (recordsets.returnValue == -1) {
                    res.statusCode = 409;
                    return res.end('Le nom d\'utilisateur existe déja');                    
                }

                console.log(recordsets);
                res.statusCode = 201;
                res.setHeader('Content-Type', 'text/plain');
                res.send(`${recordsets.returnValue}`);
                res.end();
            });
        })
    })

router.route('/categories')
    .post((req, res, next) => {
        var userID = req.body.userId;
        var cat1 = req.body.cat1;
        var cat2 = req.body.cat2;
        var cat3 = req.body.cat3;

        const pool = new sql.ConnectionPool(dbConfig)

        pool.connect(err => {
            if (err) {
                console.log(err)
                return res.statusCode = 401;                
            }

            var request = new sql.Request(pool);
            request.input('userId', userID);
            request.input('cat1', cat1);
            request.input('cat2', cat2);
            request.input('cat3', cat3);
            request.execute('createUserFav', (err, recordsets) => {
                if (err) {
                    console.log(err);
                    res.statusCode = 500;
                    return res.end();                    
                }

                console.log(recordsets);
                res.statusCode = 201;
                res.setHeader('Content-Type', 'text/plain')
                res.end('U\'utilisateur a bien ajouter ses categories préféré');
            });
        })
    })

module.exports = router;