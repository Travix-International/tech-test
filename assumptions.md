# Assumptions
* User management system is available. 
* To do checkout a user should be authenticated.
* User model allows to keep purchases. Attributes: create_at, CardList. Past purchases cannot be edited.
* There is a taxes service in place dealing with taxes. Product will keep tax_rule code to operate with the service.
* There is a discounts service in place dealing with discounts. Product will keep discount_rule code to operate with the service.
* Due to scalability let's assume all algorithm, code involved have efficient complexity and all the static are cared. We do not delivering almost 0.5-1 MB of CSS per user nor almost a megabyte of JS.