# Scale
At the time the url is being generated, it should be stored in a reliable fast I/O data store. 
I propose saving urls both in a NoSQL database system and in redis cache. so the system will first query the cache
and only query the database as fallback.
I also propose using reactive(Non Blocking I/O)