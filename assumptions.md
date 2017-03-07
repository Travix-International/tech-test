# Assumptions

1. The system architecture is cloud based, holding the redirect micro-service instances in containers. eg. EC2 / Dockers.
2. The database is a NoSQL db, eg. MongoDB.
3. There will be a CRUD system to manage the redirects DB collection. eg. Manually create new short url pointing to long url.
4. The target web server (where the long url lives) will accept only requests from the redirect micro-service, it needs to send an authorization token in header for the web server to accept and process the request. This will avoid unauthorized clients to request directly (using the long URL).
