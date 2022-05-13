# base image of the image, like you install .net sdk before you start development so that your dotnet cli commands work
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
# its like mkdir and cd in linux, it makes directory if it doesn't exist and navigates it to that directory
WORKDIR /app
# to expose the app to port 80 for http and 443 for https in docker env
EXPOSE 80
EXPOSE 443

# to run commands like dotnet build, dotnet restore you need sdk to be installed
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

#creating a new folder to keep source code within app folder
WORKDIR /src
# copying the contents of pokemonapi to docker app/src folder
COPY ["PokemonApi/PokemonApi.csproj", "PokemonApi/"]

#Restores any deps that we would need
# if the csproj files have not changed since the last build
# on this laptop, then, the above layers will be recovered from cache,
# and we don't need to run restore again.
RUN dotnet restore "PokemonApi/PokemonApi.csproj"
# copy all the files 
COPY . .
WORKDIR "/src/PokemonApi"
# to ensure there is no error before image is created and
# Publishes the application and its dependencies to a folder for deployment to a hosting system.
RUN dotnet build "PokemonApi.csproj" -c Release -o /app/build

# From the build stage, I wanna get the published version of my app
FROM build AS publish
RUN dotnet publish "PokemonApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PokemonApi.dll"]
#this final image does not have the SDK, nor the src code, only
# 1 what's in the base image (the runtime)
# 2 my published build output