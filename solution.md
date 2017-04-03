# Solution.md

In order to implement a solution for this problem, I would use Redis to store in cache the fare prices of the latest searchs made by the users. I can use an identifier for the route (i.e. AMSJFK), and save all the important data of this flight, just in case this is the cheapest one in the result set.
I will set this value in Redis using the optional parameter EX to add the 48hs expiration time. When a new result set is returned for the same route I would check the flight fare stored in chache is already present and keeps being the cheapest one, otherwise I remove this entry and replaced be the new cheapest one.
To have an idea of the most popular routes on every country I can implement some sort of counter and increment the value every time a new search is being made for the same route. 
