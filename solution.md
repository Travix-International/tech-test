# Solution.md

I will try to build a solution for the scenario 1. URL shortener.

My approach would be:

Create a table with seven :) columns:

ID | LongUrl | Method | TinyUrlKey | HasBeenUsed | DateCreated | DateExpires

ID - integer auto-incremental.
LongUrl - String/varchar(MAX)/text for the URL we want to shrink.
Method - varchar(4) for GET or POST
TinyUrlKey -  UUID - GUID for MS-SQL for the key to find the url. Index this column
HasBeenUsed - Boolean/bit that determines if the url is hit
DateTimeCreated - Datetime for url date created
DateTimeExpires - Datetime for url expiration date

A service for travix to provide a way for the creation of new tiny urls, no matter wether they are automatically or manually created.

The service, that could be an ABM or a job, will expect a long url value toghether with a proper verb method get or post and the desired expire datetime.
I will save a record in the DB with the values for the LongURl, the verb method, the TinyUrlKey(Random automatic long enough key), false for has been used, current date time, and the date desired for it to expire.
Once done, it will return the TinyUrlKey, to be used along with the host trav.ix so: trav.ix/{TinyUrlKey}.

A MVC api should be hosted in trav.ix and will handle the user requests.
It will map roots http for GET or POST  routeTemplate: "{TinyUrlKey}"
Once client hits the url, the model will look for a record by using the TinyUrlKey from the url as the key for the "where clause".
DB will return the LongUrl, and the DateExpires as long as it sets HasBeenUsed to true.
If Current datetime is greater than DateTimeExpires then the server should respond with a 410 Gone.
If the verb method doesn't match it should respond with a 405 Method Not Allowed.
If the url has been used it should respond with a 308 Permanent Redirect
If the record is not found  it should respond with a 404 Not Found
If the url format is not proper 400 Bad Request

For other type of errors see assumptions.

If the URL is still valid, the server should redirect using the proper method to the Original (Long) URL picked from the db, not before adding the parameters, headers and body (if any) from the request.
