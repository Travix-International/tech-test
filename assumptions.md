# Assumptions

- There are other (micro)services in charge of handling users, inventory, payments, etc. which are incredible fast and reliable, and have fantastic API documentation. We'll particurlarly rely in the one managing products and inventory, so we don't have to store much data about that.

- Taxes and discounts are handled by the Products service.

- Queries for products in the cart are quite basic and general for the common characteristics of every product.
