# Solution.md
*The system will have 3 main components:*
1. (Assuming using ASP.NET) A controller with an action method that has a route with wildcard that handles all requests.
2. A url parsers that digs into request object and extracts any information needed. e.g : url fragments and query strings
3. A redirect url creator engine that looks in a data source, preferebly redis cache instance, to find the destination url.
    * At this point system makes any changes required to the row in the data source. like expiring it, or simple storing 
    analytic data somewhere else.
After the request passed through all the steps above, user will be redirected to the url created by redirect url engine.
