# Scale

- Make use of Azure cloud provider to partition or replicate app services or data storages on demand.
- Use immutable data types by default to ensure easier concurrency and safer manipulation of application state. Resorting to a mutable type in an intensive program path is fine but should be exceptional and controlled.
- Limit the usage of `UPDATE` and `DELETE` queries if using RDBMS for easier transaction management and consistency.
- Use asynchronous programming patterns (i.e. async/await in .NET) to efficiently employ hardware resources.
- Make it as simple as possible to move to microservices architecture and make use of a messaging system (such as [MassTransit](http://masstransit-project.com/)).
- A caching layer can be introduced ([Azure Redis Cache](https://azure.microsoft.com/en-us/services/cache/), for example).