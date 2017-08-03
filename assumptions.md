# Assumptions

1. Work with the EXIF data of the picture to extract the relevant information (Location, camera model, date, time, weather).
2. For security reasons the EXIF data when is stripped before uploading pictures from any browser. For this reason we assume there are applications made for smartphones and tablets that will let Trawiller capture the EXIF data of every picture.
3. The smartphone/tablet application is able to capture location and weather information while running on the background.
4. There is a blob storage services to keep pictures, videos, books, VR, panoramic media etc. The service of choice is scalable and can make data accessible from any part of the world. 
5. Assuming a relatively simple data structure, Trawiller's storage is constructed over a non relational database, such as MongoDB or Cassandra. The storage of choice should be able to scale horizontally when faced with a sudden influx of queries.
6. There is a content delivery network service that can serve static files.
7. The users are able to login to Trawiller using third party authentication services made avalaible by Google+, Fb, Twitter etc using oauth2. User provided their email account the first time they login into Trawiller.
8. There is a message broker service that will decouple different services from the API and Web servers.
8. There is a staging & production environment, with staging environment being almost identical to production. So that developers and managers are able to perform QA checks and acceptance tests.
