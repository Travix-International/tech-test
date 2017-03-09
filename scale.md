# Scale

1. AWS will help to scaling using Auto scalling group

2. Redirection also can be done in CloudFront / WAF instead of server (This method need POC)

  - in this method, Backend system will call CloudFront Api to update the redirection 

  - however there's some cons with this method :

    1. CloudFront needed sometimes to propagate configuration across all nodes, so while waiting for the propagation to be done all request will still hit the servers. Problem if the expiration time is too short.

    2. It's able to cater the time based redirection, while the usage limit need to be done by CloudWatch alarm that monitoring CloudFront request and use that alarm to call CloudFront api to clear the configuration and it may not realtime.

  - knowing all the limitation, this method is very good if the redirection configuration have long expiration time and no usage limitation, other than that need to have work around which may just by pass and use back logic on server.