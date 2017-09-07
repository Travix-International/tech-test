# Solution

## Big Picture

![Bigpicture](/blob/master/bigpicture.jpg)
Format: ![Bigpicture](url)

The proposed solution is composed by a frontend and a backend applications. The frontend built as SPA using VueJS. The objective of frontend is to allow a easy way to generate short URLs manually.

The backend, built with ASP.NET Core MVC and HazelCast as Database, has two main responsibilities: 

1. Generate a short URL receiving the target site URL with your configurations (expires date, one-shot usage, friendly error URL or a flag if it is a URL that will receive POST request). This endpoints of API could be used by either frontend application or others client applications.

2. Handle the short URL: validating the criteria and returning HTTP Status Code 302 response with appropriate location header parameter.

The most of steps of step by step shown by the bigpicture.jpg image are auto explaining. However, it is important to pay attention in flowchart.

When the backend receive the short URL in step 5, there are three possible paths:

* 6.1) The short URL is invalid because of some criteria or the short URL doest not exist, then the response of API is a HTTP Status Code 302 and header location parameter filled with the friendly error URL configured or a generic error page.

* 6.2) The short URL is valid and it is not configured as POST, it is a GET, then the response of API is a HTTP Status Code 302 and header location parameter filled with the target URL saved in database.

* 6.3) The short URL is valid and it is POST, then the response of API is a HTTP Status Code 302 and header location parameter filled with the URL returned by target system.

After 6.2 or 6.3 step, if necessary, the parameter one-shot usage must be updated in database.

## Design

![Design of solution](/blob/master/design.jpg)
Format: ![Design of solution](url)

About design in design.jpg picture, the key points are: 

* The URL Shorter is a kind of facade between the core of Trav.ix and the algorithms to short a URL. URL Shorter can have his own implementation or call other classes.

* The Post Executor is responsible to resend all header parameters to target system.