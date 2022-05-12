FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app

COPY . ./

RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime

WORKDIR /app

COPY --from=build /app/publish ./

CMD ["dotnet", "WeatherApi.dll"]

EXPOSE 80
EXPOSE 443


#  make sure you are in Weather api in terminal, 
# Build the image - : docker build -t weather-api-image -f Dockerfile .
# check if the image is available - docker images
# if the image created above is available, the run the image without creating a container (docker daemon is going to assign a container with a random generated name)
# to run the image  - docker run -it --rm -p 5000:80 weather-api-image
