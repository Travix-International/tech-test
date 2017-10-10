# Scale the URL shortener system "Scenario 1"
This implementation is based on the assumption that the solution is deployed to a cloud IAAS/PAAS(eg: AWS/AZURE)

To handle heavy traffic upto 10000000 hits per day on the system we will follow the steps below to scale the system:

1. Move the system from a single server deployment and deploy across multiple servers.
2. Create a load balancer to distribute the request across multiple servers.
3. Make the system only accessible via the load balancer.
4. To further mitigate against a DOS/DDOS attack, you can enforce all request to the system to route    through a Content Delivery Network(CDN) and can also implement/configure or enable caching for        faster response

5. Also configure cloud server to auto scale (ie: increase and reduce number of servers at peak and none peak periods automatically)
