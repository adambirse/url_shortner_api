# Entity Framework

Add package `dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL`

Followed this [Reference example](<[bar](https://medium.com/itthirit-technology/create-rest-api-using-net-core-and-entity-framework-with-postgresql-7a06fe29b81b)>) with a few changes (364e0739733790b2fcc3723d7191d659073a3789)

Requires a postgres docker container running.

`docker pull postgres`

`docker run -p 5432:5432 --name some-postgres -e POSTGRES_PASSWORD=mypassword -d postgres`

## Migrations

### Initial setup and creation

`dotnet add package Microsoft.EntityFrameworkCore.Design`

[Migrations](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)

`dotnet tool install dotnet-ef -g`

`dotnet ef migrations add InitialCreate`

create schema (public) in database

`dotnet ef database update`