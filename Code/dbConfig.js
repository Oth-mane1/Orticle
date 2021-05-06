require('dotenv').config();

const dbConfig = {
    server: process.env.SERVER,
    database: process.env.DATABASE,
    user: process.env.USER,
    password: process.env.PASSWORD,
    options: {
        encrypt: true,
        enableArithAbort: true
    }
}

module.exports = dbConfig;
