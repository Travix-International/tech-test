## Solution for the Simple Shopping Cart System

This is a component diagram that describes the solution:

![Component Diagram](https://github.com/RubenTejada/tech-test/blob/master/ShoppingCartComponents.png)

**The Presentation layer**

The presentation layer is MVC Web application

With anonymous users, the application will allow the user to navigate the diferent categories and products, and will use temporary users and cookies to persist the products in the shopping cart. 

When the users creates a profile, or login to the application, the information of the shopping cart will be asociated to the user.

With users with the role of content administrator the application will provide the following administration options:
  
>- Categories: where the user can create, edit, and remove  categories. One category can have other sub-Categories creating a hierarchy.
  
>- Products:Here the user can create new products, manage the quantity of the products, edit the products. search a group of products by content or category and delete a selection of those products
  
>- Taxes, here the user can add the diferent taxes, with the description and percentage of each one.
  
>- Discounts, here the user can create discount rules, indicating the products and the rule to apply the discount.
  
















