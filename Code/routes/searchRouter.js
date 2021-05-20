const express = require('express');
const path = require('path');
const { SearchIndexClient, AzureKeyCredential } = require("@azure/search-documents");

const router = express.Router();
require("dotenv").config();

const endpoint = process.env.SEARCH_API_ENDPOINT || "";
const apiKey = process.env.SEARCH_API_KEY || "";

/* GET the search page */
router.route('/')
    .get((req, res, next) => {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/html');
        res.sendFile(path.resolve('public', 'app', 'search.html'));
    });

/* GET the search result */
router.route('/:index/')
    .post((req, res, next) => {
        const index = req.params.index
        const { text } = req.body;

        async function sendQueries(searchClient) {
            let searchResults = await searchClient.search(text, { includeTotalCount: true });
            const searchResult = {
                isOrticle: index == 'orticle' ? true : false,
                text: text,
                count: searchResults.count,
                results: []
            }

            for await (const result of searchResults.results) {
                searchResult.results.push(result.document)
            }

            return searchResult
        }

        const indexClient = new SearchIndexClient(endpoint, new AzureKeyCredential(apiKey));
        switch (index) {
            case 'orticle':
                const searchOrticle = indexClient.getSearchClient('orticle-index');
                sendQueries(searchOrticle).then((result) => {
                    res.render('searchResult', result, (err, html) => {
                        if (err) {
                            console.log(err);
                            res.statusCode = 500;
                            return res.end();
                        }
                        res.statusCode = 200;
                        res.setHeader('Content-Type', 'text/html');
                        res.send(html);
                    });
                });
                break;

            case 'article':
                const searchArticle = indexClient.getSearchClient('article-index');
                sendQueries(searchArticle).then((result) => {
                    res.render('searchResult', result, (err, html) => {
                        if (err) {
                            console.log(err);
                            res.statusCode = 500;
                            return res.end();
                        }
                        res.statusCode = 200;
                        res.setHeader('Content-Type', 'text/html');
                        res.send(html);
                    });
                });
                break;

            default:
                res.statusCode = 422;
                res.setHeader('Content-Type', 'text/plain');
                res.end(`l'Index ${index} n'est pas supporté!`)
                break;
        }
    });

module.exports = router;