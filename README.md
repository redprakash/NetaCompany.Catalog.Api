# Practice API with mongodb 
  - Using Dtos
  - MongoDb
  - Dependency Injection
  - Unit Test(xunit and Fluent assertions)
  - Docker

# Docker Commands Used  
### To create a username and password and to add volume
`docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db -e MONGO_INITDB_ROOT_USERNAME=mongoadmin -e MONGO_INITDB_ROOT_PASSWORD=Pass mongo`

## Using dotner  `Secret Manager` 
 https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows
  ### Initialisation
      `dotnet user-secrets init`
