# Assumptions

1. Assuming that the opportunity cost is confirmed. We have relatively large number of unique users who search the same set of parameters within a period of data validity (threshold), thus it makes sense to cache data.
2. We have finite and relatively small set of search parameters.
3. We can neglect some parameters (thus having larger set of fares in search result being cached) and leave more refined filtering to client (browser) side.
4. Hashed concatenated list of parameter values will be used as the cache key, providing easy search.
5. Data consistency and partition tolerance are more important than availability in our case. Replication is most probably redundant. 
6. We should provide the same data to any user regardless their location, etc., or (if assumption is not validated) treat the user information as a part of search parameters (in case the information may be aggregated and/or grouped) or prevent specific search form caching otherwise. 
7. We are targeting horizontal scalability, so we will have the components built up to easily scale on demand and/or predictivly.
8. An infrastructure is available to reduce/increase the number of servers/instances on demand (preferably automated, based on certain rules, if not, include it in solution).
9. We can afford to reduce the amount of data value being cashed (language/meta information) keeping only the data references (e.g. IDs) by shifting data mapping (or calculating, sorting, filtering) to client (browser), thus saving in-memory space and computing time/cost. This will not cause any data integrity or security issue.
