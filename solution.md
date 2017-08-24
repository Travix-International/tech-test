# Solution.md

- Cart will be stored in database, for future purchases.
- Session Id in cart will be used for non login users, after member logins session id will be changed with member id.
- Each member can only have one cart(unless payment state is OK), with this member can purchase the item later.
- We could log payment system responses and store the last state id in cart. After a carts payment state is OK we could create another cart for member.
- Each product price, tax or discount could change in time, that is why I prefer to store them in cart detail.
- To handle sums/calculations automatically we can use Facade patern.
- Generic repository pattern could use for CRUD operations and we can design queries with linq expressions. This will handle the different type of removing operations
- AddToCart method handles adding same kind of items without repeat. Checks with id, add if no product, raise the quantity otherwise.
- Filter expression in cart could filter the card details by member, product etc.
