# carsalesales API

- [CarSales API](#carsales-api)
  - [Create CarSales](#create-carsales)
    - [Create CarSales Request](#create-carsales-request)
    - [Create CarSales Response](#create-carsales-response)
  - [Get CarSales](#get-carsales)
    - [Get CarSales Request](#get-carsales-request)
    - [Get CarSales Response](#get-carsales-response)
  - [Update CarSales](#update-carsales)
    - [Update CarSales Request](#update-carsales-request)
    - [Update CarSales Response](#update-carsales-response)
  - [Delete CarSales](#delete-carsales)
    - [Delete CarSales Request](#delete-carsales-request)
    - [Delete CarSales Response](#delete-carsales-response)

## Create CarSales

### Create CarSales Request

```js
POST /carsales
```

```json
{
    "make": "BMW",
    "model": "M3",
    "year": "2011",
    "color": "Silverstone Metallic",
    "kilometres": 38490,
    "saleprice": 99800,
    "listDateTime": "2022-04-08T08:00:00",
    "options": [
        "Sunroof",
        "Electric seats",
        "Sports exhaust",
        "Comfort package"
    ]
}
```

### Create carsales Response

```js
201 Created
```

```yml
Location: {{host}}/carsales/{{id}}
```

```json
{
    "id": "0000-00000-00000-0000",
    "make": "BMW",
    "model": "M3",
    "year": "2011",
    "color": "Silverstone Metallic",
    "kilometres": 38490,
    "saleprice": 99800,
    "listDateTime": "2022-04-08T08:00:00",
    "lastModifiedDateTime": "2022-04-08T08:00:00",
    "options": [
        "Sunroof",
        "Electric seats",
        "Sports exhaust",
        "Comfort package"
    ]
}
```

## Get carsales

### Get carsales Request

```js
GET /carsales/{{id}}
```

### Get carsales Response

```js
200 Ok
```

```json
{
    "id": "0000-00000-00000-0000",
    "make": "BMW",
    "model": "M3",
    "year": "2011",
    "color": "Silverstone Metallic",
    "kilometres": 38490,
    "saleprice": 99800,
    "listDateTime": "2022-04-08T08:00:00",
    "lastModifiedDateTime": "2022-04-08T08:00:00",
    "options": [
        "Sunroof",
        "Electric seats",
        "Sports exhaust",
        "Comfort package"
    ]
}
```

## Update carsales

### Update carsales Request

```js
PUT /carsales/{{id}}
```

```json
{
    "make": "BMW",
    "model": "M3",
    "year": "2011",
    "color": "Silverstone Metallic",
    "kilometres": 38490,
    "saleprice": 99800,
    "listDateTime": "2022-04-08T08:00:00",
    "options": [
        "Sunroof",
        "Electric seats",
        "Sports exhaust",
        "Comfort package"
    ]
}
```

### Update carsales Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/carsales/{{id}}
```

## Delete carsales

### Delete carsales Request

```js
DELETE /carsales/{{id}}
```

### Delete carsales Response

```js
204 No Content
```