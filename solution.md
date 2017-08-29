# Solution.md
Implement an in-memory distributed cache (cf. system-context-diagram.png) considering the following points:
* **Key-Value Structure**: cf. class-diagram.png 
  * Key: departureDate, origin and destination
  * Value: lowest price for that route/date and route information: carrier, duration, cabin, flight number, departure and arrival time)
* **Partitioning**:  Implement a custom sharding algorithm to group popular routes across sites. Computations must be collocated with the cluster nodes caching the data that needs to be processed to maximize performance per site.

* **Eviction** policy and Overflow: Evict based on entry count up to a MAX_ ENTRY_NR (LRU). Where MAX_ ENTRY_NR is the maximum number of entries in cache before overflowing data to disc. This number must be optimized based on cost constraints and data analytics for popular routes and dates.

* **Expiration policy**: 48h TTL - Eagerly removing entries from cache to optimize cache memory usage cost.

* **Sync Data – Create/Update Entries**: Two components are needed:
  * A search results pre-processing job service that will retrieve customer search results, obtain the lowest price per route, and then call a create/update cache server function. This job service is placed in each site. 
  * A server function to create and update entries in the cache. 
 
  The create/update server function will work as follows:
  * If there is no price entry in the cache for that route and date (i.e. first time or expired) => **create new entry** 
  * If there is an existing price in the cache for that route and date, and the search returned a lower price than the existing one => **update existing entry**

* **Cleaning – Delete Entries**: A server function to delete past time entries no longer valid as per the current time. The function service is to be called by a background job process updating at a regular interval (4h). The job is placed in each site.

* **API**: Implement a Get REST service to retrieve the lowest price on a given route and date from the cache, excluding past time entries.
