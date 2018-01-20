# Design

### Conversion logic
- We have to create a function that generates short url out of a consant string provided, based on Id of the record from `Keys` table.
- If the Id is 0 we return first char of the base string
- Conversion algorithm works by converting this Id to its equivalent from the constant base string according to the following pseudo-code
``` c 
string output

while id > 0
   remainder eq modulo(id,base.length)
   output eq plus(output,base[remainder])
   id eq divide(id,base.length)

return reverse(output)
```
This will insure to get ashortened hash generated from our base string out of the record Id
### Short url service
- First request done checks the `keys` table if null and seeds the table with it initial Id.
- Based on this record we use our conversion function to transform the Id from `Keys` table to generate a short url hash and store the record in the `Urls` table along with originalUrl and ttl send through the request content when posted.
- We then return the short url to the user along with the original url 
- The record is stored and can be retrieved later on according to ttl variable at which it shouldn't be available in the storage when this value is expired.
### url redirection
- We have to make sure also to put a url redirection 
functionality in place.
- When user uses this short url we simply redirect this request into the original url by issuing `302 redirect` status back to the browser
- If the url requested is not found, outdated or deleted from our records we use a fall back url to route into.

