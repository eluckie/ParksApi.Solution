# Parks API 

#### By E. Luckie ☀️

#### This project is an API for state and national parks. The API will list state and national parks.

## Technologies Used

* C#
* .NET 7.0
* Postman
* Swagger
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

<!-- GET http://localhost:5000/api/animals/

GET http://localhost:5000/api/animals/{id}

POST http://localhost:5000/api/animals/

PUT http://localhost:5000/api/animals/{id}

DELETE http://localhost:5000/api/animals/{id} -->

### Optional Parameters

<!-- | Parameter | Type | Required | Description |
| --------- | ----- | ------- | ----------- |
| species | string | not required | returns animals with a matching species value |
| name | string | not required | returns animals with a matching name value | 
| minimumAge | number | not required | returns animals than have an age value that is greater than or equal to the specified minimumAge value | 

#### Example Queries
* The following query will return all animals with a species value of "Dinosaur":
```GET http://localhost:5000/api/animals?species=dinosaur```

* The following query will return all animals with the name "Matilda":
```GET http://localhost:5000/api/animals?name=matilda```

* The following query will return all animals with an age of 10 or older:
```GET http://localhost:5000/api/animals?minimumAge=10```

* It's possible to include multiple query strings by separating them with an `&`:
```GET http://localhost:5000/api/animals?species=dinosaur&minimumAge=10``` -->

### Additional Requirements

<!-- #### for POST request

When making a POST request to `http://localhost:5000/api/animals/`, you need to include a **body**. Here's an example body in JSON:

```json
{
  "species": "Tyrannosaurus Rex",
  "name": "Elizabeth",
  "age": 8
}
```

#### for PUT request
When making a PUT request to `http://localhost:5000/api/animals/{id}`, you need to include a body that includes the animal's `animalId` property. Here's an example body in JSON:

```json
{
  "animalId": 1,
  "species": "Tyrannosaurus Rex",
  "name": "Lizzy",
  "age": 9
}
```

And here's the PUT request we would send the body to:

`http://localhost:5000/api/animals/1`

Notice that the value of `animalId` needs to match the id number in the URL. In this example, they are both 1. -->

## Known Bugs

* _Any known issues_
* _should go here_

## Stretch Plans

* Add a front end MVC application that consumes this API.
* Add a `RANDOM` endpoint that randomly returns a park.
* Add a second custom endpoint that accepts parameters. Example: a `SEARCH` route that allows users to search by specific park names.

## License

MIT License

Copyright (c) 2023 Luckie