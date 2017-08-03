# Solution.md

Trawiller is a simple concept, but relies on a scalable architecture that minimizes the impact of sudden demands in traffic.

### Architecture

- Load balancer to distribute the traffic across the web and API servers.
- Message brokers (Rabbit MQ) to decouple services for the following
  - Process and store images, videos, VR and other media, huge documents.
  - Analytics
- Use a cache service (Memcache or Redis) for the following
  - Expensive queries that don't need to be updated very often
  - HTML Fragments
  - Data that were determined to be accessed frequently
- Use cron jobs to check which users have not posted in the last 24 hours and fire a notification to the user(s).
- Storage that will allow for horizontal scaling with redundancy.
- Blob storage, could be Google cloud storage or Amazon S3
- Content delivery network that should deliver static files (css, fonts, js, images)

## Anatomy of Trawiller

#### Frontend
Single page application (SPA) based on Angular JS or Redux for the frontend.

- Login page (see screens/trawiller-login.png). It should not ask for emails, however user will be required to prompt an email just after the first login.
  - Login with Google, Facebook, GitHub, Slack, even Twitter
- Timeline (see screens/trawiller.png)
  - On this screen, the user should be able a new page so they can post a new article, review, pictures, videos etc.
  - Pictures uploaded from the desktop version of the application should be able to capture and forward the EXIF metadata to the API.
  - The user will be able to see their own content as a stream of events in chronological order.
  - In order to build a sense of community, users should be able to rate, bookmark and share any posts.
- The dashboard page should redirect to a page where the user is able to change its own settings such as: main language, permissions, suscribe to other login services, manage their own content. 

#### API Service
Use ASP .Net (C#) for the core language and consider the following aspect when developing the application.

Its job is to process any request to upload any media, and offload the processing of said media by notifying to the message broker. The relevant service should be able to act accordingly and store the information once the task is completed.

It should also process the authentication process with Google+, Facebook, twitter, slack etc.

#### Smartphone Application
Its job is to upload pictures through the API, and to make sure that the picture does have the EXIF metadata, so that it can be parsed by the API.

On the screen screens/trawiller-smartphone.png, the user should be able to track the user movement by recording the user's location on the background, and notify the user when in proximity to a sighseeing spot or a place of interest.

Any picture taken during the course of the trip, should be associated with the trip.

Finally, the user should be able to receive a reminder from the app if they haven't posted in the last 24 hours.
