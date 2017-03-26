# Solution.md

We have a couple of node.js micro apps,

Web-hook listeners for JIRA, Trello
* Whenever a card is moved to in-progress, the Associated developers/designers will get an indicative entry which will be marked as started/in-progress,
* Whenever a task is mark as done, the time from start (excluding offhours) will be used to denote the task.

![Arch Diagram](/time-log-arch.png)

### User Service
Connects to the HR module to get minimum required details of the User,

Integrated with Google SSO,

Connected to MySQL Master-Slave Replicated Server.

Integrated with Auth Service.

### Stories Write Service
Connects to the Highly available MongoDB Tenant DB's to write stories,

Provide API calls required for writing stories etc.,

Pushes new stories to event-stream through Redis pub-sub channels,

Integrated with notification service like twilio.

### Stories Read Service
Reads/ Indexes stories from MongoDB, uses Redis as a cache,

### REST/GraphQL Service
REST Router along with the Auth (Authentication & Authorization) facilitates the user roles, stories entry etc..

### Good - to - have feature, - I hate manual time logging.
Post-hook receivers for Bitbucket/Github
* Whenever a commit message that matches with the tasks listed are pushed, it can be added to the task.

Event-watchers for Google Calendar, GotoMeeting
* Whenever a new meeting, related to the project is added, all invites gets an time-log entry with other details,
