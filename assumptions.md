# Assumptions
* A route corresponds to the smallest unit of travel (a.k.a. leg) i.e. in the case of a flight a takeoff followed by a landing at two set points on a particular carrier and flight number. 
* The cache will contain the lowest price for a given route on the current date
* The cache won’t be queried to obtain the lowest price per type of cabin (e.g. coach, premium coach, business and first). 
* The cache will be queried only to obtain the lowest price on a given route, which is still valid at the moment of querying, regardless of the duration, carrier, aircraft or cabin.
* Only one-way prices are stored, round-trip prices are not needed.
* Seats availability is ensured for airfares stored in the cache.
* The price stored in the cache will correspond only to the price for a single adult, lowest price for child or infant are not needed.
* Baggage and tax information are not needed.
* The IMDG will support a Key-Value store.
* Search results are available for retrieval and processing e.g. queuing service or stream processing platform.

