const express = require('express');
const path = require('path');
const sql = require('mssql');
const dbConfig = require('../dbConfig');

const router = express.Router();

/* GET orticle Page */
router.route('/')
    .get((req, res, next) => {
        // TODO: Render pages with user orticle
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/html');
        res.sendFile(path.resolve('public', 'app', 'orticle.html'));
    })

/* GET add orticle Page */
router.route('/add')
    .get((req, res, next) => {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/html');
        res.sendFile(path.resolve('public', 'app', 'addOrticle.html'));
    })
    .post((req, res) => {
        const { title, source, category, idees } = req.body;
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
                table.columns.add('IdOrt', sql.Int, {nullable: false})
                table.columns.add('titreIde', sql.NVarChar(255), {nullable: false})
                table.columns.add('corpsIde', sql.NVarChar(255), {nullable: false})
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

module.exports = router;