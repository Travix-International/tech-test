# Scale

1. Use cache for expensive queries and optimize indexes 
2. Offload heavy process like video upload, image resizing, text processing into servers with higher computational capabilities.
3. Use Content Delivery Networks (CDN) to offload the job of serving static files across several geographical regions.
4. The CDN should be able to enable HTTP caching and have options to minify and gzip static files for a better performance.
4. Use load balancers to spread the traffic across several web servers.
5. Resort to HTML Fragment Caching for those content that don't change often.
6. Use caching on the client side, cache those requests that will most likely return the same response.
