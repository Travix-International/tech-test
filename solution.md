# Solution.md

## URL Shortener system

A URL Shortener is basically a dictionary; that maps a unique randomly generated hash to a url. In our case, since we have additional requirements, such as; additional headers, it will be better if we map our hash to an entity ( object ) that contains these properties. This one-to-one mapping can be stored in a NoSQL database ( such as Redis) because we don't need any relational data structure, we basically will have a single collection/table/entity. Moreover, Redis is good for our additional requirements such as fast reads, scaling, ttl, one-shot functionality and etc..

## Use Cases
1. Generating the short url from an original long url.
2. Taking the short url and returning the corresponding original url.

### Use Case 1 : (/generate)
We can use an HTML Form or a REST Api to take the additional parameters for generating the short url ( additional headers, TTL, one-shot, etc...). 

### Use Case 2 : (/{hash})
Receive the hash as an HTTP Request and Respond with a 302 Found ( moved temporary is better here because it may have a TTL or 404 for one-shot functionality )

So, for these two Use Cases we basically need a web application with two endpoints (one for each use case, and maybe a few html pages for home and about if it's a web site ) and a database(actually a redis cache ).

## Domain Model :
We'll have one entity called "Link" ( we are linking/mapping a hash to a url ). So our RedisKey will be hash, and our RedisValue will be the "Link" entity.

### TTL : 
Since Redis supports data expiration, we are not going to include this paramenter in our domain model. We just can set a lifetime to a RedisKey.

### One-Shot : 
For one-shot functionality we can use Redis Lists. So that the value will be inaccessible after pop ( this isn't a good solution for scalability. For example : what will we do if we want to support 2 shot links or n shot links. The better approach would be to use a counter in our entity and decrement it after usage but let's say that it hasn't been specified )

### Redis Key :
* hash ( a randomly generated unique 3 to 7 character string. Size depends on the total number of urls that we are going to have. Assuming that we are going to have only alphanumerical short urls our alphabet consists of 26 + 26 + 10 = 62 letters. So with a 3 char hash we can represent 62 * 62 * 62 = 238 K unique urls )

### Redis Value :
* url ( the original url  )
* headers ( a collection of additional headers. Since query strings, url fragments and scheme are part of the url we don't need to store them separately )
