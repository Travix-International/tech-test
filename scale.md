# Scale

100 - 10,000 users per day, a single server with memory caching will be sufficient.
10,000 - 1,000,00 a day - A single Redis Node will be able to cache and pre-load a hashtable of data from database into memory.
100,000 and above - add couple more Redis nodes or add hosting servers in geographically seperated areas.