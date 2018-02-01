# Assumptions
- In this case I just considered to design web API without any web UI
- In this phase, I decided not to consider authentications 
- There can be more than one request to shorten a long URL in different times. Because of saving time, I decided to allow duplication based on long URL in storage instead of searching in DB.
- Analytics for short links is not considered.
- It's not possible for user to choose dynamic part of a short URL 
- Links after expiration will be removed from DB. In this case there should be a service or job to do the task in every specific time periods for instance once a day.
- Only 0-9, a-z, A-Z characters can be used in shorten URL due to better readability and writability(in case someone has to type the link in)To handle number of short URLs which system can produce, we use 7-length string for hash-key(auto-generated part of short link) with 62 possible choices for each slot in hash-key (0-9,a-z,A-Z = 62). With doing some calculation we can see there are 6 trillion possibilities for hash-key which means that there is more than 160 million possibilities per day for 100 years.
- There will be authomatic tests,CI,CD,... but won't be discussed here.
