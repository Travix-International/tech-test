# Assumptions

1 - Used Rest API, GET and POST operations are compatible with the rest guidelines.

2 - Algorithm of generating short hashes for url needs to be considered carefully, there is a risk to create duplicate hashes in case of heavy load if we keep the hash length low.

3 - There is no any session/application/client state for user to see his created urls before.

4 - There is no editing, deleting urls for the user.

5 - We created predefined list of bad/malware sites to prevent create short urls for them.

6 - We have daily/hourly internal scheduled services to keep our database in order.

7 - We keep our entire platform physically (firewalls, load balancers, servers etc.)