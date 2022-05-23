# Introduction to ORM
* Object-Relational Mapper
* They are used to essentially translate data from a table structure in SQL into something C# language (basically objects)
* The ORM that we will be using is Entity Framework Core

# Entity Framework Core
* One of the popular ORM for .NET core
* It allows us to work with a database by using .NET objects and almost completely removing the need for most data-access code you usually have to write (unlike our ADO.NET)
## Two approaches to EF
* Database first approach
    * This is when you created a database architecture/schema first
    * It will create the entities and DBcontext for us based on the database
* Code first approach
    * This is when you create a .NET application first
    * It will create the database for you and establish the relationships as well based on the models
    * You would need to create the DBContext
## Useful terminology/artificats to know when working with EF
* DBContext
    * Represents a session with the database
    * So any CRUD operations will start here
    * Also used to configure how EF will construct your database architecture using **Fluent API** in OnModelCreating() method
* Migration
    * They are a snapshot of the database architecture given the current state of your models
    * So if you change your models/db architecture, you would need to create another migration and update the database
* Entities
    * It is the model version of the tables of your database
    * So a Student table in Database will have a student entity in EF core
* Relationships
    * Same thing as multiplicity in SQL
    * They way you signify the relationships will be use of data annotations/Fluent API/Model structure

## [EF Core](https://www.entityframeworktutorial.net/code-first/inheritance-strategy-in-code-first.aspx)
- Most conventions and steps for EFCore Code first and EF6 are same
### Packages
Install the listed packages in your DL project:
- ```dotnet add package Microsoft.EntityFrameworkCore.Tools``` or ```Install-Package Microsoft.EntityFrameworkCore.Tools```
- ```dotnet add package Microsoft.EntityFrameworkCore.SQLServer``` or ```Install-Package Microsoft.EntityFrameworkCore.SQLServer```

### DB First Steps
1. Have the following:
    - Data Layer
    - The necessary packages installed in DL project
2. Run the long Scaffold/reverse engineering code in the DL project:
    - With Fluent API - 
        - `dotnet ef dbcontext scaffold -o Entities "Server=(Azure database).database.windows.net,1433;Initial Catalog=(Db name);User ID=(username);Password=(Password);" Microsoft.EntityFrameworkCore.SqlServer --table tablename1 --table tablename2`
    - Connection String with Data Annotations: `dotnet ef dbcontext scaffold "Server=tcp:<server name>.database.windows.net,1433;Initial Catalog=<db name>;User ID=<user id>;Password=<Password>" Microsoft.EntityFrameworkCore.SqlServer --force --data-annotations -o Entities`
3. Edit the DBContext:
    - Change the name if its weird
    - Edit the onconfiguring method to safely refer to the connection string using appsettings.json
4. Any major change to table structure:
    - If you add a new table, delete a table: go to step 2
    - If you've altered columns in an existing table: edit the necessary entity to reflect those changes

Other things you'll need with DBFirst:
- A Mapper to map your DB entities to BL entities

### [Code First Steps](https://www.entityframeworktutorial.net/code-first/what-is-code-first.aspx)
1. Have the following:
    - Data Layer
    - The necessary packages installed in DL project
    - Appsettings.json in both your startup project and root folder of the solution
2. Implement a DbContext
    - Override the `OnConfiguring` method to point to the connection string stored in your appsettings.json
    - Override the `OnModelCreating` method to manually map some relationships EF Core complains about
3. Run the migration code in the DL project
    - `dotnet ef migrations add NameOfMigration -c DbContext --startup-project <relative path to project file>`. Ex `dotnet ef migrations add InitialCreate -c PokeDbContext --startup-project ../PokemonApi/PokemonApi.csproj`
    -                            or
    - ``` Add-Migration "Name of the Migration"``` (In PMC point it to Data project)
4. Update your DB in the DL project
    - `dotnet ef database update --startup-project <relative path to project file>` or
    - ```Update-Database``` (In PMC point it to Data project)
5. Any changes to your models/entities go to step 3


# References
- [Learn about EFCore](https://docs.microsoft.com/en-us/learn/modules/persist-data-ef-core/)
