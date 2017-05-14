# Solution.md
The shopping cart is an eCommerce module developed to provide potential online shoppers with a user-friendly environment that guarantees they’ll make a purchase once they visit the site. The process that converts a potential shopper into an actual purchase is based on a set of tools that I have to provide with an easy way to find information and products, and user friendly shopping cart tools, which lead the potential shopper to the information and items they are looking for in the simplest way possible. 

When a shopper selects an item, they can add it to the cart through clicking on it, or by dragging it directly into the cart, which can be displayed in a mini-cart mode, or as a full page. 

As more items are added to the shopping cart, the system automatically calculates the total cost in an updated manner, including any applicable taxes and shipping fees.

Upon check-out, the shopper simply clicks on the Checkout button, which will bring them to the order-processing page. Prior to finalizing the purchase, the shopping cart will receive event data from another module, indicating the status of payment (successful or failed). Based on the result of this event, the shopping cart will take an action, which can be defined as per the client’s or solution’s needs (deleting items, clearing the cache, triggering other events, etc.)
