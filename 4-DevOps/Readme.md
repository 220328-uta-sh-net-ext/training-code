# Software Development Life Cycle (SDLC)
* It is the process of dividing software development work into distinct phases
* Most different types of SDLC are rigid, meaning you can't skip or move around the stages easily
# 6 stages of SDLC
* Planning/Requirement Analysis
    * Where you plan your project
    * You check if certain functionalities are feasible
    * All potential options you can pursue when doing the project
        * And finding the best option that fits with budget/current resources
* Define the Project Requirements
    * You define and docuement that product requirements of the project and get them approved by the customer/client
* Design Product Architecture
    * Based on the requirements, you design more than one design approach for the product architecture
        * Product architecture is just all the tech stack you will be using to deliver the product
* Building/Developing the product
    * Where you start coding the app!
* Testing the product
    * As the name suggests, this is where you will test your applicaiton to either find bugs or see if it hits all the project requirements.
    * The application must be in the quality standards that you promised with your customer/client
* Deployment and Maintenance
    * This is when you finally deploy your app to the appropriate market
    * After deployment, you maintain the application to make sure there are no interruptions from the daily use of your end-users

# [Agile](https://agilemanifesto.org/?msclkid=852558d1d0a511ec84907b0d2472293d)
* It is more of a concept that an actual methodology
* It is all about creating a working software than spending your time creating extensive documentation that may or may not be what your client wants (Looks good on paper but vastly different in the real world app)
* You consistently communicate with the client and stakeholders about what they want in the project (little to no documentation)
## Priorities changes
* An early and continuous delivery and deployment (CI/CD)
* Quick to accept to any changes in the requirements
* Quick delivery of a working project
* Regular sessions of meetings (stand ups)
* Constant adjustment to a dynamic development environment (You have to be flexible)

# [Scrum](https://www.scrum.org/resources/what-is-scrum)
* Implementation of Agile concept
* It is a framework that helps teams work together
* It encourages collaboration and helping each other to solve problems one person might have during a **sprint**
* It consists of a series of sprints where each team has specific user stories to tackle
    * A user story is a simple description of a feature in laymen's term
    * Ex: "I want my todo app to add emojis automatically depending on the task"
        * But for you, you start thinking the AI capabilities needed to identify a specific task in an english formatted sentence and adding ASCII related to a specific emoji and then tell the client to shove it and it is impossible with your broke budget
## What are Sprints?
* It is a short period that completes a set amount of work
    * We already did a sprint with P0 accomplishment
* Usually lasts around 2-4 weeks of work
* After a sprint, teams will demonstrate what they've accomplished to each other and to the client
    * Any feedback will be used for the next Sprint
* During a sprint
    * Daily, weekly, or bi-weekly standups
    * You specify what you did
    * You specify what you'll do before the next standup
    * What blockers (problems) you have

# What is a Cloud?
* Allows the delivery of computing services over the internet ("The cloud") to offer fast innovation, flexible resources, and scalability.
* End-user doesn't have to worry about maintainence or upkeep of these servers
* Just have to worry about the costs will incur especially when your server needs heavy resources to run
## Pros
* Costs
    * Don't have to worry about infastructure costs or maintenance costs
    * You don't have to worry about utilities costs
    * The manpower required to build and maintain one
* Scaling
    * Very simple to upscale your server as your application grows
    * Can be done automatically (Kurbernetes)
    * Can also be done manually
* Security
    * Provided by the cloud provider
    * Most of them are high level companies that know how to deal with cyber attacks
## Cons
* Costs up to a certain point
    * If your company is getting too large with a lot of users then upscaling your cloud service will be more expensive than making your own infastructure

# Cloud Service Types
* IaaS
    * Infastructure as a Service
    * Instant computing infastructure, provisioned and managed over the internet
    * Configure the actual server themselves 
    * You have the most control over your cloud service
* PaaS
    * Platform as a Service removes the need for the organization to manage the underlying infastructure
    * Allows you to focus on deployment and management of your application
    * Ex: Azure Services
