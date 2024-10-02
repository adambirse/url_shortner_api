# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY src/*.csproj ./src/
# shouldnt need this
COPY test/*.csproj ./test/

# RUN echo "Checking /source/src after copying csproj:" && ls -al ./src
RUN dotnet restore

# # copy everything else and build app
COPY src/. ./src/
WORKDIR /source/src
RUN dotnet publish -c release

# # final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /source/src/bin/release/net8.0/ ./
ENTRYPOINT ["dotnet", "src.dll"]