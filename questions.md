# Questions

- What are the expected "queries by content"? It's related to properties inherent to the product? This can be abstracted somehow? I'd rather keep the products data as minimal as possible in the cart app, querying the Products API when necessary. But for the sake of performance in queries we should include the more important data. And if everything should be queryable, probably change the approach.

- Not sure about the Taxes policies, so assumed it's handled per products in the Products app.

- How are the discounts applied? Per particular product, by buying several items, for items with similar characteristics, combos, coupons, etc?

- Users are expected to have accounts and be logged? 
