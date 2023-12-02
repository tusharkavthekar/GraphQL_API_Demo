# GraphQL_API_Demo
GraphQL_API_Demo
https://localhost:7117/graphql/

query{
productlist {
id,
productName,
productDescription,
productPrice,
productStock
}
}

then run -> will show list of data in productList
{
  "data": {
    "productList": [
      {
        "id": "7c10316a-46d5-48de-ab75-06bc35ffe690",
        "productName": "IPhone",
        "productDescription": "IPhone 14",
        "productPrice": 120000,
        "productStock": 100
      },
      {
        "id": "982ced7a-b405-47e5-b8a1-47e44571734c",
        "productName": "Samsung TV",
        "productDescription": "Smart TV",
        "productPrice": 400000,
        "productStock": 120
      }
    ]
  }
}
-------------------------------------------------
productDetailsById

Operation
{
  productDetailsById(productId: "7c10316a-46d5-48de-ab75-06bc35ffe690") {
    id
    productName
    productPrice
    productStock
  }
}
Response:
{
  "data": {
    "productDetailsById": {
      "id": "7c10316a-46d5-48de-ab75-06bc35ffe690",
      "productName": "IPhone",
      "productPrice": 120000,
      "productStock": 100
    }
  }
}

-------------------------------------------------
Insert Product

Operation
mutation($productDetails:ProductDetailsInput!){
addProduct(productDetails: $productDetails)
}

Request
{
  "productDetails":{
        "id": "7c10316a-46d5-48de-ab76-06bc35ffe690",
        "productName": "IPhone",
        "productDescription": "IPhone 15",
        "productPrice": 150000,
        "productStock": 1500
      }
}

Response:
{
  "data": {
    "addProduct": true
  }
}
------------------------------------------------------------------
Update Product

mutation($productDetails:ProductDetailsInput!){
updateProduct(productDetails: $productDetails)
}

Request:
{
  "productDetails":{
        "id": "7c10316a-46d5-48de-ab77-06bc35ffe690",
        "productName": "IPhone",
        "productDescription": "IPhone 6",
        "productPrice": 10,
        "productStock": 10
      }
}

Response:
{
  "data": {
    "updateProduct": true
  }
}
---------------------------------------------
GetProduct List after Insert & Update
Operation:
query {
  productList {
    id
    productName
    productDescription
    productPrice
    productStock
  }
}
Response:
{
  "data": {
    "productList": [
      {
        "id": "7c10316a-46d5-48de-ab75-06bc35ffe690",
        "productName": "IPhone",
        "productDescription": "IPhone 14",
        "productPrice": 120000,
        "productStock": 100
      },
      {
        "id": "982ced7a-b405-47e5-b8a1-47e44571734c",
        "productName": "Samsung TV",
        "productDescription": "Smart TV",
        "productPrice": 400000,
        "productStock": 120
      },
      {
        "id": "7c10316a-46d5-48de-ab76-06bc35ffe690",
        "productName": "IPhone",
        "productDescription": "IPhone 15",
        "productPrice": 150000,
        "productStock": 1500
      },
      {
        "id": "7c10316a-46d5-48de-ab77-06bc35ffe690",
        "productName": "IPhone",
        "productDescription": "IPhone 6",
        "productPrice": 10,
        "productStock": 10
      }
    ]
  }
}

---------------------------------------------------------------------------------------
Delete Product
Operation:
mutation($productId:UUID!){
  deleteProduct(productId: $productId)
}
Request:
{
  "productId": "7c10316a-46d5-48de-ab77-06bc35ffe690"
}
Response:
{
  "data": {
    "deleteProduct": true
  }
}
--------------------------------------------------------------
After delete
{
  "data": {
    "productList": [
      {
        "id": "7c10316a-46d5-48de-ab75-06bc35ffe690",
        "productName": "IPhone",
        "productDescription": "IPhone 14",
        "productPrice": 120000,
        "productStock": 100
      },
      {
        "id": "982ced7a-b405-47e5-b8a1-47e44571734c",
        "productName": "Samsung TV",
        "productDescription": "Smart TV",
        "productPrice": 400000,
        "productStock": 120
      },
      {
        "id": "7c10316a-46d5-48de-ab76-06bc35ffe690",
        "productName": "IPhone",
        "productDescription": "IPhone 15",
        "productPrice": 150000,
        "productStock": 1500
      }
    ]
  }
}
--------------------------------------------------------------

