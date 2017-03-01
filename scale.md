# Scale

The caching system will be horizontal scalable. Anyway, since we are going to use in-memory cache, choosing too weak horse power servers/instances will not contribute to the problem solution.

## Technology
A good candidate would have been memcached. But a memcached cluster would require additional work (procedures, configurations) for sharding and changing the number of nodes in the cluster upon load change. Other option may be Couchbase (used with memcached datatype), DataGrid, Oracle Coherence, Riak, Azure Redis Cache, etc.
## Platform
Cloud based infrastructure will allow to utilize the product offered in the cloud. Examples are Google App Engine that provides memcached API or Amazon (AWS) that has its own caching solution, ElastiCache, that has memcached and redis APIs.
#  Size
The worst situation is (calculated based on description, assumptions. It is not final by no means):
```
20000 x 20000 x 365 * 2 * 2 * 10 * 9 * 9 * 9 * 4 = 153,265,000,000,000,000 (1.5 quadrillion). 
```
This is not practical information at all, just curious :). In reality, taken into account that, for example, 5 minutes is the TTL, than the worst case is the size equal to unique users visited and searched, within TTL period, assuming that each does unique search. Any other calculation is not quite possible here in this stage, without having different real information. 
