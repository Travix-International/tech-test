# Scale

We have to take the web server and the database into consideration for scalability issues. 

## Scaling the web application

Scaling the web application is easier than scaling the database. We can add extra web servers behind a load balancer. 

## Scaling the database

Since Redis supports sharding, we can use our endpoints as shard keys. 

## Extra

### Analytics

Defining the shard keys isn't an easy task. Maybe we can use some Analytics tool to define the frequently used endpoint. This will help us to define our shard keys better.

### Availability & Caching

Since we are using Redis (instead of a slow relational database) we don't need any caching, although the read-to-write ratio will be very high. Also, master-slave model for Redis would be nice for SLA. 
