# Assumptions
* Both applications are preferably written with .NET Core or NodeJs, mainly because it can be deployed both Linux and Windows and they have Docker support.
* All builds and deploys must be made using a CI tool (like Teamcity etc.)
* Unit/Contract tests must be runned as a first step on CI tool, and it should skip if tests fails or coverage results are low. 
* Each build must be versioned and stored on package manager. (like NuGet, npm etc.)