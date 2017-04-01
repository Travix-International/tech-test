# Scale

- Scaling would be horizontal, that is replicating servers. A load balancer is required. Setting up the architecture in a service such as AWS wouldn't be hard.
- For the database, a cluster should be setup. Also we should have indexes in place for the most usual queries, which would be per user.
- The other microservices should be scalable too, otherwise there would be a bottleneck there.
- Adding a cache for products would improve performance.
- Setup some task to clear old and unused data.
