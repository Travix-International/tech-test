# Scale

![Bigpicture](/infrastructure.jpg)

The scalability of the proposed solution is based on:

1. Backend stateless to allow elastic scale out
2. Cluster of Database in Memory (Hazelcast) to improve sincronization time and read time
3. Load Balancer without sticky session

Distributing 10000000 requests during 10 hours per day, the result is a throughput around 277 requests per second in the peak.

Estimating that one small server can handle 30 requests per second, in the worst moment, it will be need 10 servers to handle the 277 requests. However, with elastic load balancing it is possible to fit the number of server to number of requests.