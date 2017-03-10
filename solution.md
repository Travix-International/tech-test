# Solution.md

URL shortener system
--------------------
- Our system will contain a Web Application, Memcahced and a Key Value persistant Database.
- Our Web Application will accept a url and generate a hash key for the url.
- We issue a Get request to memcached with the first 6 characters from the key and return that key as the URI for the URL if the key exists and its value equals to the requested URL, if the value is different, that means we have a collision and we increase the number of characters taken from the hash by one to avoid the collision, and so on.
- If the key does not exists in memcached, we try the same as above from the DB.
- If it neither exists in memcached nor the DB, then we store the key/value in DB and memcached and return the key as URI.
- Whenever we receive a request to a URI, we check if the key part of the URI exists in memcached, if not then DB, and return a redirect to the value URL if it exists, otherwise we return a 404 not found.
- We support ephemeral URLs by including a Time-To-Live with hours, and also a One-shot, and these options can be set when generating new short URLs.
- The Value generated will consist of comma delimitered Value as "One-Shot,TTL,Generated-Time,URL"
- Whenever we have a One-Shot key, then we delete the key whenever we receive a request for that key, and we will have a separate service that run daily to remove the key/values with its TTL expired.
