# Solution.md

Timix will be a time recording application used to map user log time from Jira tasks with the contracted time for each user, but also Thresh between users and tasks.
Application  retrieves team tasks from Jira and also retreives contract details HR system and write it to a database engine

A UI/Webbased with several views  provides functionality user to map his workload or manage tasks  but also he can  export reports of his worklog .
Applicaiton will manage permisssions based on group types of users the application provides permissions to different level

Application will need 3 instances Application Server ,Rest Server ,Database Server

REST Server
Will host REST Services and connections to the database and to all external APIs
Rest services can be builded in Java  .net or any Server language that can provide Json-Objects with error responses and services have to follow the company standards for REST Services and Audit fields 
Https Is recommended if public access is granted 
Cache engine may need to be applied in order to provide Check in Check out Functionality 
Very important is the REST server to Create logs of each call for incoming requests but also for there responses 
Logs can be on files , or database records and we need to be able to detect errors dynamically 
I have provide a quick diagram for 3 services but in case of real project services has to be designed with more details 


Database -Engine -Storage 
Will run storage Engine 
Database can  be created for the specific app with  any Sql engines but recommended to use is elastic search or similar .
https://www.elastic.co/products/elasticsearch 
on case of using normal database engines more details data design has to be added to this Document.

on the case of elastic search as  the engine is RESTful  REST classes can be avoided and all requests  can be pointed directly to the engine 

Application Server 
will run Apache or similar for the UI needs and will serve only the front end 
Gui is one of the most important parts of this application 
has to be quick and user friendly without many input requirements. 
Will be a plus  many functions to be automated in order to make user experience fast 
Recommendation for front end framework can be  Angular Js or Ext-js or any similar js framework object oriented
angular material or Bootstrap  framework has to be applied in order the user to be able to login in parallel from several devices also mobile 


The above design is  Proof of concept and is NOT complete design , several diagrams has to be added in order to be functional after decisions that has to be taken .




