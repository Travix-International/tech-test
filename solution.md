## Solution for the Simple Shopping Cart System

This is a component diagram that describes the solution:

![Component Diagram](https://github.com/RubenTejada/tech-test/blob/master/ShoppingCartComponents.png)

**The Presentation layer**

The presentation layer is MVC Web Application with the following funcionality:

The application will provide public pages with the categories, products, informartion about the store  and search results.

> With anonymous users:

   The application will allow the user to navigate the diferent categories and products, and will use temporary users and cookies to persist the products in the shopping cart. 

   When the users creates a profile, or login to the application, the information of the shopping cart will be asociated to the user and save.

> With users with the role of content administrator the application will provide the following administration options:
  
>- Categories: the user can create, edit, and remove  categories. One category can have other sub-Categories creating a hierarchy.
  
>- Products: the user can create new products, manage the quantity of the products, edit the products. search a group of products by content or category and delete a selection of those products
  
>- Taxes: the user can add the diferent taxes, with the description and percentage of each one.
  
>- Discounts: the user can create discount rules, indicating the products and the rule to apply the discount.

In order to allow the separation of this 


**The Businness Logic**

The Business logic is going to provide all the Business rule, and Domain objects of the application. Abstrabction are going to be used in order to design a system with low coupling, allowing making changes to the Data layer, the Search Servicer, and the Payment Services without making any changes to the business logic. 

In order to build a solution easy to test and low coupled, the SOLID principles are going to be used.

**The Data layer**

The data layes is going to be coformed by a SQL Server Database, and Entity framework for the access to the database.

**The Search Service**

In order to improve the response of the search, and to provide help and suggestion to the user during the search proccess, the search is going to be managed separatelly. The search service could be implemente with solutions like Lucene, Microsoft Search Server or an implementation of SQL Full text Search.




  
  
  
















