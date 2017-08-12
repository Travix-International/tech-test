# Solution.md
The solution should enable users to shorten long urls of any schema for both GET & POST endpoints. each user will have a profile that contains his urls so that we may give him some powerful analytics by adding click counter module.

Any registered user can share his shortened url with the public, the shortened url will hit a rest endpoint in the system that translate it to the long original url - if exists - and redirect the user to the original url keeping the http headers, verb and query string untouched.
