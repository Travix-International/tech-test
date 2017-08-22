# Solution.md
# Simple Shopping Cart System

In DOM add eventListener to “Add to cart” buttons for sending AJAX requests with unique Item IDs to server. After clicking an “Add to cart” button we store special cart Object to:
1.	User Carts DB if user is Authorized
2.	User Carts Cache DB and key to cache in COOKIE . We also can add TTL and setup DB limits. If we exceed records limit, we just can delete oldest used cache
3.	COOKIE with necessary expire time
Server will automatically add necessary fields to this Object (like type, features, taxes due to type, weight…). We can also add items to some DB for some Recommendations system and ML system to increase sales.
We can work with this Object in CartPage. While loading Script (like React or Angular) render our cart due to our UI. We also need to add buttons for increase/decrease/delete item in cart via AJAX (then server update Cart Object and rewrite to DB or COOKIE). We also need to add checkboxes foe selecting items and then delete selected items.
Before rendering we need to add some service to automatically calculating discounts and taxes. Our carts will stored in COOKIES or DB. We can also save cart (then add cart Object to special DB represented by some code, sent to e-mail or phone, or to User Accounts DB for authorized users).
Before checkout we need to wait a response from Payment system. After ‘OK’ we:
1.	Make notifications
2.	Send AJAX request to server for recording Order to base, clearing COOKIES or DB from cart Object, sending e-mail notifications…
