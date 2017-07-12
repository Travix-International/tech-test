# Scale
### When the number of users/agents/consumers grows from 100 per day to a 10000000 per day we will provide several changes:

* Creating cluster system for DATA and API modules
* Increasing Database storage
* Detection of "bottle neck places" to find the slowest parts os application (e.g. loops with another inner loops)
* Optimization of Database queries
* Creating and optimazing Database indexes
* Replacing big calculations to external services (e.g. Web workers or written on other languages such as C++)