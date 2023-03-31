# Parks API 

#### By E. Luckie ☀️

#### This project is an API for state and national parks. The API will list state and national parks.

## Technologies Used

* C#
* .NET 7.0
* Postman
* Swagger
* NewtonSoft
* Markdown
* Git


## Description

_{This is a detailed description of your application. Give as much detail as needed to explain what the application does as well as any other information you want users or other developers to have.}_


## Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory. called "ParksApi".
3. Within the production directory "ParksApi", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `[YOUR-USERNAME-HERE]` and `[YOUR-PASSWORD-HERE]` with your own credentials for MySQL. 

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parks_api;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

5. Within the production directory "ParksApi", run `dotnet run` in the command line to start the project in development mode.

_{ADD STEPS FOR RESTORING THE DATABASE ETC.}_

## Endpoints

_{screenshot swagger endpoints?}_

### Optional Parameters

| Parameter | Type | Required | Description |
| --------- | ----- | ------- | ----------- |
| city | string | not required | returns parks with a matching city value |
| state | string | not required | returns parks with a matching state value | 
| statePark | boolean | not required | returns parks that have a StatePark property value of true |
| nationalPark | boolean | not required | returns parks that have a NationalPark property value of true |
| pageSize | int | default value set to 10 | value is editable to change the amount of parks displayed per page in the response |  
| pageNumber | int | default value set to 1 | value is editable to change the current page number of results displayed in the response |

#### Example Queries
_{screenshot example queries ?}_

<!-- * The following query will return all animals with a species value of "Dinosaur":
```GET http://localhost:5000/api/animals?species=dinosaur```

* The following query will return all animals with the name "Matilda":
```GET http://localhost:5000/api/animals?name=matilda```

* The following query will return all animals with an age of 10 or older:
```GET http://localhost:5000/api/animals?minimumAge=10```

* It's possible to include multiple query strings by separating them with an `&`:
```GET http://localhost:5000/api/animals?species=dinosaur&minimumAge=10``` -->

### Additional Requirements

#### for POST request

When making a POST request to `http://localhost:5000/api/Parks/`, you need to include a **body**. Here's an example body in JSON:

```json
{
  "name": "Rocky Mountain Nat'l Park",
  "city": "Estes Park",
  "state": "Colorado",
  "nationalPark": true,
  "statePark": false
}
```

#### for PUT request

When making a PUT request to `http://localhost:5000/api/Parks/{id}`, you need to include a body that includes the park's `parkId` property which must match the id number in the URL. Here's an example body in JSON:

```json
{
  "parkId": 1,
  "name": "Rocky Mountain National Park",
  "city": "Estes Park",
  "state": "Colorado",
  "nationalPark": true,
  "statePark": false
}
```

And here's the PUT request we would send the body to:

`http://localhost:5000/api/Parks/1`


## Known Bugs

* No known bugs.

## Stretch Plans

* Add `PATCH` functionality.
* Add a `RANDOM` endpoint that randomly returns a park.
* Add a second custom endpoint that accepts parameters. Example: a `SEARCH` route that allows users to search by specific park names.
* Add a front end MVC application that consumes this API.

#### Further Exploration Topics
>* Token-based authentication
>* API versioning
>* Enable CORS

## License

MIT License

Copyright (c) 2023 Luckie