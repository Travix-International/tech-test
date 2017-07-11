# Scale
I don't think scaling could be applied just for the shopping part of the project. In designing the solution I was
concerned about optimizing the process so that in a high load it could handle more requests.
I had some experience with micro services, it is a great solution for scaling and zero downtime, but it also add a huge
complexity to our system. By using micro services, we should have a system for gathering logs from all the services.
We should also have a mechanism for interacting between services especially if we want to have separated databases.