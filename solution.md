# Solution.md
Shortener REST API:
We will be designing a REST API where the original url will be given via a POST request, with other optional parameters. 
POST Url: travix.com/shorty/v1/short with a JSON body {"originalUrl":"http://example.com/VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZw==","expiryDate":"2018-04-05T00:00:00","maxUses":10}
To make the API a lot faster, we will be pre generating the short keys and store it in a short key database, the keys will be cached via REDIS to improve shortener POSTs. Every time a key is being cached on the REDIS server then it will be flagged as being used, this will help to make sure that each server has a unique key. There will be some locked state to ensure that two servers will not be able to get the same key. There will be a fail over database, incase the main one goes down.
The database design will have ShortUrl as the primary key to ensure that each entry will be unique. Other fields are CreationDate, ExpiryDate and MaxUses. Replication should be implemented and a failover database should be available incase the main db server is not working.
The API will check if the Short key already exists in the db before making the final POST call to the database.
To get the original URL, it will be a simple get request with the short key. For example: travix.com/shorty/v1/short/WFr49F
The API will be versioned for example, travix.com/shorty/v1
Example of the shortUrl will be trav.ix/WFr49F
We will be running a cleanup service to remove any expired urls and it will also ensure that the generated key database does not have keys that are flagged as being used when the exists in the main db.
