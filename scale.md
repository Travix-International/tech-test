# Scale

For smaller scale application, we can store the whole basket in an RBDMS and perform most of the functionality on the server back end but for higher traffic sites this can become a problem very quickly.

For higher scale applications, we should consider using database that supports sharding to scale out the heavy traffic load and increase availability (possibly noSQL database like Cassandra or Mongo depending on the final design of the data model). 

We should design the system to use a very lightweight API possibly deployed over a series of cloud servers, and then offload most of the processing work to more heavyweight client application.

Client Caching can be used to reduce the number of server calls - eg product information can be cached to local storage

Image assets can be stored on a seperate node, and javascript and CSS files can also be stored on different nodes, or delivered via CDN. Use bundling and minification of javascript as much as possible and optimise product images to appropriate jpg quality. 

Instead of using a single large image scaled down in the browser (eg using img-responsive class in jQuery) serve different sizes of images for different pages, eg, main image, zoom image, thumbnail image, product listing image. the different image sizes should be pre-rendered when a new product is added to the system

Microservices software architecture can be used to enables multiple services running on different processes. Each service can focus on a specific set of tasks and be individually updated by different development units, and code optimisation is much easier on smaller services. 

We should avoid using sticky sessions. Use RESTful services to get and post data and pass the ID of the currently loaded basket to the client on each request.

Set a reasonably small response time limit on asynchronous API calls to prevent user frustration

Use throttling or debouncing on the client application to prevent multiple api calls eg if 'add to bag' button is pressed lots of times by accident.

Make as much of the client application asynchronous as possible.

Frequently refactor code to enhance application speed and use server load metrics to monitor any bottlenecks. Run code optimisation tests on each build.

Use tree shaking to eliminate redundant code in javascript, do this as part of the automated build

Use a high traffic cloud plaform like AWS

Use a lightweight and distributed web server technology like NodeJS rather than more heavy Apache or IIS web servers.





