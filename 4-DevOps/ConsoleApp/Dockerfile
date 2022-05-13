# comments in docker file
# Docker file is the recipe for building your docker image


# General things before you do in a dockerfile
# 1. choose the base image : you can get your base image (a) locally (b) from registry (docker hub)
# 2. copy files from outside the image into the image
# 3. run terminal commands inside the image (eg: installing things)
# 4. add configuration/environmental variables if required


# to set the base image we do this
#    Registry      repo/image     tag
#  (bydefault, dockerhub)      (latest)
#     |        |                |
FROM mcr.microsoft.com/dotnet/sdk:latest AS build-env
WORKDIR /app

COPY . ./

RUN dotnet restore

# the runtime needs assemblies already compiled
# so before "docker build", run:
RUN dotnet publish -c Release -o publish

# take the contents of the published folder outside docker....
# .... put them in a new folder /app at the root of the docker's file system
#COPY publish /app
FROM mcr.microsoft.com/dotnet/sdk:6.0
COPY --from=build-env  /app/publish .

# after building the image, we can run container's app like:
# docker run "docker container name" or "docker SHA" //app/ConsoleApp.dll
# replacing the docker's SHA with your image's HASH

# we can configure the image with default command to startup with
CMD dotnet ConsoleApp.dll 4


# commands used in terminal for docker CLI
# 1. create an image - `docker build -t "image/tag name" -f "Dockerfile"`
# 2. check if the image is created successfully `docker images`
# 3. create a container for the image to run and tied/attach the image to the container
#   `docker create --name "container-name" "image tag" , this command will return the hash of the container created
# 4. check if the container is created `docker ps -a`, see if you container named above is created
# 5 Run the container `docker start "HASH of the container or container-name"
# 6. check on the docker desktop if your container run successfully
