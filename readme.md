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
