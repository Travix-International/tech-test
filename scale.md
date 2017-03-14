# Scale

1. The system could be a cluster that should be able to create/destroy nodes according to the use of resources (CPU/Net traffic/Memory), updating the load balancer's list of nodes. The database(s) have to be configured with a high availability scheme (master-slave, active-passive, etc).
2. I see two or more approaches here:
 * An automatic autoscaling tool could be used to perform these operations, like App Engine.
 * Configuration of the cluster using Kubernetes, Swarm, Mesos, etc.