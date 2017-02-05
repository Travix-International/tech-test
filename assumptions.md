# Assumptions

1. Max url character 2,083
2. For Post shortening max header size 16kb
3. For hash [A-Z,a-z,0-9] 7 charactered hash=> It can generate 3trillion differnce url
4. Per month new urls 100M
5. 1 BN requets per month
6. Request per second 400 average (20 Get shorten,20 Post shorten,180 GEt redirect,180 Post redirect)
7. 10% shortening and 90%redirection (Get and post percentages are same)
8. Row size cost of row 7 * 4byte +2083* 4byte = 8.4 kb for Get request ,8.4kb +16kb = 24,4kb for Post request
9. Yearly 1 year X 12 mohtns x 100M = 1,2BN yearly url count
10. Written new data per second (GET)20*8.4KB =168KB  (POST)20*24.4KB =488kb => 656KB write per second
11. Data read per second (GET)180*8.4KB =1.5MB  (POST)180*24.4KB =4.3MB => 5.8MB read per second
12. 1,6 TB data per year