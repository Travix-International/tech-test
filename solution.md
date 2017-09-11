# Solution - **_Simple Shopping cart_**

The system consists in two applications:
1. a backend application that should manage all business logic, from adding item to cart to calculating taxes and discounts.
2. a frontend application.

The system can be used by authencated users and non-authenticated users, aka _Anonymous user_. When the user is anonymous, every data will be stored in LocalStorage, on the user browser. This way the user's cart will be on his browser, even if the he closes and open it again.
When the user is authenticated, every data will be stored on the server allowing the user to see his shopping cart from anywhere.

The backend application should be a _RESTful_ API, this way the application can grow decoupled from the frontend application.

The frontend application should be a _Single Page Application_, this way the user interaction should be seamlessly.

## Backend
- Calculate the total amount
> The system should apply the tax for every item of its type. When the final price for each item has been calculated, the discount should be applied to the total amount.

- Adding item to cart
> Every time that a item is added to the cart, the system should verify if the cart already has that item and then add it. If the item is already in the cart, then its quantity is increased.

- Removing item to cart
> Every time that a item is removed from the cart, the system should verify if the cart still have any other of the same type. If so, then its quantity is decreased.

- Removing group
> Gets all items in the specified group and remove from the cart

- Save the cart
> The cart can only be saved for authenticated users.

## Frontend
- Shopping cart
> When the user requests the cart detail page, every items in the cart should be listed and grouped by the its type.
> At the bottom of the page, should be presented the final price including all taxes and discounts, and the purchase button.
> Should allow the user to query for an specific item by its contents or by its types.

- Payment result
> When the result is __*OK*__ the cart should be read only, so the user can't edit, but still can see its contents;
> Otherwise, the cart should be editable.
