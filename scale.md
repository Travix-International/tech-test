# Scale

To scale our fare cache service, one solution would be partitioning our Redis instances using "range partitioning", having this, we are not limited by the amount of memory of a single computer and we can split our data in different machines. I would create different range instances by geographical region of the departure of the flights, and this regions would be bigger or smaller depending the amount data that is stored for each region in order to get a good balance of range partition size's.
I will use Redis Cluster that implements an hybrid form of query routing that redirects the user to the right node instead of being redirected from on instance to another.
