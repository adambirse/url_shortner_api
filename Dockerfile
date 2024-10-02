# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
# TODO docker ignore for bin directories etc
COPY src/*.csproj ./src/
# shouldnt need this
COPY test/*.csproj ./test/

# RUN echo "Checking /source/src after copying csproj:" && ls -al ./src
RUN dotnet restore

# # copy everything else and build app
COPY src/. ./src/
WORKDIR /source/src
RUN dotnet publish -c release -o /app

# # final stage/image
# FROM mcr.microsoft.com/dotnet/aspnet:8.0
# WORKDIR /app
# COPY --from=build /app ./
# ENTRYPOINT ["dotnet", "src.dll"]
ENTRYPOINT [ "dotnet", "/source/src/bin/release/net8.0/src.dll" ]