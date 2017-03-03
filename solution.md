# Solution.md
The solution is based on a M.E.A.N. Fullstack app that will rely on Cluster for scaling and Redis for caching

I've thought to make a nodejs app using express and mongodb to act as a backend and an AngularJs app to act as a front-end. The two apps will interact via APIs.
Due to the needs of scalability and speed. I've decided to add Redis as a caching system for mongodb and Cluster to be able, in case of need, to scale nodejs on multiple CPUs.

The "tables" in mongo will be

ITEMS (Items available in the catalog)

TYPES (Item typology available)

USERS (User list)

TAXES (Percentage of discount, typology of items which is applicable, isActive)

ORDERS (Contains all orders done, cancelled, or not yet completed)

ORDERLINES (list of tuples item/orderID/quantity)

Due to the fact that mongo is a scheme-less db we will be able to store items all together specifying some common attributes (Price, discount and itemType) while, on the other hands we will be able to store some “variables” fields if needed for specific typology of items.

The API exposed from the backend are (words with a colon before are considered variables):

/api/addItemToCart/

/api/removeItemToCart/:itemId

/api/removeItemType/:type

/api/saveCart/

/api/getCart/:userId

/api/getOlderOrders/

/api/processPayment/:oderId

/api/addItemToCart/ will call an internal routine which will take care to get the right tax for the given item.
