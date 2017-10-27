# Solution.md
The solution that we propouse it is a micro service architecture, that has a main web app connected to 2 WEB Apis (HR service and JIRA service) that will used HTTP methods to the personal information as well as the tasks information.
The request as well as the reponse will contain the information in a JSON payload and when all the information is collected it will get processed and sent over to the client for review. 

Front End Technologies:  
#React and redux for JS rendering and managment  
#Materializecss for stylings  
#React google locing comonent for the SSO connection
#LocalStorage will be used to save up the HR informaiton to avoid multiple fetching on an information that is not likely to change

Back End Technologies:
#ASPCore web api project that will connect to the corresponding system

Databases:
#SQLServer will be used to store information (User/Pass)

SAMPLE Messages:  

Default JSON Payload: Sent by the user to the JIRA service after he selects a week to show    
![picture](/img/Default_JIRA_Request.png)  

JSON Recover task by ID: Sent by the user to retrive particular tasks  
![picture](/img/JIRA_Request_By_Task_Id.png)  

JIRA Reponse: JIRA response containing the trask information  
![picture](/img/Default_JIRA_Response.png)  

HR Reponse: HR response containing the persons information  
![picture](/img/Default_HR_Response.png)  