# Scale
To cover scalability concerns I decided to consider various points to approaching best result:
- Multiple instances(nodes) of workers are used. On the other hand, it's possible to implement the services using "container", so it will be easier to add a new node to handle more traffics(horizontal scaling). obviously by using multiple servers/nodes,a load balancer is needed to redirect requests to nodes.
- Microservice architecture for scalability of application in future is a good option.
- using queuing system like RabbitMQ for writing data to database that makes request faster is good choice. In this case the "write to db" action which leads to bottlenecks in case of heavy traffic, is taken care.
- sharding database also will help and decrease the reading time from database, specially when the number of records growth in years to millions and billions records.
- using cache will decrease number of readings from database and makes requests faster 
- my approach to generate new random hash-key(dynamic part of short link) is fast(because of unique number that is used) and does not generate duplicates, so we don’t need to check if generated key exists. that means faster request as well.
- using CDN also helps in this matter and decrease response time (everyone get response from closest server)
- also using cloud services like Amazon AWS or Google Cloud or MS Asure gives a lot of built-in tools and options to cover scalability concern. for example using amazon elastic beanstalk can make service/application Auto-scale which means it will scale according to number of requests.  