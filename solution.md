# Solution.md
The main question in that test is a place, where the basket should be saved. The first option is to save item ids on frontend (in cookies or something like that). So, the customer enters the site and all totals and discounts are calulated once more. The second option is to save basket data in the database, so that it could be loaded, when the user enters.
The second option seems to be more flexible and scalable, that's why I preffer it. 

All basket user actions like items quering should be done on frontend, but of course it depends on the stack of technologies used.



Workflow: 
First, on item page the customer chooses the quantity of items, he wants to buy, and clicks the 'Add to basket' button. After that, the site generates an API create request for the basket. After any changes (for example, the customer changes the quantity on the basket page or adds new item) the site sends an API update request. 

If the customer leaves the site before completing a purchase and returns some time later, the site sends API request to get basket. There will be a server side checking, if the basket for user is still active by comparing an expiration date with current time. If the basket is active and not-expired, the server side returns basket information to the site. If time has expired, then the site returns null, and the customer sees the empty basket. He may add a new item and a new basket will be created. 
After the purchase has been completed the system sends request to the payment system. If the response is OK, the basket status will be changed to Completed and an order will be created. If the response is not Success, then the basket will stay active.
To improve response time, it would be nice to use cache. 

The basket table contains Created Date, Expired Date, UserId and Status (for example: created, expired, payment faulted, completed and etc), and data with items, quantity, total amount and discount/taxes, this data may be saved in separated fields or in one field as json, xml or any other formats. The first way is better to use if you need to get any statistic reports or make filtering or if an amount has to be recalculated very often (for example, in case of a discount by date or something like this), the second way is better for data, that has no need in recalculating, and it works faster, because the site only gets saved data and doesn't make any calculations.

