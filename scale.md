# Scale

Since this is an Azure web applciation, both the database and the app can be set to auto scale according to the current load of the system. 

## Optimizations
Few optimizations can be added to the system for furhter scaling as the use of the application grows:
- **Pagination of the timeline**: the backend will send the timeline in batches of X number (example 10), with will be viewed on the APP's screen, as the user scrolls down, the next batch will be fetched from the server.
- **Caching Backend**: cache the last 10 posts of every user using some of the available caching solutions available on Azure (ex. Redis)
- **Caching App**: cache the last 10 posts of the user including the post data in the app, validate the data since the user may have more than one app.