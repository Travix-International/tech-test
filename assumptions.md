# Assumptions
* Shortener.API creates 10 characters long shortUrls for one time use, and 9 characters long for others.
* Creating short urls will be allowed only from inline network.
* Both applications will be written with .NET Core or NodeJs, mainly because it can be deployed both Linux and Windows, and they have Docker support. Considering scalability is our main concern in case of high request count.
* All builds and deploys must be made using a CI tool (like Teamcity etc.) 
* Unit/Contract tests must be runned as a first step on CI tool, and it should skip if any of the tests fails or coverage results are low. 
* Each build must be versioned and stored on package manager, in case of reverting to previous version. (like NuGet, npm etc.)
