# Solution.md
For implementing a simple shopping cart system, we can design a system which stores shopping carts in the database.
By storing data in the server side we allow users to have their cart in different front-end clients. We can use local
storage of the browser for allowing unregistered costumers to save items before logging in.
We can use both SQL and NoSQL databases, but because of the type-specific data handling requirement, I prefer NoSQL
database. It could give us flexibility to store different data types for each kind of products.

# Database Design
The database design for this solution could be:

** ShoppingList collection: **

    1. UserId //Foreign key of User collection
    2. ItemCategory
    3. ItemId //Foreign key of Item collection
    4. Count
    5. Tax
    6. Discount
    7. ExpirationTimeOfDiscount //After this time the discount can not be applied
    8. Price
    9. generateDescriptionFunction
    10. typeSpecificData

generateDescriptionFunction, typeSpecificData:
These two items are provided by product service. generateDescriptionFunction is a string function which accepts
an object and returns a string. The input object can be typeSpecificData. By using such design for adding a new product
we don't need to change shopping cart module for adding a new kind of product, we can just add a new category to our
product service and this can satisfied the loosely coupled system specification.

When user add an item to the shopping cart, we should send both itemId and categoryId to the server. For optimization,
we can use this strategy in adding an item to shopping cart:
1. If the item is new in this cart, server will return the whole object of this item in the shopping cart.
2. If this item is already in the shopping cart, server just acknowledge receiving data.
In both cases, we should not send the whole shopping cart, because it consume excessive bandwidth and slow down the
process.


