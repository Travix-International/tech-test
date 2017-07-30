# Solution.md

Scenario: 2. Simple shopping cart system

The solution architecture was thought to try to keep the things simple and independent. Each part of the solution should be really focus on what it have to do and delegate everything else for other components.

Based on this, the solution is made on three independent services that I called Shopping Cart API, Payment API and Search API as described on the diagram "system-context-diagram.png".

It’s assumed that this are REST APIs and they have the following responsibilities:

- Shopping Cart API: Responsible to create, read, update and delete shopping cart.
- Payment API: Responsible to make the communication between the Shopping Cart API and external payment systems.
- Search API: Responsible for all the search queries available to do on shopping carts.

The diagram "api-class-diagram.png" describes of how would be the APIs structure.

The diagram "database-diagram,png" it’s a minimal representation of what would be the database structure.
