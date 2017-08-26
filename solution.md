# Solution.md
My solution for a fare "cheapest route" cache system is based on a database and a web service serving its API with two main methods:
- GetCheapestRoute(origin, destination)
- InsertRoutes(origin, destination, records).

Each time we want to present the current cheapest route GetCheapestRoute will be called.
Each time a search is performed the InsertRoutes API will be called with all search results.

We need to cache all possible route fares in our DB as the current cheapest one might become invalid soon and our cache should serve the next cheapest one.
A needed storage size estimation for this is ~5Gb (1Kb per route, 30 total unique results per route per day, 15k routes, 10X factor for errors - see more in assumptions file).

For the DB choice we don't need relational properties, but we do need consistency and the ability to do querying by column filters.
The first choices will be Cassandra or MongoDB for a consistent, scalable & queriable document store, were we'll store the records as json documents.
Another option is using a SQL based solution - even though no relational properties are needed such a DB can go to large size, can be indexed properly
and can handle the request per second rate.  

The API wrapping this DB is added for isolation and the possibility of changing the DB technology and logic in the future. It should be
scalable and simple. Since no state is needed on the service side it will be stateless so easily scaled and managed.
One option is deploying this API-layer on a serverless infrastructure (like aws lambda) to achieve scale-on-demand and cost effectiveness.

GetCheapestRoute API will query the cheapest record for given origin and destination that are still valid (valid_until > now) and return to the caller.

InsertRoutes API will first get all record for given origin and destination and will add to the DB only records that aren't there yet.
this API should support asynchronous invocation so the client doesn't wait for its processing. It can also be done through a message queue system.

A data cleanup job can run separately on a fixed schedule to delete all records with validity in the past.

See ApiFlows.pdf for flow diagrams of the two API calls.
