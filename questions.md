Questions:
* Connect to JIRA to retrieve stories worked by our engineers or their team in the selected week

	It is exactly about stories or just about "atoms of work" which can be tasks and subtasks which generally apply because in JIRA you can't assign issue to multiple person?

* Allow for any number of stories to be added by the user
	Does that mean that user can create "story" which does not exist or he can only add it as "custom activity"? 
  if the first option applies then how we check identifier consistency?
* Hold the least amount of data per employee, because this is not a HR system, just a time recording system

	We anyway have to store firstname and lastname of employee, otherwise software can be quite unusable (see questions about  SaaS)
  
	Should we abandon the idea of sroting employee data at all?
* Allow for managers to review other members’ hours, but only their reports and sub-reports, not just anyone

	Manager can view tasks of subordinates. What if the task belongs to the project that this manager can't access.
  
	E.g the subordinate works only part time for this project. 
  
	We still can show the task name but when we try to go to the task we will get "Access denied" which lead to bad UX and/or quite complicated cross-system permission setup
  
	HR system should be able to return amount of hours for the employeer per project otherwise there can be huge time mismatch 
	
* Generate reports for a time period, e.g. a month, including the number of hours per employee, per kind, per story, etc, in multiple dimensions

	How are users/agents/consumers
  
	How real-time should it be?
* Take into consideration that if this THRESH system is successful, we might want to spin it out as its own product and offer it to the public as a SaaS.

	we need to abstract system from JIRA and HR software because future clients probably won't use this specific combination.
  
	How should we deal with various regulatory requirements like
	* we can't store the data that can identify user (firstname, lastname, email, etc)
  
		this is requirement for software to operate e.g. in Russia, UK, Germany.
    
		As well it is a limitation for running software in Cloud when Cloud provider does not have datacenters in specified countries
	* since it is SaaS offering we host it on our own and we need to integrate with customer-hosted HR software, JIRA and so on
  
		The way of integration really depends on software. Sometimes we have to query it, sometimes it is better or even only possible option to make software push data to our system

