# Solution.md

Given information allows to choose a generic high-performance, distributed memory caching system option, without complex NoSQL query features, persistence and secondary indexes, with preferably LRU policy and good TTL mechanism (this is very obvious, though probably needed to be mentioned by the task). 

## Technology
See *[scale.md](https://github.com/baulus/fork-my-rep/scale.md)*

## Data structure
The unique search conditions (assumed as finite and relatively small) should be concatenated (in predefined order), hashed and served as the cache key.  
The whole set of search result will be saved as a cache entity, be it one-way, return or multi destination search. 
Search conditions (parameters) example: 
```
(dep_all_N, dep_N, arr_all_N, arr _N, dep_date_N, arr_date_N) x N, 
adult_num, 
children_num, 
infant_num, 
ticket_class
```

## Flow
When querying "return" or "multi destination" search and in case of absence of cached result, satisfied data may still be found in the cache if additionally queried for "one-way" fares for each departure and destination pair (It seems, this part should be validated based on additional business rules). Otherwise return the cache found. 
In either case, cache should be validated against other cache dependencies if required by business riles.
To reduce the traffic, the result will be a json object containing fare data and set of mapping wordings/references. Client will map data, do filtering and sorting, e.g. by airline, time, etc.

