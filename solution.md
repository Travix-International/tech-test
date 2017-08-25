# Solution.md

#Scenario 2 - Shopping Cart

- Calculations are not permitted on the frontEnd. Prices, taxes and discounts will be calculate involking rest services;
- Every action associated with the cart will be responsability of the frontEnd (add, remove, persist the cart on localStorage or sessionStorage);
- Validations on the Shopping Cart that envolves presentation will be doing by the frontEnd;
- Validations about combination of associated products on the shopping cart will be doing by a micro service;
- The persistence of shopping cart between multiples user interactions will be treat by LocalStorage;
- Every product type like "Air" can have your model and your product particularity validations;
- Validations that are used for every product type will be on a global scope on the shoppping´s Cart;
- Every action on the shopping cart needs to have an automated test associated;
- Every service invoke needs an autenthication token to call it´s service;

For this scenario, we assume the the complete solution to mantain a complete shopping cart is the usability of LocalStorage. Using this resourse, we can guarantee that some features will be hold when then user close and open the browser. Addictionaly, we can guarantee the adcition, deletion and data information for each item added on the shopping cart. Some micro-services will be invoke to calculate discounts and taxes.

Another solution, is just hold a hash on the local storage, and when the user closes and open the browser, then a service will be invoked passing this hash like a input param, and retrieing every cart associated with th hash. The backend can calculate the newest price, discounts and taxes based on this hash, and responses with the all shopping cart associated to the user, incluiding the availability of the products that was previously added to the cart. So, this information can be saved on localStorage and it can be confirmed on backend serice at the checkout´s page until booking the shopping cart.

## 3. Hours tracking system

- Create a backend connection to the JIRA API the retrieves the associated information to the user;
- Create a backend connection to the HR Payroll System, associating the user data and retrieving the using infromation;
- Create a backend connection to the Google SSO to validate the connected User on the required systems;
- Create micro-services that retrieve and save the associate information that will be need on every screen;
- Every micro service that deliver information will be implement a cache strategy, considering multiples access for the service;

## 4. Simple micro-blog platform

- Use OAUTH 2 to allow multiple login on the app;
- Create a micro service for post a message, images, links and another kinfd of message that the system allow;
- Create a micro service on the backend the responses with the track messages posted by an user and generate a timeline to view by the user´s association track by date/time descending;
- Create a parameter table that contains the types of message that are allowed by user, size of images, type of images, and type of media the will be saved on a database;

## 5. Fare Cache

For this scenario, we can use the various searched destinations made by the user, to feed the "static cache", creating a large database cache that contains a hash that can be update when another user makes the same search. 
This database can save the fares associated to the hash, without any maintance by a department, because we can use the visits to increase and update the cache solution. So, when a user request the best price for one destination
that database will provide the best price, without request to the company a new price. The cache can be update with the newest price just when the user really wants to buy the flight ticket ("buy´s intention") on the checkout´s page. At this page, we will
need to confirm the availability of this flightgroup and we can use it to update the cache with the newest price.  So the requirements for this solutions are:

- Cache In Memory data Structure (Redis, Currerence, CouchDB or other solution);
- Every search needs to check if there is information with the passed haskKey on cache before search on Air API;
- If there is no cache associated, the middleware will be responsible so invoke the Air API and update the Cache data Structure;
- When a customer buy a ticket, the cache needs to be update with the fare used for booking. With it, we can guarantee the price structure for search and booking actions;
- With this solution, our homepage can have a showcase with update price, based on best fares founded for any destination searched;

