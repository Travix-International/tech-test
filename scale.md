# Scale
In my opinion scaling should be applied for the whole project not just the shopping part. In designing the solution
I was concerned about optimizing the process so that in a high load it could handle more requests.
I had some experience with micro services, it is a great solution for scaling and zero downtime, but it also add some
complexity to our system. By using micro services, we should have a system for gathering logs from all the services.
We should also have a mechanism for interacting between services especially if we want to have separated databases.

I develop apps with Node.js in the back-end, in this case because Node.js use just one thread, for scaling it we can use
libraries such as: pm2, cluster, etc. These libraries also help us to have zero downtime. We can also use caching for
other parts of the project, but for shopping cart it doesn't quite hit the mark.