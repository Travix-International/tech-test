# Solution.md
URL shortener system is selected.

We need to store not just url but http headers and http method as well. So they will be stored as different property/field. We can think the interface like Postman's interface with simplifications. 

We will need to post request that provided to us , so a http client service will be needed as well. So we can separate 3 needs , 1. Generate short url , 2. Use short url, 3.http client service redirect request or post the request. 

 We will store a sequence number. And each time our generation service is used , we will use this sequence number to generate url not any part of the data.

When our service used we will decide if this url need to be POST or just GET , so in GET request we will return redirection response.  

To reduce 404 we can take bounce url as well from user for request that our http client will process. It will be better make user decide other than we decide. Also we will redirect our date-outdated page for 404 errors.