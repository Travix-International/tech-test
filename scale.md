# Scale
---
- The core services of the solution should be deployed every regions or zones that are perfectly choosen places for high availablity.
- The solution uses load balancer which has latency based routing feature.
- The solution works on cloud such as AWS, Azure etc. 
- The services built with microservice architecture for scalability. 
- The solution uses the auto-scale feature of cloud system.
- To handle the situations that are heavy traffic or huge data, the RabbitMQ message queue used to write the links to Cassandra.
- The health checker service can be bottleneck point of our system under the workloads. Our system needs approximately 23 health checker service instance to ping 10 million urls within the 12 hours. I assumed that the average ping value is 100ms.
(Total times reuired to ping all urls: 10 million * 100 ms)/(43200000ms - 12 hour) = 23