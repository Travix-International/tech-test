# Solution

We were able to do the same with a shorter URL instead of a long URL. Users can access the link associated with the long URL, as well as the original link with the short URL. In places where there is a character limit (such as tweet or print), it will be easier to share in any medium. It is used for optimizing links multi platform devices, tracking individual links to analyze and check to performance, and hiding original URLs, etc.(like e-mail)

Short URLs for long URLs will be created and these related actions (NoSQL hypothesis) will be kept on the system with the User, URL and User-URL table. The incoming request will pass through the Load Balancer before reaching the system and reach the server. The system will cache the relevant short URL via Load Balancer. it will be check to see if it's found in the Cache. If not, chech the DB. When it is found through the DB, return to Server and update the cache.

Application checks the URL validation. (It may be expired or not authorized.) If there is no expiration and there is authorization on the system, long URL will be redirected. If not, return the object (the code and the message).

In this way, both GET / POST systems will be used. Security will be checked for user permission. It will work through multi cache and distributed system for faster response. Job Scheduler and Serverless systems and other used URLs from unused systems in the DB will be put into the table. DB backups will be received.


The system is used for URL-shortener that supports GET and POST type of requests. With some assumptions (6 character length and noSQL solutions used, etc.) the system was created. Designed to be used as a web API. The system gives some features;
* Ensure that system security requirements are met (eg Oauthv2).
* Its role as serverless or time scheduler is designed to provide backup of the system.
* POST - API
  * creates a new shortened URL (hash)
  * original-url: original URL, to be shorted
  * time to live expressed in minutes being the default value 1.
  * max-reads: maximum number of reads  
  * required fields_ (user_name etc.)

After the operation, register a key-value pair with a complex object that equals the shortened Url of the key and contains all the request parameters and the number of reads.
If it creates successfully, return 200 / 201. If not, return object for error code, error msg.

* GET - API
  * to return its content for given a tiny URL
  * first of all, look Cache system (Redis)
  * when it is found and available, return content. If founded item is not available, delete from cache and returns the 410 page.
