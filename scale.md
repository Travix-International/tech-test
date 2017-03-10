# Scale
- Create a duplication of the servers on different regions.
- We will need a master database to hold all the updates
- For every region we will have several memecached servers, and keys will be distrbuted between all of those servers.
- we can use mcrouter to bundle several requests from the web servers to the memcached servers.
- We will need a service that updates the memcached servers in the different regions with the committed contents on the master server, and a service to replicate the master DB to local databases in the different regions.
