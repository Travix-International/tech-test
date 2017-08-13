# Solution.md
I selected the URL shortener scenario because I had previous experience witth http redirections and I think is very clear and straightforward scenario.

The solution will consist in a restful .net core web api that will have two main functionalities:
1.-UrlShrotener: 
	- It recieves a post with the long url, is one shoot boolean and a time to live in minutes.
	- Validate string for a valid url
	- Generates unique identifier
	- Save Url in database
	- Response with 200 status and the short url like http://trav.ix/t75yn4
2.-UrlRedirection: 
	- will have one GET and one POST endpoints with routes that takes the identifier as the Id
	- GET:
		-Will search for the id in cache if present return it, if not search database and add it to cache (with ttl of 20 sec) and return it
			-if one shot remove it from database and cache
		-Make a 301 redirection(to make client browesers to cache)
	-POST:
		-Will search for the id in cache if present return it, if not search database and add it to cache (with ttl of 20 sec) and return it
			-if  is one shot, remove it from database and cache
		-Get headers and body
		-Make a post to the long url
		- Response with results to client
		
Infrastructure:
Hosting.- Azure web app service is proposed for hosting the web api
DB.- Database will be a documentDB database with single partion to handle quick reads and TTL to automatically remove expired urls (Generated identifier will be used as id)
Cache.- A redis cache is proposed to minimize database calls.
Note: All services must belong to the same resource group.

