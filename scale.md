# Scale
+We will use load balancers for spreading requests

+We will split the application into functionality related services. Loosely coupled architecture. Thus if one fails, it doesn't affect other functionality. The web application can be decoupled by its tiers like

	++Static content tier(Content Delivery Network can be used for this)
  
	++Business logic tier
  
	++Permanent Storage Tier(a RDBMS can be used)
  
+Distributed caching

+If we are using ASP.NET. We will use TPL for long taking tasks.

+We will create indexes on Database for faster search.

+We can separate read and write sides of our data storage.

+We will use cookies to store session information for public data.

+Initially we can add more power to single machine by updating hardware. (More costly, not thinking ahead)

+We will use push based updates to read models and other application state through RabbitMQ.
