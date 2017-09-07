# Assumptions

1. Handle a Post means forward the request to a target URL and the target system must return a URL to which the client application will browse. A kind of *callback URL*. (I was confused about this POST requirement. It sounds a little bit weird for me because the most of shortener systems are based on redirects. So I have tried to combine this two aspects).

2. Another way of deal with this Post requirement without require the *callback URL*, would be the Trav.ix forward the request, catch the response, copy the body and return it on behalf the target system. But, doing this, the Trav.ix would be a kind of API Gateway (much more complex than a shortener system).

3. The shortener does not need to know details about URL fragments or query string parameters because is responsibility of target system handle them.