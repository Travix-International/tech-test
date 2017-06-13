# Assumptions

- Each item has a single price

- different product types may have different attributes, eg digital download product might have mp3 quality, or video file format, physical product might have size or colour options

- the same digital product cannot be added to the basket more than once, but you can add 2 versions with different file formats

- Stock control and inventory is not required, but stock ID (SKU) is used for physical products

- discount codes can be either absolute, eg £5 off when you spend £20 or as a percentage eg 10% off

- discount codes are automatically applied when items are added to or removed from the basket, or when basket is resynced on loading

- an item may or may not have an image associated with it (eg if digitalProduct is a pdf file it might not have an image)

- System is designed for anonymous checkout 
[ note: anonymous checkout is preferred as it leads to higher conversion rates in practice. but if system needs to allow people to save baskets and retrieve on different devices, or share baskets with other people then authentication will be required, and local storage will need to be kept in sync with server every time the basket state changes]

- Browser local storage will be used to save basket data between sessions - therefore Browsers less than IE8 are not supported
(pros - lower server resources and much higher scalability, cons - limits browser to IE8 or above, requires local storage to be available, prevents cross device access to shopping bags)

- Total data for all a customer's shopping baskets will not exceed 2MB storage space (this is the limit for some older v4 android browsers). 

- For security, if using private browsing, shopping bag data will not persist across sessions.

- only one discount code can be applied to an order at one time (avoids the < £0 total price issue)

- different tax bands applicable to each type of product, but same tax rate is used to all items of that type - so if for example an item type is 'clothing' and is taxable then will need to create an separate item type of 'childrens clothing' which is tax exempt

- when saved baskets are loaded or user resumes a shopping session, the basket is synced with the system to ensure that the prices are correct and the items are still available

- same API is used for both mobile and desktop versions

- Tax is recalculated after the shipping address is changed, or when items are added or removed from the basket, or when basket is resynced on loading

- system does not support multiple languages or currencies







 