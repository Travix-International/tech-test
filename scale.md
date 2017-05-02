# Scale
We will be using a load balancers and we will implement a more intelligent approach than a round robin approach where it will route traffic based on each server's load, load balancing will be between the following:
  - API and Cache Servers
  - API and Database Servers

We will be caching the Short Keys so that there are fewer requests to the database servers, each POST will be a lot faster by doing this.
There will be fail over servers, REDIS can handle this extremely good for caching purposes.

We will have to come up with a database server design to handle millions of url information. We will have multiple databases where we will be storing the URLs in. Maybe some sort of a distributed has table.

We will also use another cache server where we will be caching Short URLs and based on their popularity will indicate howlong should the short urls be cached. Popular URLs will be cached for a longer time to reduce the calls to the database.

We will also implement indexing on the table to improve the read access.
