# Solution.md
The solution that we propouse it is a micro service architecture, that has a main web app connectyed to 2 WEB Apis (HR service and JIRA service) that will used HTTP methods to the personal information as well as the tasks information.
The request as well as the reponse will contain the information in a JSON payload and when completed the information is presented to the user for review.
High level Solution : ![Alt text](/img/High level solution.png?raw=true "High level solution")
Note: To handle the integration to google sign on we will be setting up identity4 on the main project.

Default JSON Payload: Sent by the user to the JIRA service after he selects a week to show    ![Alt text](/img/Default JIRA payload.png?raw=true "Default JSON")
JSON Recover task by ID: Sent by the user to retrive particular tasks ![Alt text](/img/Payload for specific task.png?raw=true "By task id")



