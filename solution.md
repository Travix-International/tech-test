# Solution
---
I design a solution with Geo-Distributed architecture approach in order to be quickly accessible accross the world. 
The solution has following components:
- Core services(REST API)
- Health Checker Service
- Centralized key-value database
- NOSQL database (Cassandra)
- RabbitMQ

The components interactions can be found in architecture.jpg and dataFlow.jpg.

- Core services(REST API)
  - Url creation service that accepts the long URL from web app or API client and returns a short url. It generates a unique identifier(GUID) for long url and converts it to base62 string. This base62 string and long url is pair data which is written to the key-value database. The link object data (can be seen in diagrams) inserted to NOSQL database. 
  - Url resolution service that accepts a short URL and returns the long one. It extracts the base62 string from given short url and fetch corresponding long url from key-value database. And it redirects the request to long url address.

- Centralized key-value database
  It could be Memcache, Apache Ignite, Voldemort, Amazon DynamoDB. A key-value storage hosted in a cloud to hold the unique key for short url corresponding to long urls.

- RabbitMQ
  It is mediator between core services and Cassandra database. The core services interacts with message queue to write an entity to Cassandra database.

- NOSQL Database
  It is Cassandra to hold the links. It keeps the link document. The health checker service uses this database to validate link. For instance it checks the expiration time of the url. It provides data consistency with multi-datacenter replication feature. It keeps the following link object:
```sh
  Link Object
{
	id:string,
    short_url: string,
    long_url: string, 
    one_shot: bool,
    status: enum, /* active, deleted, used, down */
    createdAt: timestamp,
    expiredAt: timestamp,
    updatedAt: timestamp,
    lastCheckAt: timestamp,
    failedAt: timestamp,
    clicks: integer,
    lastClickAt: timestamp,
}
```

- Health Checker Service: is a timer service and checks the health status of urls in a given time period. This service makes validation of long url. In order to reduce the number of 404s, the short url key removed from key-value database to prevent redirects to dead pages.