# Solution.md
For the conception of Trawiller, several architectural options were studied. Because this kind of platform is traffic intensive and the need to react fast to changes is a must, it became clear that a distributed architecture should be adopted along with an approach to deliver features constantly. 

High level design

- Social login
- Microservices to accomodate organic growth in a distributed fashion
- Responsive / Cross platform front end to cope with desktop, tablets and smartphones 
- Continuous Delivery to promote faster releases in short spans of time
- Robust infrastructure with AWS

Technology Stack

- Programming language: ES6 (through TypeScript)
- Frameworks client: Angular 4, Gulp, Jasmine
- Frameworks server: NodeJs with Pm2 and Seneca, Express
- UI: Html5 (video, local storage and semantics), Angular UI
- Native app: Cordova 
- Storage: MongoDB
- APIs: OpenId for SSO
- Continuous Delivery with AWS
