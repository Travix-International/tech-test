Scale
=====

Depending on the scenario, i will use different solutions.

At the beginning I will use Nginx as static file server and will use separated servers for NodeJS and RethinkDB. NodeJS and RethinkDB are scalable horizontally and vertically, so it should not be a problem.

If things get better, I will add a Load Balancer, use multiple availability zones, and add a CDN for static files for optimizing cross-origin performance and lower the latency.

Then if the business is so good, I will use a microservices architecture, split the application into different modules like, Users, Reporting, and Tracking. Each one with its corresponding database and API.

For high traffic peaks, I will go with some Elastic traffic solution, like Amazon EC2. With monitoring and automation, so that the business runs smooth and then go for some beer and celebrate!
