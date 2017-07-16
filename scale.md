 # Scale
+when the number of users/agents/consumers increases rapidly (as like 100 per day, to a 10000000 per day), we can use Load balancer and cache systems.

+Using HTTP, HTTP/2

+We can give a rate for URLS that are frequently accessed.(priority)

+Also we need multi thread mechanism as a thread pooling. If we have a lot of requests at the same time, we need a queue as like ActiveMQ or RabbitMQ.

+Additionally, If we need, clusters should be adequate to scale.

+Database scaling and using cache system for many read ones. (prefer NoSQL solution.)

+Serverless systems or job schedulers check the DB for unused keys long time, so unused keys are not stored in the database.
