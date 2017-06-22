# Solution.md
 
 
* Auth
Using Auth 0 we can create an authentication service that allows us to have multiple social networks and also implement amazon IAM for company identification as well using RDS for Trawiller external users. https://www.youtube.com/watch?v=U3NDciLTTgI
 
* Media
Using amazon Lamdas we can create an API service that extract the metadata and upload the image,video and other media to S3 and save the link and data into RDS. 
https://www.youtube.com/watch?v=eOBq__h4OJ4
 
* Location
Using Website location for when the user is on the website and using background location service on mobile platform in an mobile application we can keep track of user location (assuming user will approve this). If we cannot determine location by GPS service we can use geoip service to give an estimate of location based on is IP address. 
 
* Front End
Develop a frontend that allow multiple media types I recommend to use a component based frontend development library such Vue, Angular or React to be able to have reusable components across the platforms. Also using react we can leverage react native for the mobile application and reuse component more efficient.
 
## Diagram Explain:

(system-context-diagram.png)
 
* APP EC2 Webserver. Will deliver the application to user and the public side api for mobile. This Web Server should run in elastic beanstalk stack with load balance in multiple regions. This can be a PHP application for the backend side with laravel. The front end application will be separated build from the backend.
 
* The user will then login from the front end using Auth 0 service will be able to login with social media credentials, or IAM users from AWS, or Basic DB based user system for Trawiller user. AWS Lamda will be responsible to handle the integration with Auth 0 and determine the federation of the user depending on the login source
 
* All the media will be stored into S3 and deliver with cloudfront to allow CDN and multi region fast delivery. This will also will reduce the cost of storage.
 
* We will use a MySQL DB in AWS RDS for hosting media metadata and post information. Also the external user system and the federations for the social login and IAM login.
 
* Amazon Lamda. Here we will have SaaS infrastructure for user, media and post management with the different entities. This way we separate the crucial logic into microservices that can be upgraded with almost 100% constant integration.
 
* Background services. This will run cron operations to notify user to post every day or highlights of his social life. Also this will run the background service for mobile app to track user location and recommend content according to this. ALl the notifications by email should be don using AWS SES delivery.
 
* Ec2 geoip: this service is a 3rd party application that can determine the location of an ip address when we cannot determine the user location by browser location service or GPS.
 
 
