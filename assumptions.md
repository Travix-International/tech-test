# Assumptions


Old url format will still work
The new URL will accept new parameters, headers and body from the client.
The url will only work once, if already used it will return a 308 Permanent Redirect :
The request and all future requests should be repeated using another URI.

There will be a service for travis to create the new urls and determine when they expire.

The url treatment will be standard:
Response Codes

standard http response codes.

200 Ok The operation was successful.
308 Permanent Redirect.
400 Bad Request The request is not in the required format.
401 Unauthorized is not authorized (if required).
403 Forbidden the operation is not allowed.
404 Not Found The requested resource does not exist.
405 Method Not Allowed The request method is not allowed for this resource.
500 Internal Server Error An error occurred on the server while processing this request.
503 Service Unavailable The service is not available for processing requests.


This handles the requirement : "We want to reduce the number of 404 we would return in case of an outdated short URL"
 410 Gone if the requested resource is no longer available at the server and no forwarding address is known
