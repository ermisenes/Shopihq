Swagger Adress : https://localhost:44379/swagger/index.html

--------------------------------------------------
/api/Orders/get/all : Get all orders
--------------------------------------------------
/api/Orders/add  : Add order 
Example Usage ;
{
  "id": 8080,
  "brandId": 1996,
  "price": 31,
  "storeName": "Yozio",
  "customerName": "Mylène",
  "createdOn": "2021-04-21T04:37:07Z",
  "status": 10
}
--------------------------------------------------
/api/Orders/get : filtered with data
Example Usage ;
{
  "pageSize": 20,
  "pageNumber": 1,
  "searchText": "string",
  "startDate": "2021-01-01T00:00:00.000Z",
  "endDate": "2021-12-31T23:59:59.999Z",
  "statuses": [
    20
  ],
  "sortBy": "BrandId"
}
--------------------------------------------------
