# Scale
* Scenario when the data is pushed to our system (from JIRA, HR) and stored
    We provide more or less simple RestAPI which is well horizontally scalable, especially if we provide some batching APIs
    
    We store data dcoument-oriented DB (Couchbase, DocumentDB or even MongoDB) since we don't have really relational requirements and we don't have very well structured data because we integrate external systems of different kind
    
    It depends on client pool how then to shard and cluster or infrastructure. With DocumentDB we can even provide exclusive nodes of     storage and processing units.
    
    Major change that is required to provide scalability is request routing system to appropriate shards
    
    This systems are well scalable as well and provide easy CRUD operations.
    
    Reporting is well scalable if we can offload data population to periodic job which builds OLAP cubes or uses built-in multidimnsional       search of DB engine

* Scenario when we query the data in external systems based on user or manager's input.
  Scenario when we query the data based on manager's input.
	
  We can consider case when we don't store almost any data. we just cache it.
	
  In this case our application acts more or less as proxy between frontend and Jira/HR. 
	
  We can ever consider SPA as frontend which communicates direclt but this is bad option if we go to SaaS but can be good option to start

	Reporting scalability in this case can be a problem but we probably can use just well-preconfigured work-tracking system reports (Jira or other one) including possibility to combine the data between reports
	
  We can approach it just merging data on the fly or writing translator from our UI to some JQL query in case of Jira
	
  This approach is quite simple and when the project matures can be more or less easily transfreed to first one
