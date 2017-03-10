# Solution.md

A user searches for a route from A to B. As the user presses the search button…
1.	When a search is made, a unique identifier is generated based on the route and the dates. (for instance, HKI-AMS 13.3.2017 could be saved as HKIAMS13032017). The identifier is then stored and each time the search for this route is made a “frequency” field is updated.
2.	The web service checks the cache first for the rates
  **a.**	if a valid cache is found, results are returned from the cache. The frequency value is updated
  **b.**	if the cache is not found, the route is calculated. The results are returned back to the user and a new cache for the results is created. The frequency value is updated.
3.	We have set a global frequency threshold value set to, for instance, 50.
4.	We use the TTL index object to set the expiry of the cache, default to 48 hrs. The same identifier can be used as the primary index.
5.	Cache is being stored in a NoSQL Database (for instance, MongoDB) in the form of JSON as document. Therefore, schema design and relations are not required.
6.	The cache is updated occasionally twice by a web service which is invoked:
**a.**	as soon as a user buys a ticket for the particular route and date, for which the cache exists, the cache for that particular route will be updated.
**b.**	as soon as TTL index value expires and event is triggered (read: [MongoDB on TTL Indexing](https://docs.mongodb.com/manual/core/index-ttl/))
**c.**	optionally and/or additionally another Cron-job can be created to check for the expired cache results or to update the cache results based on the frequency against the identifier, if the frequency value matches the global threshold value.
7.	Based on the Frequency value against each identifier, the TTL value can be reset to a lesser value than 48 hours. It means cache for the routes which are frequently searched for, should be updated more frequently.

#### Flow Diagram
![Alt Fare-Cache flow diagram](fare-cache-flow.JPG?raw=true "Fare-Cache Flow Diagram")

###### References for the images used in the flow flow diagram above
1. https://www.iconfinder.com/icons/286086/android_communication_galaxy_mobile_phone_samsung_icon
2. https://openclipart.org/detail/182736/application-server
3. http://www.freeiconspng.com/free-images/laptop-icon-19513
4. http://www.computer-lock.com/wp-content/uploads/2013/10/Solutions-to-Data-Storage.gif
