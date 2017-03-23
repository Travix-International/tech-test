# Scale
- Only load previews for big Animated GIFs, Large Videos, VR to avoid page from freezing, load that content as part of iframe on request and then destroy it to have a small memory snapshot.
- Limit and try to reduce the API endpoint response sizes. Optimize for only the most desirable result and create more specific endpoints for those scenarios than actually returning data that's mostly related but user doesn't directly interact with it mostly.
- Implement local caching and service workers so server isn't hit constantly for each request.
- Rate-limit get updated timeline calls to 1 per 5 seconds.
- To avoid flooding:
  - if user tries to post more 10 posts per min, each subsequent request should have extra captcha validation step. 
  - Disallow a user from posting more than 50 public posts per hour.
  - Sustain a higher limit (say 100 posts per hour) and avoid captcha if a user is replying to another user, this will help to boost engagement.
