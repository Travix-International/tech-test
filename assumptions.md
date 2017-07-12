# Assumptions

The main assumption of my solution is that all items are as generic as they
could be, storing any information that is common to **ALL** e-commerce items
together and storing everything that could be particular to any item to metadata
information.

It's also assumed that this will be a client-server architecture. The problem statement
is unclear in this regard so a popular, battle tested architecture is assumed.

Type by my understanding is rent, sale, service, etc. Item
tags are too generic (and mutable) to be included as type information and therefore
not a reliable source of information (an owner could change all tags of one item
but is unlikely to change its type, usually this means deletion or updating with
the same type).

Transportation cost are also not assumed to be included as what is considered *TAX*.
This should be handled separately and they are more related to the cart than to
the item itself.

User information is assumed to be stored separately, there should be an implicit
authentication system that recognizes the user as it logs in and redirects it back
to the cart triggering the syncing process right after the successful authentication.
