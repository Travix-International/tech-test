# Scale
- Application level: 
        - Hardware will depends on wheather the technology that will be used will be multi-threaded (Java, ASP.net) or single threaded (Node.Js).
        - Create a web farm distributed in different countries to ensure the least network latency.
        - Load balancer in front of the web farm to manage the requests either by location and/or the utilization.

- Database leverl:
        - Multi master replication, as there no update requests for the database in the current design this will be the best model.
        - Database clustring to ensure the most availability.
        - Load balancer to manager queries between the database servers (clusters).
