# Restaurant Review 

## common requirements
* good Git practices
* ~~CI with compile, automated tests, static analysis~~
* ~~CD to cloud service (like Azure App Service)~~
* Have you app containerized using a Dockerfile. make sure you have your image ready and pushed on docker hub.
* Deploy your app on Azure App service (either code or docker container mode).
* try to have swagger working in your deployed app.
* [optional] Have a Console App consuming the Api using HttpClient

### functionality
* server-side validation
* exception handling
* persistent data; no prices, restaurants, history, etc. hardcoded in C#
* logging of exceptions, ADO.Net SQL commands, and other events
* (optional: asynchronous network)

### design
* project layout given here is only a suggestion. the general idea of
  separation of concerns is a requirement.
* Use ADO.Net for middleware either with connected or disconnected approach
* use an Azure SQL DB in third normal form; include a database diagram and the script to generate Db and tables.
* don't use public fields
* define and use at least one interface

#### core / domain / business logic
* class library
* contains all business logic
* contains domain classes (restaurant/review/user)
* documentation with `<summary>` XML comments on all public types and members (optional: `<params>` and `<return>`)
* (recommended: has no dependency on UI, data access, or any input/output considerations)

#### data access
* class library
* contains ADO.Net code
* contains data access logic but no business logic
* use repository pattern for separation of concerns
* DB should be on the cloud
    * try to have DB/network access async

#### ASP.NET Core REST service
* follow standard HTTP uniform interface, except hypermedia
* good architecture
* deployed to Azure App Service
* server-side validation
* logging
* implement hypermedia, or, implement an API Description Language, e.g. using Swashbuckle / Swagger

## Overview 

- The restaurant review application is a software that lets customers leave reviews for restaurants. Designed with functionality that would help choosing the next restaurant to eat at much easier! 

### Functionality 

- add a new user 
- ability to search user as admin
- display details of a restaurant for user
- add reviews to a restaurant as a user
- view details of restaurants as a user
- view reviews of restaurants as a user
- calculate reviews’ average rating for each restaurant 
- search restaurant (by name, rating, zip code, etc.) 

### Models 

- User 
- Restaurant 
- Review 

### Note 
- Add as much models as you would need for your design 

### Additional requirements 
- Exception Handling 
- Input validation 
- Logging (to a file, no logging to the console) 
- At least 10 unit tests 
- Data should be persisted, (no data should be hard coded) 
- You should use a DB to store data 
- DB structure should be 3NF 
- Should have an ER Diagram 
- Code should have xml documentation 

### Tech Stack 
- C# 
- Xunit or NUnit
- SQLServer DB 
- ADO.Net
- Asp.Net Core Web Api
- Azure App Service
- ~~Azure Pipelines~~
- Serilog or Nlog (or any other logging frameworks) 

 