* SaaS
    * Software as a Service
    * You provide the software and the cloud provide will run and manage it with the services
    
# Cloud Deployment Models
* Kind of like the access modifiers in C# but instead of classes it is the organization and the general public
* Private
    * Only accessible by a certain organization or just your organization
* Public
    * Open for use by the general public
    * Ex: Gmail, yahoo mail, google website search engine, etc.
* Hybrid
    * Some resources are private and some resources are public
* Community
    * Sharing resources when you are part of a community
    * Ex: Universities, only their students have access to their cloud services

# [Docker](https://docs.docker.com/get-started/overview/)
* It is a way of packaging our application that has a bunch of dependencies that we had to install (SDK, external packages, etc.) into one single package that we can send to multiple computers and have it run flawlessly without the need of any installation process or setup process
* It is a containerization ecosystem which helps to build and ship the package(application) for deployment and it can run in any machine. 
* It works the very same way it works in a developer machine.

## What is Containerization?
* II is an solated environment for running an application.
* Involved bundling an application together with all the configuration files, libraries, and dependencies required
    * Basically get everything the application needs to run it
* When creating a container, the allocation of resoruces is dynamic
    * Meaning it will use as much resources the container needs to run the application
    * Ex: If running your app requires 1 gb of ram then it will just need that 1 gb of ram and will either increase or decrease that required depending on the workload

## What is Virtualization? (VM)
* It is a creation of a virtual machine that simulates a real computer with an operating system
* Ex: Macbook needs to create a windows virtual machine in their computer to be able to run windows only operated application.
* Machine uses Hypervisor to manage these virtual machine.
* Hypervisor is a fancy term to manage the different Virtulal machines. Ex: VirtualBox, VMware, Hyper-V(windows-only).
* Cons:
    * When you create virtual machine, the allocation of resource is static
        * Meaning once you start a virtual machine, you have to specify how much gbs of ram needed and will not dynamically change depending on the workload
        * So it is like taking a piece of your computer's resource and will keep that piece until you close down the VM
        * Ex: We have 16 gb of ram in my computer, I stated the VM to use 8 gb of ram then my computer will only have 8 gb of ram and the VM will only have 8 gb of ram and that will not change until I close the VM
    * Needs full blown OS (licensing and update is a troublesome)
    * Slow to start
## Containers over VM
* Allowing running multiple apps in isolation
* lightweight
* No need of full blown OS but use OS of the host
* Start quickly in seconds
* Needs less hardware resources 
 
# What is the purpose of Docker?
* It allows developers to work in standardized environments using Containers
    * Meaning they can work with whatever development environment (Java, .NET, Ruby, etc.) they want with whatever OS (Windows, Linux, Mac, etc.) they want and still be able to give their application to everyone (as long as they have a docker engine)
* It makes it perfect for CI/CD workflows and for scaling
    * It is easy to spin up a new computer and have an application running to accomodate for more people (This is future topic but this is how container orchestration works)
    * Developers can write code locally in their own preferred development environment and then share it using Docker container

## Pros
* Responsive deployement and scaling
    * Docker containers can run on most things (physical or virtual machine, data center, cloud providers, etc.)
    * You can scale up or tear down application as business dictates (based on demand)
* Run more workloads on the same hardware
    * Since containers is very lightweight unlike virtual machines, you can do other stuff while docker is running
