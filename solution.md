# Solution.md

- The system will have two main components, the shortener service and the proxy service.

- The shortener service will have two operation: short an URL and return original URL.

- The proxy service server will process the clients requests. For example if some client make a GET request against the https://trav.ix/92RQLZz and 92RQLZz refers to http://httpbin.org/ip, the proxy will redirect the client to the target. 

## Shortener Service Specification

```yaml
/api/short
  post:
  	description: Generates short URL
  	body:
  	  application/json
        schema: { 
	      "title": "ShorteningRequest",
	      "type": "object",
	      "properties": {
	        "url": { 
	          "type": "string"
	         },
	         "expirationDate": {
	           "type": ["date-time","null"]
	           "default": "null",
	        	 "description": "if null, then the URL don't expires"
	         },
	         "maxReads":{
	           "type": ["date-time","null"]
	        	 "default": "null",
	        	 "description": "if null, then the URL don't expires"
	         }
	      }
	    }
	    examples: |
	      {"url":"http://httpbin.org/ip","expirationDate":"2017-12-31T23:59:59+00:00","maxReads":"10"}
	      {"url":"http://httpbin.org/ip","expirationDate":"2017-12-31T23:59:59+00:00"}
	      {"url":"http://httpbin.org/ip","maxReads":"10"}
	      {"url":"http://httpbin.org/ip"}
	responses:	  
      200:
        description: Reponse of an URL that already exists
        headers:
          Location: 
          	descrition: new short URL
          	examplse: https://trav.ix/92RQLZz
      201:
	    description: Reponse of an new URL
        headers:
          Location: 
          	descrition: new short URL
          	examplse: https://trav.ix/92RQLZz

  /{url_id}:
    description: Returns a specific URL, identified by its id
    uriParameters:
      url_id:
        description: The if of the URL
        example: 92RQLZz
        type: string
    get:
      responses:
        200:
          body:
            example: |
              {
                "originalURL": "http://httpbin.org/ip"
              }
```

## Proxy Service Specification

```ascii
+---------+                  +-------------+                      +---------+
| Client  |                  | ProxyServer |                      | Target  |
+---------+                  +-------------+                      +---------+
     |                              |                                  |
     | GET https://trav.ix/92RQLZz  |                                  |
     |----------------------------->|                                  |
     |                              |                                  |
     |                              | Find target 92RQLZz at database  |
     |     If not found, return 404 |--------------------------------  |
     |<-----------------------------|                               |  |
     |                              |<-------------------------------  |
     |                              |                                  |
     |                              | Check expiration date            |
     |       If expired, return 410 |----------------------            |
     |<-----------------------------|                     |            |
     |                              |<---------------------            |
     |                              |                                  |
     |                              | Check max reads                  |
     |   If mr exceeded, return 410 |----------------                  |
     |<-----------------------------|               |                  |
     |                              |<---------------                  |
     |                              |                                  |
     |  Send redirect header to the |                                  |
     |  client to the target URL    |                                  |
     |<-----------------------------|                                  |
     |                              |                                  |
     |                              |                                  |
     |  Client is redirected to the target http://httpbin.org/ip       |
     |---------------------------------------------------------------->|
     |                              |                                  |
```

- The proxy service server will also process POST request. Once a post request does not support redirects, the proxy will send the post request and show the result to the client with the aditional header with the target location. The sequence diagram above describes the flow:

```ascii
+---------+                  +-------------+                          +---------+
| Client  |                  | ProxyServer |                          | Target  |
+---------+                  +-------------+                          +---------+
     |                              |                                      |
     | POST https://trav.ix/5CwWgL  |                                      |
     |----------------------------->|                                      |
     |                              |                                      |
     |                              | Find target 5CwWgL at database       |
     |                              |-------------------------------       |
     |                              |                              |       |
     |                              |<------------------------------       |
     |                              |                                      |
     |                              | Check expiration date                |
     |                              |----------------------                |
     |                              |                     |                |
     |                              |<---------------------                |
     |                              |                                      |
     |                              | Check max reads                      |
     |                              |----------------                      |
     |                              |               |                      |
     |                              |<---------------                      |
     |                              |                                      |
     |                              | Send a post request to the           |
     |                              | target http://httpbin.org/post       |
     |                              |------------------------------------->|
     |                              |                                      |
     |                              |    Return Reponse (Headers and Body) |
     |                              |<-------------------------------------|
     |                              |                                      |
     |   Shows target full response |                                      |
     |<-----------------------------|                                      |
     |                              |                                      |
```
## The shortner URL Algorithm

- A shortennig request with the URL http://httpbin.org/get?id=1#url will be receavid
- The system will check if the URL already exists by the URL checksum and if it does exists, return the short URL
- A new record will be created at MongoDB and a numeric ID will be returned 
- A checksum of the URL to comparison pourposes will be saved at this record
- A Bijective Function will be applied to the numberic ID and a short URL will be generated e.g. 5CwWgL
- The mongo row will be updated with the short URL
- The short URL will be returned

## Shortener Service Implementation Description

- The shortner service will be a node application that will run in a Docker container
- The docker container will be deployed in a PaaS service such as Heroko
- With Heroku, it will be possible to scale horizontally and by region
- The persistence layer will be a MongoDB due to its good scalability functionalities. With Mongo, escale and replication is easy.
- In order to improve the response time, a cache layer with redis will be implemented. Then, when a URL is called and is not in cache, Redis will look for it at mongo and retrieve the results.
