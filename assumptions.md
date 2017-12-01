# Assumptions
1. When user change a currency / country we will need to reload list of product to get a proper currency and price / taxes.
2. Product store is a single point of truth for prices. Basket is storing only references and quantity.
3. There will be two types of promotions. % of base price and amount we should subtract from base price.
4. Products will have unique ID
5. User can have only 1 basket active at the time.
6. Discounts are associated to a product and are affecting only this product price
7. Application will be based on "single page applications framework" but still we wull be using server side rendering for SEO
