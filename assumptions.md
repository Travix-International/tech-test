# Assumptions
- We shall have Azure subscription.
- We shall have two table storages. table `Keys` to keep records of Id's and another Table `Urls` to keep records of original and shortened url's and time to live of the record ttl.

Table `Keys`

 field       |  type
------------ | -------------
partitionkey | string
rowkey       | string
Id           | long

Table `Urls`

 field       |  type
------------ | -------------
partitionkey | string
rowkey       | string
shorturl     | string
url          | string
ttl          | datetime

- We assume this web app will have tests and it will be deployed once and no need for continuous integration/deployment due to feature size.
- We assume that app insights and telemetry might be part of the solution to monitor the app activities, exceptions etc...