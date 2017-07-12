# Scale

The first step to scale an e-commerce system is to use a specialized solution
like ElasticSearch or similar. Querying and searching are core features (and probably the most used)
of any e-commerce system therefore the foundations in which you built must be
solid and effective.

You should also deal with the usual subjects, using load balancers (like PM2 for node), caching using
e-tags headers or other caching strategies could serve to relieve the pressure on your servers and save
bandwidth. Minifying scripts, stylesheets and optimizing image resources can also help to achieve this goal.
Optimizing code execution time saves precious ticks which could save both money and time for everyone as
you scale.

Using clouds services, micro-services and serving static resources without hitting your servers could be an
effective choice to off-load the cargo to a third party which is specialized in the task at hand.

Scaling horizontally or vertically could be constrained by the hardware-tooling decision but usually
horizontal scaling gives you better availability and zero down-time. Usually database is the bottleneck
of every system so an efficient pooling of connections and efficient query (and paging capabilities) of
data could make all the difference. If the volume is too big you could also consider multiple availability zones,
eg your resources served from low latency links.

As rule of thumb e-commerce sites choose availability over consistency unless
another factor comes into play.

