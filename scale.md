# Scale

My scale solution is bias to AWS since I have mostly worked with this platform.
The application layer of the platform will initially employ use autoscaling with a vertical scaling strategy for the micro services. 
As the threshold of requests and costs grow, we will re-evaluate grow we will employ a more horizontal scaling approach and provision more servers based on the load. Bear in mind we will scale each micro service individually.
As mentioned in the solution we will use MongoDB for the data layer of the platform. This will allow for a highly scalable independant database layer which can be scaled horizontally via sharding i.e. distributing the data across multiple machines.
The file system layer which will utilise AWS S3 will be scaled according to AWS S3's best practices.
Application performance on the service side will be monitored via event alerts and alarms and the system will scale according to event triggers. 
Load balancing can also be employed making use of the cloud platforms specific load balancing tools.
We will integrate monitoring tools into the client application layer such as New Relic to give insights into when and how we need to scale certain services.
To cater for the posting of large media uploads we will employ a queuing service worker that will handle each request as a job. 
This can use a service such as AWS SQS or RabbitMQ. Client applications will recieve notifications after a job has been processed.
We might want to cache certain media, commonly searched posts or content using AWS Cloudfront. This will allow higher volumes of requests at a lower cost.