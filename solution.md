# Solution for Scenario 1 "URL shortener system"
Here is my thought around this challenge.

(A) Url Processing Module:
    
    1. Create ProcessUrl class with
        > GenerateShortUrlAndSave method that accepts a string param (eg: www.example.io/someveryveryvery/longlonglong?param=param2) and an expiry_date.
        > A GetUrl method that accepts string param (eg: f2zJZP).
    
    2. The GenerateShortUrlAndSave method should
        > Generate a unique string key not more than 10 characters long from  the url param.
        > Then persist the url, expiry_date and generated unique key to a datastore (eg: elasticsearch, sqlite, mysql, mssql).
        > Return a concatenated string of the service domain(eg: www.trav.ix) and generated unique (eg: f2zJZP) to the caller (eg: www.trav.ix/f2zJZP or www.trav.ix#f2zJZP).
    
    3. The GetUrl method should
        > Retrieve the url from the first record in the datastore where the unique key field matches   the parameter and not expired.
    4. Expose an Api to compress and get url (for users).

(B) Route Module:

    1. Create an Index action for both Get and Post httpverbs that accept a string param which represents the compressed version original url.
    2. From the index Action, call the GetUrl method in the Url Processing Module or the public api(in case you are using javascript) to get the original url.
    3. If the GetUrl method returned a valid url redirect to that url else render an info page. 

