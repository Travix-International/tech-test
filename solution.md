# Solution.md

The solution is a simple shopping cart cloud system. 

## Cart and Orders

The model was designed to keep track of customer's current order in any device. I thought it would be simpler if the order had an enumerable with its status and one of them is the "Cart" status. The customer have a list of orders, but there will be only one with a "Cart" status, this enum indicates the current order. The order itself has a List of OrderItem, each one of them containing the Item and its quantity.

## Items

I understand that many different types could be added to the cart, so I made a BaseItem that would be SuperClass for any other type of item that could be added. This way I guarantee that each type of item can have its owns properties.

## Discounts

I made a model that could work with two kinds of discount. The first one is using codes (like discount cupoms or vouchers) that would be generated automatically in special ocasions and sent through e-mail or other ways to the customer, so he can use one time in any order he wants. This discount must contain its value that will be removed from the total purchase. The second one is by rules that would be written by the administrator, interpreted by the system and applied by the end of the purchase. It has two strings, one with the rule that says the condition and the products affected and the other one with how to apply the discount. For example: RuleExpression = "ForEach 2 ItemTypeExample1" and DiscountExpression = "Next 2 ItemTypeExample1 100%" would apply a 100% discount on the next two ItemTypeExample1 on the list for each two ItemTypeExample1 bought. So, if I buy 8 ItemTypeExample1, 4 of them would have 100% discount.