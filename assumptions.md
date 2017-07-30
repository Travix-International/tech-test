# Assumptions

- users can create shopping carts with or without login
- to allow users to create carts without login, it's assumed that there is a cookie for session identification
- each item is defined by a code/reference
- each item has is own type associated, so by item code it's possible to know what is the item's type 
- payments responses are translated to shopping cart status
- since it's expected that the taxes are applied automatically, both have start and end dates to be automatically setted on the shopping cart
