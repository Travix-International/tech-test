# Questions
- Requirements says that the system should handle urls of any length. However the max length for both url or query string will be UInt max.
- Fragments are browser features it will never be to the server and it stays on the url after redirection.
- The short url expiry time will be configurable by the system admin or each user will set the expiry time of each url.
- Can we reuse the deactivated urls.
- What will be the replacement of 404 not found error, will an error page be enough.
- Should the system handle the segments after the short url or just regard it as invalid url (ex. travx.ix/abcd for https://facebook.com what will tavx.ix/abcd/messages mean ?)
- Can user deactivate his short urls manually before it expires.
- Authentication and Authorization are totally absent on the requirements, will it be internal or public system.
