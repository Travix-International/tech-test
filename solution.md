# Solution.md

THRESH  
The design will be made composed by a backend and a frontend.
Backend will be responsible to retrieve the data from JIRA and HR Payroll APIs, these apis will be accessed by a proxy class that acts as a gateway to map the context from these systems into the data we need, it will also provide access to a database by using the repository pattern and a micro orm like dapper or petapoco to as Data Access.  
It will also provide an API to expose the endpoints required for the client to access the data for reports.

Frontend will be a single page application, that will display the data and filters needed by the user to generate the required reports.


![](system-context-diagram.png?raw=true)