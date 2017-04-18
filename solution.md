# Solution.md
Maybe using [CloudFront] and [Lambda] as url shortener microservice is unordinary solution (possibly a hack) but is easier and posibly cheaper way than to deploy and manage "Node.js on docker with autoscaling every edge location" or AWS Elastic Beanstalk.
Anyhow we can just remove serverless Lambda part with Node.js/autoscaling 

### Resolving a short Url
After a request land on CloudFront, CloudFront will trigger a Lambda (or [Lambda@Edge]) function to query [ElastiCache]/Redis. If matching url found it will redirect request.
If not it will redirect to a static "Requested url is not found" page (in CloudFront).

### Registering a new Url
[Amazon API Gateway] will handle new register request and trigger Lambda function.
Function responsible for:
- Will create new random short code (probably [a-zA-Z0-9]{6,9} for security purposes)
  If we use an encrypted version of insert id as short code, it may violate banned word policy. 
  And we can use custom code for special purposes like "trav.ix/easter". Still is negotiable.
- Check if has match in banned words (if so repeat step 1)
- Check is unique (if so repeat step 1)
- Insert to database
- Insert to ElastiCache/Redis locations with ttl

### Rebooting system on any failover
Trigger with Amazon API Gateway -> Lambda or any detection trigger system -> Lambda
Read all valid codes from database and instert/update ElastiCache/Redis locations

[Lambda]: <https://aws.amazon.com/lambda/>
[Lambda@Edge]: <http://docs.aws.amazon.com/lambda/latest/dg/lambda-edge.html>
[CloudFront]: <https://aws.amazon.com/cloudfront/>
[Amazon API Gateway]: <https://aws.amazon.com/api-gateway/>
[ElastiCache]: <https://aws.amazon.com/elasticache/>