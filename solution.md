# Solution.md
This is a simple basket / product list application. Based on this three models (product, categories, basket):

        // Product model

        {
            "id": "String",
            "name": "String",
            "availability": "Number", //if 0 = not available
            "categoryId": "String",
            "description": "String",
            "images": ["String"],
            "promotion": {
                "type": "String", // percent, price
                "value": "Number"
            },
            "price": {
                "currencyCode": "String",
                "total": "Number",
                "totalWithTaxes": "Number",
                "taxes": {
                    "total": "Number",
                    "items": [
                        {
                            "type": "String",
                            "value": "Number"
                        }
                    ]
                }
            }
        }

        // Categories model

        [
            {
                "id": "String",
                "name": "String"
            }
        ]


        // Basket model

        [
            {
                "id": "String",
                "quantity": "Number"
            }
        ]


We create three stores on UI side for products, categories and basket. When user starts the application we are checking if there were any products already selected from previous session and validate the with recent data from services (availability, prices, promotions).

Products can be paginated so each time user reach the bottom we are auto loading next page of records. Or we simply display all the oages and user can manually navigate.

User can select a quantity of a product before adding it into a basket. When adding application will validate if product is already there and update / put if needed.

User will be able to remove products from card either by reducing their quantity or just removing whole products from a cart.

User will be able to review product detailed prices when requested. That way we are displaying total price, price per item and tax breakdown.

After selecting product user will be able to checkout and pay for products.



