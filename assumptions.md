# Assumptions
- Shortened URL’s are saved with request method - GET or POST
- Shortened URL’s are saved with standard and non-standard Headers
- Shortened URL’s are saved with query parameters
- Shortened URL’s are saved with URL fragments
- Accessing invalidated URL’s (TTL expired or on-shot used) will suggest a funny URL to visit
- Shortened URL’s can only be requested with the method they were saved with - GET or POST