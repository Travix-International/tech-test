# Solution.md

1- Our system will be 5 part in general. trav.ix Web application for the creating request, Rest API for the handle the request and process business logic, distributed caching system for the store urls temporary, worker services for keep the both cache and database system datas in order, and the database obviously.

2- Web application : Basically users are creating their request with their input urls or reach their long urls with their short urls, nothing fancy and we don't have any specific logic in there except classical web security checkings.

3-  Rest API : Contains two operations within the REST Principles (check Question 1 for my concern about this) :
 	3a - GET /shorturl/{URL HASH} : 
 		Get the long url with short url hashkey from the cache system, if not get it from the db and save it to cache for later use. Check if the url has a one time use attribute, If the one time attribute used before, give the proper response (Either 403 or 404). Also check for the expiry date for the item, if item expired give the proper response (410 in this case). If the item not one time attributed or used before and not expired, return the item's long url (200). You can see Question 4 for my concern about this operation.

 	3b - POST /shorturl :
 		First check the original url in the caching and db system if we created hash for this url before and it is not a one time url and not expired. If the condition is right return the short url that created before (200), otherwise create the new url and add it to the cache, and finally return the new short url (201). One time using and expire dates are optional for the user. Also there is a hashing algorithm will working in this case. You can see Questions 3 & 5 for my concerns about this operation.

 4- Distributed Caching System : A Caching system that connects to API to database, basically if you have it within the right conditions, don't bother db.

 5- Worker Services : Classic scheduled services to maintain order in system. within the given times and durations, check the db and update state of the expired and one used items, as well as caching system. You can see Question 2 for this operation.

 6- Db : A No-sql solution, nothing fancy with data, minimal item complexity for writing, minimum read operations because of the caching layer. No relation, no transactions. Check Question 5 for this part.