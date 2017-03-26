# Scale

* Even tough the architecture shows a load-balancer, initially we don't need that, but an nginx with upstream might be good.
* When the traffic increases its good to have another cluster of the same setup,
* MySQL can have more slaves added, may be we have to consider mysql-cluster as well, but will prefer master-slave as new users will be less compared to the read ops.
* MongoDB should use shrading & clustered, it will have a good chunk of data moving forwad.
* Get Requests can be cached per project level, with hashes in different server Redis-Cluster setup.
