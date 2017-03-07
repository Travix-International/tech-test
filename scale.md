# Scale

This type of cloud based micro-services architecture (SOA) provides huge scalability and performance.

Initially it is set to have 2 instances of the micro-service and the traffic load will be well distributed by an application load balancer. A single memcached instance will manage persistent data from previous requests to reduce hits to the Database and increase performance.

When the time comes and the traffic increases significantly, additional instances of the micro-service can be added.

Adding memcached instances behind each micro-service is also an option if needed eventually.

As for the database maintenance, a worker process can be set to manage cleaning up the expired short urls, to keep the database size in good shape.
