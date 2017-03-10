# Assumptions

##### For the solution:
1.	Flight data (carriers, fares and schedules) are assumed to be accessible by the system.
2.	System (a web service) is already responsible of checking cache.
3.	System (a web service) is already responsible for calculating the routes.
4.	Cache results should be saved and updated with latest results as frequently as possible without burdening or putting an overload to the system.
5.	Global frequency threshold value is set.
6.	The data precision is important but is not the must which means NoSQL document database can be used instead of a relational database.
7.	MongoDB is hosted on a cloud.
8.	MongoDB has several nodes running in different regions.
9.	MongoDB or other NOSQL database is used, with TTL Index event triggering enabled which calls another service to update the cache.

##### For the system:
1.	People are searching for the flights for particular event in a city on particular date. FIFA final in Rio, Brazil on 10.7.2016 several times a day.