# Solution.md
1. Application service layer( redirecting ,shortening ,serves the request)
2. Shortening Service
	* Rest Api written in .net core(1.15m rps)
3. Redirecting Service
	* Rest Api written in .net core
4. Data storage layer(keeps the data)
	* We need a key value store, row cache and scaleble db
	* I prefer to use Cassandra
5. Each url has has to mapped to unique alias.
	* We can hash our url with (md5,sha-1 etc) and convert to base62 and take first 7 char
6. For expiration we can use TTL features of Cassandra.
7. For read  performanced  we need to use "Key Cache" (cache our hash ) in Cassandra
8. For monitoring whole system I prefer to use cloudwatch ,nagios or datadog.