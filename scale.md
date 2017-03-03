# Scale
Once I've choosen to make a nodejs app, scalability must be provided with an external tool, due to the fact that NodeJs is strictly single thread process. I've decided to do this with Cluster that lets you launch a cluster of Node.js processes to handle the load.

On the persistency side mongodb is already scalable by itself.

To increase speed in responses i've decided also to add a cache level implemented via Redis. Morover with a wise use of the timeToLive option we can let redis "forget" old orders and carts.
