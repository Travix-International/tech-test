# Solution.md
1. Shortening Service
	* Rest Api written in .net core(1.15m rps)
2. Redirecting Service
	* Rest Api written in .net core
3. Data storage layer(keeps the data)
	* We need a key value store, row cache and scaleble db
	* I prefer to use Cassandra
4. Each url has has to mapped to unique alias.
	* We can hash our url with (md5,sha-1 etc) and convert to base62 and take first 7 char
5. For expiration we can use TTL features of Cassandra.
6. For read  performanced  we need to use "Key Cache" (cache our hash ) in Cassandra
7. For monitoring whole system I prefer to use cloudwatch ,nagios or datadog.