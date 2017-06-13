# Solution.md

User experience:

System uses a standard shopping cart journey - user browses through the product listings, which can be filtered by product type or any other taxonomy, then either clicks on a 'add to bag' button underneath the product, or clicks to view product details then 'add to bag', a drop down field for Quantity is available for applicable item types (ie not digital downloads). Basket is then updated. On the 'view basket' screen you can remove items or update quantities, or filter the basket to just show items of a certain type. the checkout page then allows  you to add promotion codes, and shipping address.


Technical software design considerations:

Solution selected is to use an abstraction layer (using interfaces) for the product types, then using dependency injection we can access the properties of the different product types when adding items to the shopping bag.

IoC dependency injection is also used for promotion codes, to allow for different types of codes, eg %off, $off, 2 for the price of 1 etc. Each promotion code may have a very different way of working out the discount value hence the need for abstraction.

The tax calculation is carried out by a service class. The Basket class calls a servicelocator interface to access the methods of the tax service. This makes the solution easier to manage and test.

Items in the shopping basket are stored as an array of structs which contain the product object, and a few other fields like quantity, options, unitprice etc. When the payment is completed, fullfilment uses this table to update inventory, create invoices and generate order sheets which is then passed on to the warehouse for order despatch.
For high scalability system we may need to change the iProduct field to just have the product ID and then include some of the product data in the bagitems struct. This does mean some minor duplication of data and is not strictly DRY, but it does mean that posting the basket data to the server is much faster. 


 

