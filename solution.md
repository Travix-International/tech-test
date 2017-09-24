#Solution

A possible solution for this simple shopping cart system would be to create an N-tier application (SPA, application server and repository). 

This solution would be hosted on Azure for a number of reasons including scalability. It will use ASP.NET Core, SQL Server and Redis.

##Font-end SPA
An SPA is recommended since a shopping cart won't need SEO and also provides a better UX (no reload).

Angular or React could be used for this depending on the skills of the dev team with Bootstrap for responsiveness.

##Application server
Hosted on Azure App Service, an ASP.NET Core application for the BT/API of CRUD related actions for the cart. Redis should be used for the session store.

##Repository
Entity Framework Core using SQL Server as the main repository (implemented using DI so we can switch repository in the future if needed). 

Using CQRS for the cart would be recommended for scalability. Two services will be used for this:

* The writing/command service will point to SQL Server (adding/removing items). 
* The reading/querying service will point to Redis. When the content of the cart is changed in SQL Server, it is serialized and updated in Redis.

I have included a draft for the database diagram.