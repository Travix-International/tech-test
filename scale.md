# Scale

- Load balancer can use least used or lowest latency techniques to manage server routings better when high load comes to your servers.
- First level cache can be stored in memory of each server for some lookup values that are not change frequently.
- Second level cache can be enabled to reduce database calls. This can be distributed cache system like Redis.
- Micro service architecture can be used like product service, discount service etc.
- Micro services can be host in containers to make deploys easy and when you need to scale up it's easy to deploy new container with service which has high load.
- After purchasing all of the operations (like stock decrease, sending mail to customer etc.) related with order can be handled in parallel (in another thread or can be handled by another service).
- HTTP reverse proxy solution (varnish) can be used for frontend cache.
- CDN provider can be used for static files and there's no load on our servers for static files like images of products.