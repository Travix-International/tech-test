# Solution

The system will consist of 3 projects

## 1. URL Shortener Resolver API

This URL shortener resolver is the one that will received call from user and redirect it to destination URL as per configuration

Here's the system diagram

![](system-context-diagram-api.jpg)

Database will consist of Key and Destination URL, which key is the path of the URL exclude domain and query string

ie. http://trav.ix/**a1/b2**?q=test

The Key will be **a1/b2**

System will use this Key to get Destination URL and additional check that need to be in place such as 

1. origin checking : accessed by public user or machine

2. usage limit 

3. expiration date

If everything passed, then the Destination URL + query string will be passed back to browser using response redirect 307 (to cater GET and POST methods)

Provided the browser able to make it especially for POST, if not then system will provide a page with javascript triggered on load to do the redirection.

## 2. Backoffice to configure URL shortener resolver

Backoffice will accessing same redis and postgre database as URL Shortener Resolver

It will clear redis cache and modify database record

## 3. Job Monitoring

This job will monitor existing configuration and try to call the Destination URL, and give alarm and disable if the Destination URL is no longer vaid.