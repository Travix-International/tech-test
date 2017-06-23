# Solution.md

Solution
--------
I come up with idea where we may have multiple layers of infrastructure, which divide load and mainly user hit static cache node which is more easy to main and scale.

**Cache Node / Static Node**
That completely dumb server / servers which just serve pre-generated JSON files which has Expire headers set by Origin, something like ngnix / varnish very fast static file server 

**How Its work:**

If we go through all the combinations, they maybe hundreds of thousand but the basic query or in my scenario file name probably like this ams-jfk-230617.json , 

1. From our website user create search query and based on his query we create multiple file request to Cache node like this ams-jfk-230617.json , jfk-ams-300617.json

2. Cache Server Check if name format is right and file with this name exists, its return that json to website otherwise if file didn’t exist or exists but with expire header Cache Node hit Origin server for latest file

**Origin Server** 
This machine need to be Near to Cache Node or good idea is within same Datacenter, this machine is some kind of distributed Database (couchdb, mangodb etc..).

**How Its work:**

**Generate Result**

When cache node request for result this machine check DB to generate result and return JSON where expire time is time of Fare with least expire time, means 30 result return where one Fare expire time is just 5 minutes returned file expire Time will be 5 minutes.

**Subscribe for Push Update**

There is scenario when cache node hit for result but Origin don’t have that result probably some kind of query which is not popular on That Location / Region

Origin server Request subscription on Master Origin with That query with some expire time for subscription. 

**Master Origin** 

This is one machine Globally or maybe one per region based on load we are facing , This is actual brain behind search result , 

**How Its work:**

This machine getting real time updates of Fares (IATA, Airline or any other source) and on each update, check relevant subscriber and push changes, Each subscriber has expire time and after expire he need to subscribe again for getting push notification. 
