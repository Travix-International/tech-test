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
you can not add a blue one (because of the complex nature of items color should be
included as metadata **unless you are absolutely sure** that you will only sell or rent
shirts and not any other item type, making your item description more specific).

Each item must include type<sup>1</sup>, tax information, discount and finally metadata to be used as
constraints. Adding type information to the cart might seen like an attractive idea but
in real life items have their types well defined and this information is
usually necessary to determine item availability (which, by the way, is impossible
without an inventory system in place).


<sup>1</sup> Type by my understanding is rent, sale, service, etc. Item
tags are too generic (and mutable) to be included as type information
