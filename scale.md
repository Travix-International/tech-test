# Scale

- For our frontEnd servers, we can use use a small machine on a clould solution, using NGINX to distribuit our dynamic content, thinking that out frontEnd does not have any logic maintened on the server side like ASP.net, for example;
- For static content, we can use a small machine on a cloud solution, prepared for Scale Out and for high number of requests. To deacrease the number of requests, we can use a CDN like Akamai or Verizon, to "cache" our static content and distribuit our content among many locations around the world;
- For our middleware, we can host our services on a cloud solution, with medium machines prepared for Scale Out based on number of requests or cpu and memory consumptions.
- For our development team, we need to distribuit a local docker image, with the latest release from production, recovering the image on Sprint Release to be aproved and deployed on the environments. 