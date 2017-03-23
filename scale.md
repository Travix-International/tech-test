# Scale

Because this system needs to be quickly accessible, the main idea is to have as much as possible cache service to store the URLs without passing through the database.

- To give a quick response: we need to set all groups to each geographic region.
- Service layer: When a service is using too much processing powert, we can scale by adding one or more EC2 instance.
- Cache layer: We need a cache layer to rapidly access the data. We can scale this the same way as the service layer.
- Database layer: We can use horizontal-scaling to replicate the data through the database when the storage reaches a determined percentage, by changing the replication factor (RF) and the number of nodes (N).
- Master database layer: We need a master database that will help manage the consistence data.
- Job scheduling: We will have jobs that will invalidate the URLs in the cache and the database at determined times.