# Solution.md
## URL Shortener System Solution

This solution consists of 2 different applications: trav.ix and Shortener.API. Related diagrams have been included in solution. (shortener-api-diagram.png, trav-ix-diagram.png)

**Shortener.API**

* Shortener.Api is responsible for creating short urls and getting previously created urls, and accessible only from inline network.
	
    * GetShortUrl
	> GET: shortener.travix.com/shortUrl/{url}

    * CreateShortUrl
	> POST: shortener.travix.com/shortUrl

	Request Body: 
    ```bson
    {
        url: "url",  
        validUntil: "validUntil", 
        isOneTime: "isOneTime"
    }		
    ```


* Shortener.API returns Http 404, if requested url not found or if it’s one time use url and has been used before. 
* Cache server caches GET requests which has been made on Shortener.Api. It is responsible for returning cached response and redirecting to Load Balancer if requested url has not been cached before.
* Cache server skips caching for several rules:
	* Other than GET requests
	* ShortUrl length is 10. (So, if it is one time use shortened url)
* MongoDB will be used to store data for high availability and scalability support.
* *shortUrl*, *url*, *isOneTime* and *validUntil* fields should be stored on MongoDB document.

    ```bson
    {
        shortUrl: "shortUrl",
        url: "url",
        validUntil: "validUntil",
        isOneTime: "isOneTime"
    }		
    ```

**trav.ix**
* trav.ix is responsible for resolving short url (by calling Shortener.Api) and redirecting request to full url.
* It will be accessible from everywhere. 