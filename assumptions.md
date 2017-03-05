# Assumptions

- It's a simple service that only short the URL and proxy the requests. No admin area is available.
- In order to keep the requirements "With a variable time to live, after which they shouldn’t be available" and "We want to reduce the number of 404 we would return in case of an outdated short URL", a custom reason of 404 will inform the client that the URL is expired and also implement Cache-Control and Expires headers to inform clients about the expiration date.
- In order to keep the requirement "Short URL need to be quickly accessible across the world", PaaS system such as Heroku or Amazon AWS will be available with worldwide replication
- The availability of the system should be the same and doesn't matter how many connections there are and does not matter the costs that infinity scale could cause