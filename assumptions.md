# Assumptions
1. HR data is stored on localStorage since it changes very little in time hence the constant travel back and forth between the app and the api are not needed
2. Manual update will be giving to the user if they know HR data has changed
3. HR Api will return a list of reporters and sub reportees if any are found
4. JIRA will store a row on its data base for every tasks that has its hours updated and it will record the amount of hours worked
5. If the person making the request has no employees under his charge then the HR service will return an empty list for the employeeList field  
6. JIRA and HR have interefaces o their side that will alow connection to our APIs  