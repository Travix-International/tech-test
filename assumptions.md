# Assumptions

1. We have multiple front-end. (Website, mobile client, etc.)
2. Allow the unregistered consumers to add products to their cart, and assign the cart to them after logging in.
3. Discounts are time limited so we should use a expiration time for discounts
4. We have a product service which is responsible for providing extra fields' name and description function(which is
explained in solution part) of each product. (This can be use for adding a new kind of product without changing the
shopping list structure.)
5. We have these collections: User, Item
5. ItemId is unique in a specific category, so both itemId and itemCategory together are unique for each product.