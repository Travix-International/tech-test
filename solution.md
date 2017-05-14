# Solution.md URL shortener system

An administratoe will Input Long URL and choose between the available options (Expiry, One Shot and Method [POST, GET]). System will validate:
1. URL Format
2. 200 Ok
3. DB Existence

and then
1. Encode full URL, the goal here is A) Preserve as-is URL B) Security protection XSS and SQL
2. Generate UUID mixed alphanumeric which A) Should be unique B) 5-characters will cover the required no. of shorten URLs .. can be scaled
3. Save URL in DB


DB:
1. Primary key is the short URL, makes sure faster SELECTS which will be significantly used more than insertion
2. Single table is really required, unless analytics, user management and other features are required

When an end-user (could be a machine) requests for the URL:
1. It is brought from DB, checked for OneShot and Expiry
2. If GET it is straight forward optimally should be 307 redirection. Thank you.
3. If POST the requested data is passed to the long url, response is captured and passed back to the requestor. 

Why POST is like this? Other solutions could be:
1. Redirect using 303 to destination, but I've seen issues redirecting POST blinding through F5 firwalls, special rules will have to be applied for this. Could be added as an option also.
2. Generalize 302 redirection for GET and POST

Furthermore:
1. When expired / Oneshot / 404 and requested by end-user, system will detect and mark Deleted field in DB = true
2. Graceperiod will be given for a Deleted URL (e.g. 3 months) before it physically deleted from DB (or re-used)
3. I prefer to do the checks for each Found Record rather than a Job running every day because A) Real time detection B) Jobs increase resources consumption but per request it is distributed bit by bit
