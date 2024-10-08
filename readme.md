# Azure and C# learnings

A test project for capturing my learnings around c#, azure etc.

## Create DLL

`dotnet publish`

## Run release version

`dotnet run path/to/release.dll`

## Deploy to Azure

### Azure app service

- Create webabb via web
  - resourcegroup name `my-first-api-group`
  - name `my-first-api`
  - region `UK South`
- az login
- `az webapp up --name my-first-api --resource-group my-first-api-group --location uksouth`
- `az webapp delete --name my-first-api --resource-group my-first-api-group`
- `az group delete --name my-first-api-group --yes --no-wait`

## Docker

`docker build -t api .`

`docker run -it --rm -p 9999:8080 --name api_example api`

## Deploy to azure container app

### Add image to Azure Container Registry

`az group create --name myResourceGroup --location uksouth`

`az acr create --resource-group myResourceGroup --name <ACR_NAME> --sku Basic`
(the above command takes a while. ACR name must be unique)

`az acr login --name <ACR_NAME>`

`docker tag api <ACR_NAME>.azurecr.io/api:latest`

`docker push <ACR_NAME>.azurecr.io/api:latest`
(the dockerfile for this is huge and needs to be minimised)

### Create azure container app

Container apps are in preview???

Enable the feature
`az extension add --name containerapp`

Creates a container app ENVIRONMENT and not a container app. thats the next step.
`az containerapp env create --name myContainerAppEnv --resource-group myResourceGroup --location uksouth`

Create the container app

`az containerapp create --name myapi --resource-group myResourceGroup --environment myContainerAppEnv --image <ACR_NAME>.azurecr.io/api:latest --target-port 80 --ingress 'external'`

`az containerapp create --name myapi --resource-group myResourceGroup --environment myContainerAppEnv --image intrepidtiger.azurecr.io/api:latest --target-port 80 --ingress 'external'`

this fails due to not being authorised. to Resolve? - Doesnt work

`az acr update -n <ACR_NAME> --admin-enabled true`

https://learn.microsoft.com/en-gb/azure/container-registry/container-registry-authentication?WT.mc_id=Portal-fx&tabs=azure-cli#admin-account

`az containerapp show --name myapi --resource-group myResourceGroup --query "configuration.ingress.fqdn" --output table`

## Tear down

`az containerapp env delete -n myContainerAppEnv -g MyResourceGroup -y`

## Data access

add package `dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL`

Followed this [Reference example](<[bar](https://medium.com/itthirit-technology/create-rest-api-using-net-core-and-entity-framework-with-postgresql-7a06fe29b81b)>) with a few changes (364e0739733790b2fcc3723d7191d659073a3789)

Requires a postgres docker container running.

`docker pull postgres`

`docker run -p 5432:5432 --name some-postgres -e POSTGRES_PASSWORD=mypassword -d postgres`

Need to look at data migrations.
