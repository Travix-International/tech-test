## Solution for the Simple Shopping Cart System

This is a component diagram that describes the solution:

![Component Diagram](https://github.com/RubenTejada/tech-test/blob/master/ShoppingCartComponents.png)


## The Presentation layer

The presentation layer is an MVC Web Application with an HTML5 Responsive design and the user experience is going to be enriched with Jquery and AJAX.

## The Businness Logic

The Business Logic is going to be several .Net Libaries to provide all the Business rules, Domain objects and interfaces of the application. 

Abstrabction are going to be used in order to design a system with low coupling, allowing making changes to the Data layer, the Search Servicer, and the Payment Services without making any changes to the business logic. In order to improve the test and manintenance  of the application, SOLID principles are going to be used.

## The Data layer

The data layes is going to be conformed by a SQL Server Database, using Entity framework for the access to the database.

## The Search Service

In order to improve the response of the search, and to provide help and suggestion to the user during the search proccess, the search is going to be managed separatelly. The search service could be implemente with solutions like Lucene, Microsoft Search Server or an implementation of SQL Full text Search.


## Aplication Behavior by Role:

**Anonymous users:**:
>The application will allow the user to navigate the diferent categories and products, and will use temporary users and cookies to persist the products in the shopping cart. 

**Authenticated users**:
>The authenticated user will have the options to see tha cart's items in any authenticated machine, and complete an order.

**Content administrator**

The content administratos will see aditional options to administrate the content and configuration of the store:

> Categories: the user can create, edit, and remove  categories. One category can have other sub-Categories creating a hierarchy.
  
> Products: the user can create, edit and remove products, manage the quantity of the products, search a group of products by content or category and delete a selection of those products
  
> Taxes: the user can add the diferent taxes, with the description and percentage of each one.
  
> Discounts: the user can create discount rules, indicating the products and the rule to apply the discount.

  
  
  
















