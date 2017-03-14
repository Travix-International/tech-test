# Solution.md

This solution aims to solve the problem number 5, (Fare Cache).
The route database model should have a field with the cheapest flight. Every route's fare update should trigger the calculation of the cheapest flight of the related route in order to update it in the database without future processing cost, when a user performs a query-search the calculation it should be already done.