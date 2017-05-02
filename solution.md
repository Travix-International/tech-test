# Solution.md
We will be designing a REST API where the original url will be given via a POST request, other optional parameters will be expiryDate. To make the API a lot faster, we will be pre generating the short keys and store it in a database, the keys will be cached via REDIS to improve shortener POSTs. Every time a key is being cached on the REDIS server then it will be flagged as being used, this will help to make sure that each server has a unique key.
The database design will have ShortUrl as the primary key to ensure that each entry will be unique. Other fields are CreationDate, ExpiryDate and MaxUses. Replication should be implemented and a failover database should be available incase the main db server is not working.
The API will check if the Short key already exists in the db before making the final POST call to the database.
To get the original URL, it will be a simple get request with the short key.
The API will be versioned for example, travix.com/shortyUrl/v1
Example of the shortUrl will be trav.ix/WFr49F
We will be running a cleanup service to remove any expired urls and it will also ensure that the generated key database does not have keys that are flagged as being used when the exists in the main db.
