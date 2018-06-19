# Scale
In order to scale with need to consider several factors:  
If we are hosting the implementation locally we can scale horizontally adding more servers to the pool, scale vertically by adding ore power to existing machines. We can put a load balancer in front of the servers to distribute the loads properly between them.  
![](scale-vm-scenario.png?raw=true)

 We also need to consider the external systems we depend on(JIRA and HR Payroll), for those we can add caching(redis cache) to do reads faster, if we need writes or data modification on those systems we can put queues to handle multiple requests.  
![](data-access-performance.png?raw=true)

The other approach would be to have the solution moved to the cloud, in this case we can think on Azure App services, this way it can be configured to scale on demand horizontally or vertically as needed.  
If we want more control over the scalability we can rely on Azure VMs as PaaS, add a traffic manager in front of the Web app and load balancers in front of the backend servers.   
![](auto-scale-azure.png?raw=true)

Since this solution is simple we can go serverless and use Azure Functions of AWS Lambdas to increase performance.
We can also partition the datastore using sharding to distribute the rows by manager id.
