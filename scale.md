# Scale

![Bigpicture](/infrastructure.jpg)

## The scalability of the proposed solution is based on:

1. Backend stateless to allow elastic scale out and async controllers to be more efficient in use of threads to I/O
2. Cluster of Database in Memory (Hazelcast) to improve sincronization time and read time
3. Load Balancer without sticky session to improve availability
4. Segregation of backend servers by geographic region

Distributing 10000000 requests during 10 hours per day, the result is a throughput around 277 requests per second in the peak.

Estimating that one small server can handle 30 requests per second, in the worst moment, it will be need 10 servers to handle the 277 requests. However, with elastic load balancing it is possible to fit the number of server to number of requests.

## Points that can be improved to reach more performance yet:

1. Use of Go language to handle request of schemes unsupported by ASP.NET Core MVC or to speed up the response time
2. Segregation of database in write and read operations
3. Geographic Load Balancing
4. Short URLs *interceptable* by a CDN
5. Containers to improve the provisioning time of new instances