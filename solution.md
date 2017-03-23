# Solution
 
The services will handle all requests and execute all logic related to shortening, storing, getting and deleting a specific URL and redirect the client. 

To achieve this, we will use the following ideas:

- Shorting the URL: we can use the hostname combined with the timestamp and apply some algorithm that will return a shortened one.

- Storing the URL: we will use the shortened URL as our key and the value will be the full URL.

- Validating an existing URL: we will try to search the key (URI) in our cache layer first, if none was found, we will search the database layer and master database layer by doing the same process.

- If no result was encountered, we will store in the database and propagate through the store layers, setting the appropriate configuration like TTL, one-shot, etc.

- For each request we will search in the cache or the database layer (if the cache returns 404). After we have found the URI (key), the application will return a 307 status by redirecting the client by GET or POST depending on the HTTP method called by the client.

- Otherwise we will return a 404 status.

- Depending on the configuration of the URL that the client is calling, we will delete it from all systems (all store layers), such as a one-shot or an expired call.

- The cache's and database's job will be invalidating the URLs that are expired and providing feedback/statistics/alerts to a dashboard.