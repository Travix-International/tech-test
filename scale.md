# Scale
In my solution I prefer to use Amazon [CloudFront], AWS [Lambda] and [Amazon API Gateway].
AWS Lambda takes care of scaling with high availability. 
Querying from Amazon ElastiCache at other edge locations is simpler and more budget way to scale database to multiple location with horizontaly and verticaly.


[Lambda]: <https://aws.amazon.com/lambda/>
[CloudFront]: <https://aws.amazon.com/cloudfront/>
[Amazon API Gateway]: <https://aws.amazon.com/api-gateway/>
[ElastiCache]: <https://aws.amazon.com/elasticache/>