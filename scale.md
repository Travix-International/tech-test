# Scale
In my opinion scaling should be applied for the whole project not just the shopping part. In designing the solution
I was concerned about optimizing the process so that in a high load it could handle more requests.
I had some experience with micro services, it is a great solution for scaling and zero downtime, but it also add a huge
complexity to our system. By using micro services, we should have a system for gathering logs from all the services.
We should also have a mechanism for interacting between services especially if we want to have separated databases.