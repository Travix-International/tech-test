Scale
=====

 

When number of users increased from 100 per day to 10000000, this means a
hundred millions of requested could be send to our backend and from backend to
JIRA to get needed stories to generate reports.

 

From software respective its time to think about implement our caching system to
speed up data lookups (data reading). Instead of reading the data directly from
source (JIRA) and we need to keep cache and remote system (JIRA) in Sync. There
are many different techniques to do that for example: write-through-caching,
Time based expiry and Active expiry, etc.

 

From hardware perspective there are two directions of scalability:

-   vertical (scaling up): faster CPU, more RAM, more disk space;

-   horizontal (scaling out): more cores in CPU, more CPUs, more servers;

-   load balance servers

 

Also we need to think in functional programming style as option as it will
covert our solution to peaces of code the can work independently.  

 

Finally, We can move our solution to the cloud environment and/or using virtual
machines to take advantage of greater scalability. Being able to access more
resources on demand gives your business the ability to deliver a superior
end-user experience to both internal and external customers. Applications can
run faster and can handle high Web traffic spikes with fewer disruptions to
service.

 

 
