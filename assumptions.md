# Assumptions

* System architecture must be designed with keeping failover aspect in mind as it is critical point
* Every part must be replicated to prevent any downtimes
* As service business logic is not relational keeping all URL meta information in single place is preferred
* URL shortener microservice can provide simple REST api to other system components to make it integration universal
