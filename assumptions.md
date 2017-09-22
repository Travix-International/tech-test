# Assumptions
1. Only an authorized customer can add items to the basket.
2. All basket data is stored in database and processed on server side (not on frontend/site).
3. An item has only one type and only one kind.
4. Items can be sold in more that one country and they have own tax in each country.
5. A discount is applied to each product (not for a group of products).
6. The basket is active (customer have a possibility to see items in it) for limited period of time - 560 minutes (1h. 20 min. * 7).
7. After expiring the basket is not removed from the database but the status is changes to Expired, so it can't be used any more.

