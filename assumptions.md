# Assumptions

- very long, ephemeral, URLs.
- shortest URL possible in place of a "real" URL (emails, or 2m2)
- (1) email shortener (still human readable)
- (2) machine2machine (shortest possible)
- (3) security: one-shot urls
- shortened domain: trav.ix

Requirements:

* Of any length
    https://en.wikipedia.org/wiki/Query_string
    --> If the URL is too long, the web server fails with the 414 Request-URI Too Long HTTP status code.
    The common workaround for these problems is to use POST instead of GET and store the parameters in the request body. The length limits on request bodies are typically much higher than those on URL length.

* Containing query string parameters "?a=1&c=2..." (NON-REST)

* Containing URL fragments "#section"

* Of any scheme "http://,https://,file://,amqp://..."

* Using GET or POST

* Containing some non standard headers "X-CustomProperty"

* With a variable time to live (tls), after which they shouldn’t be available

Additional requirements:

* We want to reduce the number of 404 we would return in case of an outdated (timestamp policy --> bad request 400) short URL

* Short URL need to be quickly accessible across the world : distributed storage/cache for localized low latency

* Short URLs need to be able to answer GETs as well as POSTs appropriately

- the url shortener service should be highly available and handle a huge amount of requests per second (could be useful to implement some caching mechanism)
- url --> shortenedUrl is 1 to 1
- a GET request to domain/url must forward to domain/shortenedUrl
- http GET response status: 306 in case of success for temporay url, 307 for permanent url redirections. 404 for not found.
- the first GET to domain/url should generate the shortenedUrl for the first time
- the newly generated urly should be stored in set datastructure, containing the tuples (url, shortenedUrl) as elements, avoiding the issue of duplicate shortenedUrls poiting at the same url
- a proper storage for the set datastructure could be a key value db such as Redis.