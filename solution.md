# URL shortener system

The proposed solution consists of three microservices and one key-value storage:

* A query creation service that accepts the long URL from client and returns a short one. It can be made accesible via Web page, Web API or both. The newly created short url can be the first N characters of the hash of URL. This url is used as a key to store the long URL-related data.

* A query resolution service that accepts a short URL and returns the long one in form of a HTTP 307 redirect for the web page service or in form of JSON with the URL to allow the API client to compose the query by itself. Upon access to key-value storage the link is checked for being valid (not expired, not a used one-shot one, not returning 404 during a recent check). Following an invalid link produces an appropriate error message. The same services marks one-shot link as invalidated after returning the result and queues a request to check the URL.

* A url-checker service that is to follow the resolved URL after the client was given a response if the link has not been checked for a while. The check result is saved in the key-value storage to prevent redirects to dead pages. Once a link is failing for over N hours it's marked as invalid one permanently and following it won't be allowed. This is how we are to reduce the number of 404s.

* A key-value storage hosted in a distributed cloud to allow shorter response time across the world. It's objective is to hold a dictionary of short urls. The proposed table format is like this: 
```
{
    short_url: string, 
    long_url: string, 
    one_shot: bool,
    health: {
        status: enum,  /* valid, expired, used, last_check_failed, checks_always_fail */
        last_check: datetime, 
        last_check_status: string, 
        failing_since: datetime 
    } 
}
```