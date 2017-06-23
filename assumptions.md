# Assumptions

- The minimum expire for even Today flight is more than 5 minutes 

- Each flight has different update rate , Flight which going to happen today maybe has more changes in fare compare to flight is going to fly after 2 weeks , based on this Number of updates become low and restricted in certain areas flights.

- When User Hit Cache Node only 1 out of 100 found expire result.

- Instead of Pull our Approach is Pushed based, On Repetitive search we will not hit Origin until result expire 

- Origin wait for updated data from Master, until there is no update whatever he has treat as latest.

- Data is distributed and only Master contain full data rest, Origin and Cache nodes only contain data which requested frequently otherwise they will purge the cache.

- There is no client side cache for Search result, client need to hit Cache server for each search

