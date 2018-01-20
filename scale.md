# Scale
- usage of Azure table storage (NoSql) makes our service relatively faster than if we had choosen any other DB model (SQL), plus its cost effective.
- We can use async requests to minimize blocking request threads on the web server.
- Mentioning the request/response model approach of our app, we can use Azure storage queues to send messages while returning immediatly. We can then consume these messages and process them. This will optimize the usage of async calls.
- Caching will be important part of our app, for this purpose we can use Redis cache in Azure which make our app more responsive even if number of users load increases by keeping track of chached records.
- In order to reduce app downtime when there is a failure or when there is a very high load (time outs), we can make use of load balancing techniques and to do so we can use Azure traffic manager by making our app more responsive while improving content delivery and by monitoring the service and directing new requests to another location when load is heavy.

![Short Url scaled web app design](/shorturlscaled.png)
Short url service scaled