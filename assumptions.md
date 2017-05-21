# Assumptions
* Connect to JIRA to retrieve stories worked by our engineers or their team in the selected week

  I would assume that we work with any type of issue, not only stories since it's can it have different meaning in different systems
* Allow for any number of stories to be added by the user

  I would assume that user sees the issues assigned to him and can manually enter either issue number or "custom activity" (everything he wants which does not have formal identifier)
* Hold the least amount of data per employee, because this is not a HR system, just a time recording system

  I would assume that we query work-tracking system or HR system when we need to get user data to avoid storing it in our system which should be SaaS ready, so we store only uderIds which should be formed to eliminate any possibility to identify a user
* Allow for managers to review other members’ hours, but only their reports and sub-reports, not just anyone
  
  I would assume that every employee works on one project for hist contractual hours
* Generate reports for a time period, e.g. a month, including the number of hours per employee, per kind, per story, etc, in multiple dimensions
  
  I would assume that we can get data not later than for previous day to provide better performance, UX, consistency
* Take into consideration that if this THRESH system is successful, we might want to spin it out as its own product and offer it to the public as a SaaS."

  I would assume that JIRA nd HR system are subjects to change with significant chances, so they should be well abstracted event if the 
solution does not go to SaaS

	I would assume that on initial phase we don't need to put much efforts in SSO provider abstraction since adding of new providers looks rather simple in modern world provided by highly standartized protocols and various liraries for each technology stask
