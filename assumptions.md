# Assumptions

1. Race condition attack on one-shot URLs is not performed. (since the resolution service fetches the long url first and invalidates the record after some processing)

2. Form data is to be transparently passed (the service is not suppsed to add its own form data)

3. Custom request headers cannot be preserved by the redirection system at all (this is why I provide the option to use API so that the client will get the full url and add the headers to their query - good point for machine to machine communication)

4. Client browser does support the reponse code 307 (otherwise the service would have to build up a form, fill it with data received and re-submit it to the target URL to pass the provided form data regardless the HTTP verb used)