# Solution.md

Solution selected is to use an abstraction layer (using interfaces) for the product types, then using dependency injection we can access the properties of the different product types when adding items to the shopping bag.
IoC is also used for promotion codes, to allow for different types of promotion codes, eg %off, £off, 2 for the price of 1 etc. Each promotion code may have a very different way of working out the discount value.
The tax calculation is carried out by a service class. The Basket class calls a service locator to access the methods of the tax service.

 

