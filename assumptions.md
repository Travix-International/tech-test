# Assumptions
+ GET or POST requests is supported by the system.

+ Our system would be read-heavy; the timy URL is supposed to be a lot of forwarding requests that assume 100:1 ratio between read and write. We can have REST APIs to expose the functionality of our service. 

+ Traffic Estimation: 
    + create 100M new URLs per month
    + expect 100 * 100M => 10B redirections
    + New tiny URLs per second(in a per month):
	  100 million / (30 days * 24 hours * 3600 seconds) ~= 40 URLs/s
    + URLs redirections per second:
	10 billion / (30 days * 24 hours * 3600 sec) ~= 4K/s

+ Storage estimates: 
    + The system is designed for 5 years.
	100 million(per month) * (5 years * 12 months) = 6 billion
    + Storing data can be 500 bytes(each object), so we need 3TB of total storage for 5 years.
	6 billion * 500 bytes = 3 TB

+ Bandwidth estimates: 
    + Expected 200 new URLs (every second), so it would be 100KB per second.
	200 * 500 bytes = 100 KB/s
    + (URLs redirections per second) ~4K/s,so total outgoing data would be 2MB per second for the system.
	4K * 500 bytes ~= 2 MB/s

+ Memory estimates: 
    + Used cache mechanism for the URLs that are accessed frequently. [80% - 20%(from cache)]
    + Serving 340 milion requests per day(3600 seconds * 24 hours)
	4K * (3600 * 24)(per day) ~= 340 milion
    + The system would be needed 35GB of memory (for cache)[20%]
	0.2 * 345 milion * 500 bytes ~= 35GB

+ Created URLs include trav.ix/{givenChar}
    + Lenght of givenChar is 6 characters.
+ F(URL) = alias and satisfies conditions
+ Each URL can only be mapped to a unique alias
+ Each alias can be mapped back to a unique URL easily
+ Each DBs are backed up at certain times.(using DB is NoSQL like Cassandra)
+ ELK(ElasticSearch, LogStash, Kibana) is used for system analysis and indexes.
