# Scale
We will divide url generation , http client workloads different services. To speed up read request, view of stored data will be in memory (in non-sql database like mongo). Also an ageing process will run on the data. With an algorithm like used in operating systems, we will remove not used  recently urls from our in-memory view to decrease memory usage. 
