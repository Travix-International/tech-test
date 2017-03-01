# Questions

1. What are the principle parameters which form a unique fare (set of fares), like destination from/to, dates, ticket class, number of travelers, etc.?
2. It was mentioned "48 hours" and "5 minutes" of a data TTL in deferent places of description. What is a general reasonable/desired threshold of data expiration, after which a new call to external/internal service(s) must be triggered in order to obtain new data?
3. What other conditions (changes) besides the expiration time will invalidate the cache (a ticket is reserved/bought from a user, any signal (if there is such) form other internal/external systems, like new discount available, price changed, airline strikes, etc.)?
4. Will a user geo information (IP location) or any other information obtained legally about a user be a fare price/availability modifier?
5. Will the application serve the same information when queried from different endpoints/sites (e.g. CheapTickets.nl and budgetair.be)?
6. Based on current statistics available, in average, how many users search the same set of fares within 5, 10, 30 minutes or an hour (exact period needs to be clarified)?
7. Do you have any other concerns besides already mentioned in the scenario description?
