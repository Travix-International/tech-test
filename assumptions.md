# Assumptions

1. We don't need authentication for each URL called.
2. All browsers can handle the HTTP status 307 for POST and GET.
3. The header will be sent to destination.
4. We will only redirect shortened URLs to their designated destination.
5. There's no RESTful API. Only a service that will handle redirect.