# Docker Architecture
* Works in Client Server architecture
* ![Docker Architecture](https://docs.docker.com/engine/images/architecture.svg)
## Docker artifacts/Terminology
* Docker Images
    * They are standalone package that includes everything for the application to run such as the code itself, dependencies, configuration, runtime (.net), third party libraries, environment variables etc.
    * They are immutable file and represents an application and its virtual environment at a specific point in time
        * Immutable meaning you cannot change it thats why we have to create a new image everytime we update the application
    * images are **LAYERED** - every image has some base image, adding new layers on top of it
* Docker Container
    * An image cannot run on its own. It needs a docker container to run the image
    * In other words, Containers are the runnable instance of a docker image
    * Think of a CD, it has all the information you need to start an application/install application/play music but it needs a disc drive to actually run it
* Docker Registry
    * It is a server-side or cloud application where you can store your images and make it easy to distribute to everyone else
    * Think of github but just for docker images
    * Ex: Dockerhub
* Docker ignore
    * It is like .gitignore
    * It will ignore certain files in your application to not put inside of image
* Docker Configuration
    * Just extra information to tell the docker container on how to run the image
    * We won't touch this and just use the default settings

## Docker instructions
* Don't confuse them with docker commands that is the CLI commands we put on the terminal
* These are instructions to tell docker how to make this image and what it needs
* From
    * Initialized our build stage and sets the base image
    * Essentially this is where we indicate what we need to be able to create/run our application
* Workdir
    * Sets the working directory
    * Just creates a folder and that is where we will copy and paste our files into that folder
* Copy
    * Copy and paste files for image
    * So it essentially moves the files from your local directory and paste into the image
* Run
    * It will execute the CLI commands you specify in the run command
    * Essentially, if you need to run something in the terminal (like dotnet build), you use the run instructions
    * `run, cmd, entrypoint`
        * `entrypoint` defaults to /bin/sh -c , default parameters cannot be overridden when docker cli containers run with cli parameters.
        * `cmd` is passed to the entrypoint, sets default parameters that can be overridden from the docker cli when a container is running
            * cmd is more useful for debugging since you can replace with with the final arg to container run
        * `run` mainly used to build images and install apps an packages. Builds a new layer over an exisiting image by committing the results.
    * docker image must have an ENTRYPOINT or CMD Declaration for a container to start 
## [Docker CLI Commands](https://docs.docker.com/engine/reference/commandline/cli/)
* `docker run <image-name>`
    * this starts a new container from the given image (downloading that image if necessary)
    * "-it" options after "run" we need when the CMD is some shell like bash,
        to attach the container's input to the current terminal's input.
* `docker pull <image-name>`
    * just downloads the image (or updates, if there's some new version)
* `docker build <dir>`
    * `<dir>` should be the directory with the Dockerfile.
    * usually we `cd` to that directory beforehand anyway, so `<dir>` is "."
    * use `"-t <image+tag>"` to tag the image like "ConsoleApp:1.0".
* `docker container ls`
    * show all running containers
* `docker container ls -a`
    *show all running/stopped containers
* `docker container prune`
    * remove all stopped containers
* `docker run --rm <image-name>`
    * run container, and clean it up as soon as it has stopped
* `docker rm <container-id>`
    * clean up stopped container
* `docker rm -f <container-id>`
    * stop and clean up container
* `docker images ls`
    * show all images downloaded
* `docker logs <container-id>`
    * look at console output of a container
* `docker run -d <image-name>`
    * detach container from current terminal (run in background)
* `docker run -it <image-name>`
    * attach both input and output of current terminal to container (for running shell like /bin/bash)
* `docker exec <container-id> <command>`
    * run an additional command inside running container to look around/debug

# DevOps
* It is a culture that you follow in which you continuously develop your application and continuously deploy it
* DevOps are integrated with Agile planning since they have similar ideologies
* There are three main teams that are a part of DevOps
    * Developer Team are responsible for planning, testing (with unit tests), and building the application
    * Operation Team are responsible for deploying, testing (by emulating real world experience), and maintaining the application
    * Business Team verifies that the correct product is created and delivered correctly
        * May or may not also set unrealistic expectations

## Continuous Integration (CI)
* The process of automating the build and testing of your code
* Usually triggered via a pull request/merge on your main branch of your remote repository
* Testing is done through unit tests and will only merge if all unit tests passes
## Continuous Delivery (CD)
* The extension of CI since CI does is checks if your main branch is working properly after a merge
    * Hence we usually denote them as CI/CD since both are usually combined together
* Essentially, it is the automated process of delivering the new changes in the main branch to the people
* However, there is a **release manager that will check on everything before deployment**

## Continous Delivery
* In its essence, it is the combination of both Continuous Integration and Continuous Delivery
* The main difference is there is essentially no human component involved in the entire process. Once you do a merge with the main, it will start deploying it after all the testing are done and passed
    * So no release manager and everything is managed/tested by computers

## YML
* Another mark up language that just tells the computer what to do so it can build, test, and deploy our application to setup a CI/CD pipeline
### Pipeline keywords
* Trigger
    * We set some sort of event that needs to happen to trigger/execute the entire process of CI/CD
* Job
    * This is the actual "work" the computer needs to do to start the entire process
    * You can have multiple jobs that is responsible to do something
    * Ex: Deploy the application job, Dockerize the app job, Code analysis job
* Steps
    * They are the tiny operations required for the computer to finish one job
    * This might be executing a bunch of CLI commands in sequence or installing certain SDKs to do the operation, etc.
* Approval
    * Some sort of a check after a job or multiple jobs to see that everything work as expected

# Introduction to Code Analysis
* A further way for a computer to analyze your code to ensure you are following good coding practices and also gives you a direction on certain things you might want to change
* Does not actually check if the functions are working on your app (that is what unit tests are for) and more about looking at your c# files and ensuring you follow good coding practicies
* It will perform a **static code anaylsis**
    * Just the fancy way of saying, it will check your code without running it and just scanning your c# files and seeing any patterns that might be bad coding practices
    * If done by a human, that is what we call a code review (just for your fun information)

# Specific for Azure DevOps Cloud Services
* A couple features in Azure DevOps that might be useful for us when utilizing that service to create our pipeline
* However, note that we used github actions to do our pipeline and not Azure DevOps
* Packages
    * They are just pre-made files made by someone that another person can come and download and start using it as well
    * Can also be done with pipelines in which we just pre-made pipelines and just change some configuration to tailor it to us
* Artifacts
    * Essentially, it is a market place for many packages
    * Ex: NuGet

    ## Adding code analysis by sonar cloud to your pipeline

1. Log in to your sonar cloud account using **github** (because it's free)
2. Create a project:
   1. Choose the organization
   2. Select the repo
   3. A project should be set up for you
   - Remember the project key and name that you set your project to!
3. Install sonar cloud to your azure devops account
   - Go to this [link](https://marketplace.visualstudio.com/items?itemName=SonarSource.sonarcloud)
4. Create a service connection to sonar cloud in azure devops:
   1. Navigate to project settings on the left menu
   2. Under the pipelines section, click on service connections
   3. Select add new service connection
   4. Choose sonar cloud
   5. Input your personal access token to sonar cloud
   - To generate a personal access token to sonar cloud:
     1. Log in to sonar cloud
     2. Click on your profile icon on the upper right corner
     3. Select my acccount
     4. On the account page, select security
     5. Select generate new token
     6. Copy the generated token
   6. Verify the token, name your service connection, and save it
5. Back to your pipeline editor, add a prepare analysis config task before any of the other tasks in your build pipeline
   - When setting up this task:
     1. Select the service connection to your sonar cloud account
     2. Input in your project key and name
        - To find your project key:
          - Go under the administration menu in your project and select the update key
          - If you're unable to access this menu and you're part of an org try using the naming convention OrgName_ProjectName
6. Add a run code analysis task after the test step of the build pipeline
7. Add a publish code analysis task after the run code analysis task
8. Save your pipeline and watch sonar cloud judge your code!
   Note: If you are self-hosting the build agents, make sure you have at least the minimum SonarQube-supported version of Java installed.
   (Sonarqube)[https://www.sonarqube.org/downloads/]

## Publishing code coverage results

**Note:** make sure you have sonar cloud analysis set up in your pipeline to see the results!

1. On your dotnet test task add `arguments: --configuration $(buildConfiguration) --collect "Code Coverage"` under the inputs
2. Set the publish code coverage results after the dotnet test task
3. Search for the publish code coverage results task on the assitant to the right of the pipeline editor
4. Select cobutura as the code coverage tool
5. Set the summary file location to be: `**/coburtura/coverage.xml`
6. Save your piepline and wait to see how much of your code is tested!