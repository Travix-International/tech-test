# URL shortener system
 
 Use NoSQL solution as permanent storage, preferably MongoDB or RethinkDB - depends to what features will be implemented in final scenario
  
 All short URL request handled by fast key-value storage, can be utilized Redis, that is in sync with noSQL DB
 
 At BackEnd used NodeJS that is handling all request, query storage and keep in sync DB and cache
 
 System deployed to 2 environment: stage and production. Stage deployed automatically after every GIT commit and run unit tests. Production deployment processed manually by responsible person after QA test passing on stage environment
 
 To speedup system deployment and scale can be used 3rd party cloud hosting solutions like Microsoft Azure or Amazon AWS
 
 Geo distributed instances suggested to reduce response latency
  
  
