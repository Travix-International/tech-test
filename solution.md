# Solution.md
+ Multi-tier application design(front-end layer, data access layer, Business/service layer)
+ Micro-service architecture design (framework like .Net core )
+ All of database operations will be managed by an ORM(Entity framework is a good option)
+ If possible use recent versions of front-end frameworks like Angular, React and bootstrap
+ Responsive design
+ Use Typescript for all of the client Javascript code
+ Automate most of the front-end tasks (minification, concatination, linting...) using Gulp
+ Localization and Globalization
+ Sessions and cookies to save the customer cart items...
+ Unit tests for backend and front-end code (Nunit, Qunit, KarmaJs)
+ Integration tests and load testing
+ Use a CI (Jenkins or Teamcity) to automate builds from the master branch then push the binaries to a binary Repository manager (like Artifactory)
+ Use an automated release management tool to deploy newer versions of the binaries (Octopus is a good example)
+ Monitor both servers and Application (New Relic or similar tool)
+ Use a log management tool (like sumo logic) to log any possible errors/warning from the application and monitor their frequency
+ Security and penetration tests
+ Caching wherever possible (Application, HTTP, Database)
+ Use a secure Load balancer that point to multiple servers behind the scene
+ Use a CDN provider (like Amazon CloudFront) for all static files (CSS, Js, images)
+ Don't forget about developers so use API documentation (swagger or similar tool)
