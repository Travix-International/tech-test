# Scale

How it will scale when the number of users/agents/consumers grows from 100 per day, to a 10000000 per day?

First of all, the server should be robust enough to support that amount of hits, if it's not we should enlarge it.

If needed, host more than one website with load balancing.

If possible, instead of one shot urls maybe set a counter limit to allow several hits to the same url until reached.

Avoid DDoS attacks by enforcing a hard limit in the web server as a security but scaling-needed meassure in my opinion.

Analyze if it is convenient to move from relational to non-relational database.

The way the record is found may be improved; if instead of a TinyUrl UUID key we use the record's ID, that may boost the performance, it should be created an algorihtm of encryption/decryption to transform the id's into unique hash keys and viceversa, that way each record would be accessed by id.