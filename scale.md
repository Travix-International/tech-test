# Scale
The two main scale concerns for this solution is overall storage needed and maximum concurrent connections.
1. Overall storage - Current estimation is around 5Gb for the date, should this get to 5Tb a scaling of the Db hardware and nodes
will be needed and probably Mongo or Sql won't be able to handle it. For Cassandra it is a matter of scaling the hardware.

Luckily the amound of data to be stored is based on airports and offered flights,
so expected growth is rather small in comparison to possible user growth on travix's platform.
With current data estimation growing to 30K routes and 100 total unique daily search results per route we get to 30Gb which is still handled properly in this design.

2. Maximum connections - Concurrent connections count can grow with more users. Adding more nodes to the DB can spread the connections
   between nodes and handle the scale.

The service API is stateless and can be scaled up by deploying more instances and balancing the load between them.
