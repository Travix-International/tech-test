# Scale

## Cloud based Solution
To be prepared to a sudden increase in demand, a cloud based plataform (like GCP) as starter point with autoscaling feature enabled would be best, in my opnion. In this scenario I would monitor in the dashboard the performance of the autoscaling feature and see how costs grow.

## Company hosted solution
If the solution would be hosted in our own servers, the first change I would do is create a cache strategy. Because data that has been requested recently is more likely to be requested again.
I would also divide the services and functions (SOA), so each one can be isoleted and have a context.
A critical point should be load balancers, create queues if needed and apply reduncancy to prevent failovres. The servers would be able to scaled verticaly and horintaly (Particions), because storage and CPU capacity have to able to increase easily.
