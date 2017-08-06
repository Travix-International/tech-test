THRESH Solution
===============

 

THRESH System is composed of three tiers:
-----------------------------------------

 

### THRESH Backend tier:

-   Responsible for collecting needed data from different systems (JIRA, HR
    Payroll, etc).

-   Check users permissions to view/mange reports.

-   Expose REST API to handle different requests from front-end layer.

-   Save data in database/locale storage

### THRESH Front-end tier:

-   Front-end SAP used by user to manage, view and generate needed reports, this
    layer will populate coming data from backend according to our desire.

### Database tier:

-   Data store layer, it could be POJO stored in a List or Map or could be
    in-memory database like HSQLDB or NoSQL database like MongoDB.

 

### Sample backend API:

GET /stories/ : used to request stories. The request payload parameters can be
as the following:

-   **id:** array of story number (Optional) if not sett, service will retrieve
    all stories for given assignee

    -   **assignee:** array of engineer username or team name (Mandatory)

    -   **week:** retrieve stories in selected week.

    -   **status**: status of story “I” in progress, “D” developed, “C” closed
        (Optional)

    -   **type:** “S” for stories “N” for non-stories, defaults is “S”

    -   **groupedBy:** to group results by kind Development, Meetings, Out of
        office, etc. (Optional)

    -   **startDate:** time stamp for story when engineer start working on it.
        (Optional)

    -   **endDate** time stamp when story developed. (Optional)

 

THRESH Front-end SAP can use the response from the above service to generate
needed views for example display report with weekly worked stories, display
report with consumed hours, generate report for worked stories for any engineers
or team.

 

 

 

 
