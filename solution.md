# Solution.md

From reading the requirements for Trawiller, I would propose building the platform creating individual micro services grouped within a virtual containers. 
We can then deploy these containers to a cloud plaform which will then host and serve a REST API for the web and mobile applications.

My reasoning for this is as follows: 
- To facilitate efficient dev ops 
- To contain most of the important services infrastructure within one place 
- To allow us facilitate automatic scaling of micro services when required
- Use of containers for efficient utilization of resources on a host to prevent over-provisioning and increased costs. There may even be microservices that do not require all the resources of even the smallest server instance type.

On the client side:
- To cater for both desktop, web and mobile apps on the client side we can use the client side javascript library React. 
- My choice of React is to allow for code reuse between our web and mobile app code base. 
- For this purpose we will use a ReactXP which is a library for cross-platform app development by Microsoft.

Catering for some of the required functionality:
- Create a service using OAuth to allow users to login and register with Trawiller using their existing social or service logins.
- Creating or use a common tagging library for IOS and Android with an EXIF parser to automatically tag media files with location and other data.
- Build common local notification library for IOS and Android to send the user location for the Trawiller app running as a background service worker on the phone. If the user sets permission for the app to do this.
- Utilise a queuing service to be used as a worker to seemlessly schedule large uploads.
- Utilise a caching service to reduce the need to fetch media files.
- A REST API will have to be built with end points to show posts filtered by day, month or year so that the user can navigate a stream of events within the user interface based on day, weeks, months or years.
- A scheduled micro service is required which will run at a certain time of day (based on the users timezone) to remind users via a push notification (to the device) to post something for that day if they have not posted anything.