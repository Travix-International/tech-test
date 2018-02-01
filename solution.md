# Solution.md
- My design includes these components : core service which is REST Api, Load balancer, Range keeper, Cache, Queuing system and Database.
- core services include 2 APIs:
url shortener service : it gets actual URL and expirationTime(optional) and returns Short URL.
For generating hash-keys, we fetch "counter" and convert a unique number represented by counter value to its expression in base64. and then we add 1 to counter for next hash-key. By this method we solve the collision problem. 
If we store "counter" in one server then "counter host" will be both "single point of failure" and "single point of bottleneck". because of that we divide whole numbers between 0 to 6 trillion into ranges(e.g.: 0 to 1,000,000 and 1,000,001 to 2,000,000 and so on) and put the ranges in some High availability and distributed service like ZooKeeper. so the workers just go to zookeeper and get a range that is not flagged as "used" and do generating their hash-keys.

URL resolver service: it gets short URL and return a related response or redirect to target url.
gets the hash-key(short URL) and fetch the actual URL. then 
    1- if the link does not exists or is invalid(expired) return the proper response code witjout redirecting
    2- if link exists and is valid and also is a "get" then redirect to that(if is on-shot then set "expiratinDateTime") 
    3- if link exists and is valid and is a "post" then it can forward the request to target page and get the response and then return it to client.
- because there is no relation in model, it is better to choose No-SQL database for this situation(faster fetching). and the model could be like this:
{
    Hashkey, --for saving some storage we save just hash-key and drop "trav.ix/"
    ActualUrl,
    IsOneShot,
    ExpirationDateTime,
    WebVerb, -- get or post
}
- "need to be quickly accessible across the world" for this matter we use some geographical distribution like CDN(content delivery network) 