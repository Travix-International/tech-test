# URL Shortening system.

URL shortening system can be built using the following.

1. An intuitive UI, where the user can paste his long URL and get it converted to a short URL. The web interface interacts with a REST Api to post the URL.

2. The business layer of the application contains logic to generate a unique alphanumeric key, and persist in the database via a data access layer and a repository. A single table will be sufficient to hold this alphanumeric key and the actual URL and link expiry datetime.

3. In-memory or distributed caching should be used in the business layer, so that recent and frequently requested short URL’s can be kept in memory, to reduce the server load. Al algorithm can be used to calculate the frequency of access, and a rank can be calculated to prioritize the caching stack.

4. When a user requests a short URL, the Api gets the data based on the key passed via the URL (like http://shorturl.com/xy123, where xy123 is the key) and gives a Status 301 Moved, with the actual URL, passing all the query/post/headers with the request, so that the user reaches the final site transparently.