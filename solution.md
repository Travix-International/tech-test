# Solution.md
A web API with a resource named URL-shortener that supports HTTP verbs POST and GET with the semantic and responsibilities described below

POST - api/shortener  
creates a new shortened URL applying a hash or Bijective Function algorithm with the following parameters in request body:
* original-url: URL to be shortned **
* ttl: time to live expressed in minutes being the default value 1.
* max-reads: maximum number of reads  

_** required fields_

After processing, save a key-value with key equals to the shortened Url and value with a complex object containing all request parameters and number of reads(initially 0).  
When successful the response is 201 with the created shortened url, otherwise return compatible HTTP code(4xx or 5xx)  

GET - api/shortener/value  
given a shortened url parameter returns its content  
Steps:  
1. Look for shortened url in cache server(ElasticSearch/Redis)  
    1.1 If do not find returns 404  
    1.2 If finds but the resource is not available(reads > max-reads or TTL is over) then delete is from cache and returns 410  
2. Updates resource reads if max-reads is greater than 0 and returns a redirect to original-url  
