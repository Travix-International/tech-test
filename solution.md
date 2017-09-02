# Solution.md
# Travix
## URL Shortener System Solution

This solution consists of 2 different applications: trav.ix and Shortener.API.

**Shortener.API**

* Shortener.Api is responsible for creating short urls and getting previously created urls, and accessible only from inline network.
	* CreateShortUrl

	> POST: shortener.travix.com/shortUrl

	Request Body: 
`
{
	"url": {url},  // Url to be shortened
	"validUntil": {validUntil} // Short Url expire date
	"isOneTime": {isOneTime} // Flag to decide if short link is only valid for one time usage.
}		
`
	* GetShortUrl
	GET: shortener.travix.com/shortUrl?url={url}
* Shortener.API returns Http 404, if requested url not found or if it’s one time use url and has been used before. 
* Cache server caches GET requests which has been made on Shortener.Api. It is responsible for returning cached response and redirecting to Load Balancer if requested url has not been cached before.
* Cache server skips caching for several rules:
	* Other than GET requests
	* ShortUrl length is 10. (So, if it is one time use shortened url)
* MongoDB will be used to store data for high availability and scalability support.
* *shortUrl*, *url*, *isOneTime* and *validUntil* fields should be stored on MongoDB document.

**trav.ix**
* trav.ix is responsible for resolving short url (by calling Shortener.Api) and redirecting request to full url.
* It will be accessible from everywhere. 