# Scale

- As a Docker container, the application will scale horizontally on a Heroku-like service
- Some triggers can be configured such as mean response time and every time the mean response time rech some limit, another container will be automatic created.
- The service will be organized by region, and the scalability will work also by region separeted
- Once the application, database and cache will be individual containers, each one can be scaled separated, what could cost less money to scale
