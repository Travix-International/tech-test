# Solution.md
* Build a system that connects via REST API's to get the required data from JIRA and the HR Payroll System
* Use Google SSO as the authentication platform
* Use NodeJS as the backend platform/language
* Use MongoDB as the database layer and store user information as rich documents
* Use ReactJS to create a rich interactive front-end application
* Use server-side rendering with NodeJS and ReactJS to deliver a performant first load of the application, possibly hydrating the state
* Setup up indexing on MondgoDB fields that are frequently access to speed up reporting queries
* Store only the user id, and time logged in the database
* Use AWS lambda as the hosting platform is it's extremely reliable and can easily integrate with a continous integration system
* Write a database query that takes as input the week-of-the-year, this query only returns stories for the requested week
* Enable tags on each story(document) inside the db, this will enable grouping of various categories that the user specifies
