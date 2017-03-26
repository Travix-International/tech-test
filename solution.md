# Solution.md

### Technology Stack: ReactJs, NodeJS, MongoDB

The whole Shopping cart experience would be in a stepper feature, in order for the user to see which steps he/she is in or how many steps he/she needs to complete and will be a single page application.

#### Items:  
will have description, tags and type to help the users query items effectively.

#### Cart: 
Adding an item to the cart will automatically create a cart under the user’s id  in the database, so the user can access the cart across multiple visits and across platforms from the user’s dashboard and with relevant information such as:
* cart id
* user id
* item id
* date it was created
* cart status - maybe useful in the future for cart expiry

#### Cart: 
UI design will be grouped by type to give the users more freedom on removing items.
* Remove by type
* Remove by item
* Remove all

#### Checkout 
application will automatically calculate total discount, tax and bill as a summary of the order.

#### Payment Service
If failed, need to prompt users on the error and redirect the user to the checkout page in order for the user to resolve the issue if the problem is coming form the user’s end and inform the user using some notification or alert if the problem is coming from the application’s end. 

#### Invoice
* Invoice will then be shown to the users and will also be sent to the user’s email.
* Option to redirect to items and order status.

#### Order Status
will show users order status
