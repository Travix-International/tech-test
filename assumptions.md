# Assumptions URL shortener system

1. System user (allowed to create, edit and delete shorten URLs) will be a single Administrator
2. URL length is not limited to browser-limit since it includes machine-to-machine, but still it is limit to Text datatype in DB, if absolute unlimited then Blob will be used which is strongly unadvised in high-scalable
3. Any scheme means HTTP and HTTPS
4. Threads will be managed by web-server level (e.g. apache)
5. High availability and Cloud will be managed at server-level
6. Standard LAMP environment
