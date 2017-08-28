# Assumptions
Implement an in-memory distributed cache considering the following points:
* **Partitioning**:  Implement a custom sharding algorithm to group popular routes across sites. Computations must be collocated with the cluster nodes caching the data that needs to be processed to maximize performance per site.

* **Eviction** policy and Overflow: Evict based on entry count up to a MAX_ ENTRY_NR (LRU). Where MAX_ ENTRY_NR is the maximum number of entries in cache before overflowing data to disc. This number must be optimized based on cost constraints and data analytics for popular routes and dates.

* **Expiration policy**: 48h TTL - Eagerly removing entries from cache to optimize cache memory usage cost.

* **Sync Data – Create/Update**: Implement a server function to create and update entries in the cache anytime a customer searches for a particular route:
  * If there is no price entry in the cache for that route and date (i.e. first time or expired) => create new entry 
  * If there is an existing price in the cache for that route and date, and the search returned a lower price than the existing one => update existing entry

* **Clean Data – Delete**: Implement a server function to delete past time entries no longer valid as per the current time. The function service is to be called by a background job process updating at a regular interval (4h).

* **API**: Implement a Get REST service to retrieve the lowest price on a given route and date from the cache excluding past time entries.
