# Solution.md

*Solution for scenario 2, design a cart system.*

For the solution the initial step is to design the available items as a
separate entity. The problem statement says that this system should
not include inventory but because of the nature of any cart system is **NOT
RECOMENDED** to merge items information with the cart (otherwise the cart
will be anything but simple). The reason for this is easy to understand,
people could purchase items of the same type but with different
metadata (eg. blue shirt, red shirt, being shirt a single reference) also
you will eventually have to list items in an UI to be added to the cart making
a separate entity design an obvious solution and finally independent item
specification serves as a blueprint for what you can add to the cart, this means
that if the items specification says that you can only have black and white shirts
you can not add a blue one (because of the complex nature of items, color should be
included as metadata **unless you are absolutely sure** that you will only sell or rent
shirts or similar and not any other item type, making your item description more specific).

Each item must include type<sup>1</sup>, tax information, discount and finally metadata
to be used as constraints. Adding type information to the cart might seen like an attractive
idea but in real life items have their types well defined and this information is
usually necessary to determine item availability (which, by the way, is impossible
without an inventory system in place).

The second and final step is to draft the cart as the other main entity which
should only include **ONE** unique constraint for identification purpose but
independent of the item definition (due to the problems stated above) which should
include quantity, references to items, metadata information (user selected),
user information and a special field to specify if is the active cart (so you can
save your cart or dispose it for efficiency).

The cart should be persisted in both the client and the server; this allows to
make purchases without being logged in, but allows to have a single cart in case
the user visits the site multiple times and uses different browsers or devices. There
will be a moment where syncing the data is necessary but as a rule of thumb the information
on the server takes precedence; this is because is impossible
to determine that the user is using a public computer and someone else added a cart
with some items that aren't you users choice.

To implement this solution you should have an api that deal with

* read request merging both item and cart information to produce efficient queries
* create and update request paying attention to similarities in both item refs and metadata
* delete request with references to one or multiple cart items(also dealing with local
references in case the user is not logged in)
* syncing capabilities to determine which information is more relevant and according
to the user's choice.

<sup>1</sup> Type by my understanding is rent, sale, service, etc. Item
tags are too generic (and mutable) to be included as type information and therefore
not a reliable source of information.
