# Scale
 
 * Using Elastic Beanstalk All EC2 will be able to have load balance  and we can monitor the instance workload and make them bigger has needed.  We can have at least 4 load ec2 instance per service so we can have a always online while the scale process occur. It is important to set cloud watch alarms to determine when the scale is needed and actually goes beyond the initial auto scale rules.
 
* Cloudfront distribution in multiple regions to guarantee the multiple location delivery in different parts of the world.
 
* We can also break down the backend and frontend into separated  instance by using api.Trawiller.com for backend and Trawiller.com for front end that way we can balance the traffic and scale more efficient.
 
* The amazon lamda will guarantee microservices independence so any future improvement will allows constant integration so we can able to scale without disrupting the service if code optimization are needed.
 
 
 
