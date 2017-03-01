# Solution.md
For the solution of this challenge, we will be creating a system based on Microservices. This will provide us with a highly horizontal scalable system, loose coupling, high velocity of development, and a good separation of concerns.
For the tech stack used, we will be using: .NET Framework with the WebAPI technology, either MongoBD or Cassandra for database persistency and horizontal scaling, and Redis as a NoSQL caching solution since we want to protect our databases services.

The main cart microservices created for the solution will be:
- addItemsToCart
	- receive an array of items to be added to a session user cart id.
	- items may be added independent of its type
	- will request the persistency in both dbstore and caching store

- removeItemsFromCart
	- receive an array of items to be removed from a session user cart id.
	- will remove the items from both dbstore and caching store
	- given the input array, may remove one or more items

- listItemsFromCart
	- lists all contents and details of a given session user cart
	- we first check the cache services for information, if there aren't any, we check the database services

- getTotals
	- get the totals and discounts applied to a given session user cart id.
	- should calculate the discounts based on categories of items

- makePayment
	- make a payment for a given session user cart and returns a result status code.
	- its just a boundary microservice which will delegate to the real payment service
	- will handle payment status and return the status code accordingly