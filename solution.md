# Solution.md
Implement Single-Sign-On with external providers
Our membership will be managed by externals providers, and we are going to storage the identity of our users.

[Image: OAuth2_Diagram.jpg]
Image credits OAuth2

Managed Meta-tags
The images metadata will be gather by the client applications (website or mobile application). Trawiller backend platform will provide an API to create Post which will receive the tags attributes.

[Image: Posts_Diagram.jpg]

User Tracking
Ours web front end applications will gather the user location, with an implementation of AlarmManager or equivalent for the platform. The process will run every hour to get the Last Location and send it to our API.

Managed Big–Files
To allocate big files and long text Trawiller Back-End will use a Blob Storage and Blob Cache instead SQL. After the upload is completed the Back-End will generate a preview from the text and files and will storage it in the Database. When users will be browsing the timeline, they will see the previews allowing a smooth browsing experience but with the option to see the original text and files.

Stream of Events in Timeline
Trawiller Back-End will analyze the top posts that you have base on numbers of mentions that they have. It will be by day, weeks, months and years.

Post Reminder
Trawiller client applications will have a timer job that will run every 24 hours and will check if the user didn’t post anything and if not will remain them to post. 
