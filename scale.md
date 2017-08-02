# Scale

A possible architecture could be a Serverless architecture for the UrlGeneration function (Faas) - as it doesnt need to handle any state, which is mantained by a possibly distibuted, highly available key value pair storage.
Get And Posts should be handled by two separate serverless functions as illustrated by the pictures.
With serverless the amount of resources used for the functions to be active should be proportional to the number and frequency of requests, thus optimizing the overall energy/cost of the system (depending on cloud intrastructure).
