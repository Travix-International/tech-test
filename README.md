Travix Tech Interview Test

## Fare Cache

Every day, hundreds of millions of airfare prices are being found based on searches from our customers. This can be a valuable stream of information, for example it can be used to show the cheapest recent price for a particular flight.

When a customer searches for a particular route (e.g. AMS to JFK), we return a list of zero or more fares, and on an average day we perform fifty million of these search requests, with each search returning anywhere from zero to two hundred results, but on average ten.

Each fare has a price with two decimals, and it’s valid for up to forty eight hours (and it’s a truly random number).

Roughly, there are 20,000 airports in the world, but not all airports are connected to each other, so there are only about 15,000 unique routes, combinations of a departure airport and an arrival one. Naturally not every route is equally popular, so there isn’t an even distribution of fares over the routes.

In order to make good use of this searches and reduce the strain on our poor servers, we want you to build a Fare Cache.

This Fare Cache:

* Can be queried to obtain the cheapest flight on any route in the world: When we query for the cheapest flight on a route, this is defined as "the fare with the lowest price on that route, which is still valid at the moment of querying"

* Is going to be used on our websites which receive millions of visits per day

* Different sites are specific for different countries, so the popular routes are going to be different across sites

* Subsequent search results on a route can 'replace' previous saved search results (e.g. suppose you search AMS-JFK and get 100 fares; five minutes later you search again AMS-JFK and get a slightly different result set of 101 fares. When we ask for the cheapest route AMS-JFK, we assume that the first result set is obsolete and the answer should come only from the second result set)

