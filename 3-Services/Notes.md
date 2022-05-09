# What we have been doing so far
* A monolithic architecture
    * Meaning the frontend (anything visual to the user and the backend (the actual logic that does the function) are tightly coupled)
        * Tightly coupled just means if you update one thing, it breaks another thing since they are highly dependent on one another
        * So in our context, if we update something in BL, DL, and Model (the backend), there is a good chance it will break something in our UI (the frontend)
## Pros
* Prototyping an application and getting something working right away
* Simple applications or working on your own 
* Its not only simpler but also cheaper to start with
* Less learning curve requireds
* No latency concern as applicatio layers can talk to each fast

## Cons
* Horrible for scaling the application
* Ineffient utilization of resources (Servers etc...)
* Impossible to develop backend and frontend separately
* Tightly coupled apps become difficult to enhance (change in one layer of the code can disrupt the whole application)
* Hard to maintain and update

# [Service Oriented Architecture (SOA) Introduction](https://www.guru99.com/soa-principles.html)
* A style of software design where services are provided to the other components by application components, through a communication protocol over a network
* Intuitive definition: We are decoupling backend and frontend and a communication protocol (can be HTTP, HTTPS, SMTP, etc.) to communicate between the two entities via the internet
## What are Services?
* They are responsible for sending and receiving data
* They provide some sort of functionality that clients might want 
    * like a service in the real world (i.e. you go to a barber place to get a haircut service)
* They are independent of platforms and programming language
    * Meaning you can create one using any programming language and once deployed, any programming language can use it
    * Ex: Creating a service with C# and having a java application use it
## SOA principles
* Many rules that you must follow to achieve SOA
### Standard Service Contract
* Must have a descritpion on what the service is about
* This makes it easier for a client to understand what the service does
### Loose Coupling
* Less dependency on each other (frontend and backend)
* So, if the service functionality changes at any point in time, it should (must) not break the client application or stop it from working
### Service Abstraction
* Services hides the logic
* You only know what the service does and how to use it but never on how they implemented the application
### Service Reusability
* Logic was made in a way that it can be re-used as many times as the client wants
* Other clients can also use your service at the same time without any issues
### Service Statelessness
* Service should not withhold information from one state to the other
* Ex: Any data used to do a functionality should be gone after doing the functionality
## Pros
* Frontend and backend can be developed separately without any problem
* A lot easier to scale
* Easy to maintain
* Confirms continous delivery
* Platform independent

## Cons
* High investment cost
    * You need two separate teams to do either frontend and backend
* As with adding more teams, communication can become an issue
    * Since frontend and backend are being developed separately they might not have the same idea on doing a functionality (which you might experience once you start working in teams!)
* Increase complexity of the application which leads to a steep learning curve
* Increase in latency


# Types of implementations of SOA
- Sometime they are also referred as web services
1. SOAP service - which old way of creating a webservice
    - Simple Object Access Protocol 
    - They are compatible with different protocols like HTTp, TCP, SMTP etc....
    - Messaging Structure is XML only which is why they were heavy and slow in performance
    - A SOAP service is exposed and consumed via a doc known as WSDL (Web Service Description language)
    - SOAP used more bandwidth as the messages were in xml
2. RESTful Service - which is the mordern way of creating a web service
    - stands for Representational State transfer
    - Its uses REST Architecture
    - Compatible with only http(s) protocol
    - Can use any messaging format like json, xml, custom
    - Consumes less bandwidth comparitively to the SOAP
    - Has more reachabilty to the clients (because http is the most used protocol, and also json light weight)

- [SOAP vs REST](https://www.guru99.com/comparison-between-web-services.html)

# [REST](https://restfulapi.net/) 
* Stands for Representational State Transfer
* It is an **architecture style** that uses SOA as its guide
* It tells you how you should transfer information and how you should communicate with the client
## What is an API?
* Application Programming Interface
* At its essence, it allows you to communicate and transfer information
* A way how applications talk to each other
## What is a resource?
* Anything that is being transferred, stored, processed, given, etc. (mostly objects for us)* Eg: a text, any info, image, video, audio etc....
## Guiding Principles of Rest
* Uniform Interface
    * Your service would have an interface defined by four constraints:
        * Identification of resources
            * Able to identify the resource you are trying to access
            * Ex: An endpoint that ends with /Pokemon/AllPokemon will give all the pokemon resource in the database
        * Manipulation of resources through representation
            * Using appropriate action verb to access/manipulate your resource
            * Ex: GET method to get all pokemons or POST method to add a pokemon
        * Self-description message
            * Any other information needed to process the data
            * Ex: the format the data will come in (JSON, XML, etc.)
        * Hypermedia as the engine of application state (HATEOAS)
            * Not implemented as much nowadays
            * It gives other potential actions the user can take after doing one action
            * Ex: GetAllPokemon would then give the user potential actions to take such as AddPokemon
* Client-Server
    * Client app will evolve separately from the server  app without any dependencies on each other
    * Same concept of when we change our DL from the file system to database without breaking the other projects
    * Decoupling the services from each other (Matters the most when we do MSA (microservices design pattern))
    * Same concept of one service being change shouldn't break a different service
* Layered System
    * Constraining the interactions of your components to the ones in the next Layer
    * The service should only have access to components it is dependent on
    * Ex: The request sent from the client can pass through many intermeditaries like router, firewall etc... wach layer doesn't know anything about any layer other than immediate layer.
* Stateless
    * Server isn't responsible for storing client state
    * It will just treat every http request as new or completely different even if it came from the same client or even doing the same http request (refreshing the page)
    * The client is the only one responsible for storing its own state (like storing cookies or tokens)
* Cacheable
    * Resource from the server can be cached if applicable
    * Meaning the client can store information that was sent by the server
    * Ex: once you get a list of pokemn, refreshing the page you instantly get that list of pokemon since it was stored already
* Code on Demand (optional)
    * Allows client functionality to be extended by downloading and executing code in a form of applets.
    * Outdated at this point (think of how in the past to play a game, the game has a loading process well that loading process is your computer downloading the scripts to run the game)
    
# [HTTP/HTTPS](https://www.tutorialspoint.com/http/index.htm)
* Hyper Text Transfer Protocol (Secured)
* The protocol that both computers have to follow in order to understand/communicate with each other and work together to display a nice looking website in your browser, register an account, login, etc.

## HTTP Life Cycle
* An overview of what happens if you put in a url in your browser and out comes a website
1. Client (your browser) will send a request (the url you sent)
2. The server will receive that request and will do some processes
3. The server will send an appropriate response (html, css, js, json, etc.)
4. The client will receive the response and the browser will process that response

## HTTP Request and Response
- Request 
    * It is essentially what the client sents 
    * It will tell what HTTP verb the request will be all about (either GET, POST, PUT, etc.)
    * It will tell what kind of actual data the client is trying to sent (in a JSON format)
    * It has a bunch of other useful metadata things you don't need to know like ip addresses, urls, etc. things that might be useful for debugging purposes
    - Request Header
        - Method: Http Method (GET, POST, PUT, DELETE)
        - PATH: Url
        - Version of the Protocol
        - Host: Domain Server
        - Headers- optionl to convey any additional info        
            - Accept: content type which can be accepted
    - Request Body
        - If you want to send any data as a part o the request you put in here, optional
- Response
    * It is essentailly what the server sends back to the client
    * It will give a **status code** if it was successful or not
    * More metadata stuff for debugging purposes
    * What kind of data the server is trying to sent to the client (in a JSON format)
    - Response Header
        - Version of Protocol
        - Status code : 100s, 200s, 300s, 400s, 500s
        - Status Message : standard term/description for the status code
        - Header - addtional information about the response
    - Response body
        - if you receive some  data it will here, optional

## Domain Name System (DNS)
* It is essentially a directory of names and ip address
* It translates a pretty looking name of a website (www.google.com) into some numerical ip address ranging from (0.0.0.0 - 255.255.255.255) for locating the right server and to process the http request
* Main reason is the same reason why you save people's phone number in contact in a form of a name instead of just their phone number
    * It is easier to remember!

## HTTP Verbs/Methods
* Describes what action the client wants the server to perform on a given resource  
    * What is a resource? Anything the server is providing counts as a resource
* Common Verb
    * Get - Used to retrieve resource from the server
    * Post - Used to submit resource to the server
    * Put - Used to update/replace resource on the server
    * Delete - used to remove a resource from the server

## HTTP status code
* Gives the result of the HTTP request
    * 1XX - informational
    * 2XX - Success
    * 3XX - Redirection
    * 4XX - Client error
    * 5XX - Server error

# [ASP.NET](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio)
* Another framework included in our .NET 6 that specializes in creating web application in either C# or VB
* For us, we will just use it to create a restful web api instead of including the frontend tech just yet

## Controller
* Their main responsiblity is to handle HTTP requests and formulate an appropriate HTTP response based on what functionality it is trying to achieve
* This is why the first thing we do to define an action (basically a method inside of controller) is to tell it what HTTP verb it should handle
    * Ex: [HttpGet] - no surprises handles http get requests
* You also specify the actual route/endpoints the client needs to use for specific functionalities inside of your controller
    * Ex: [Route(api/[controller])] - the endpoint has to be (website name).com/api/(The controller name)
* It will call on the appropriate business logic to process what the clients wants to do
    * You essentially replaced the console project to instead just have the web api project as the starting point

## Model Binding
* It is a way to bind data (JSON objects) coming from HTTP request to be automatically mapped into a C# model
* Whenever an Action method expects a parameter value, model binder comes into the picture
* Model Binder looks for those values in different ways:
    * QueryString -> Primitive types
    * Request Body -> Complex Types
    
* Remember how HTTP transfers information via JSON files? Well ASP.NET can automatically map that JSON object into a C# object
    * So instead of manually mapping it like our DL, it does it for us
    * Just need to know the fancy name that does that operation which is model binding
* Ex: controller action([FromBody] someModel p_model)
    * Mapping whatever JSON file you got into a "someModel" object that C# understands
* Model binding can also do it from C# object into JSON object
    * When we return a C# object in an action, it automatically creates a JSON object that gets put into an HTTP response

## Routing
* Allows ASP.NET to know where to take the user's http request
    * In our case, which controller and which action inside of the controller should the http request go to
* It uses **routing middleware** to be able to find the appropriate controller and then the appropriate action within the controller to handle the request
    * It is the middleman between the asp.net app and the client
    * It also handled http responses and routes that information back to the client

## [Filters](https://code-maze.com/action-filters-aspnetcore/)
* They are used to create your own custom logic (your own code) if a certain event has happened
    * Applies to most filters but not all
### Authorization
* Used to determine whether the user is authorized for the request
* This will run first
### Resource
* Used for logging, caching, and other resource related operations
* You can configure whether to run the resource filter first or after an action
* Ex: OnResourceExecuting filter will run your custom code first before doing any model binding operations
* For optimization purposes
* Runs after Authorization
### Action
* Will perform your custom code after or before a controller action
### Exception
* Will perform your custom code after or before an exception
### Result
* Will perform some code after or before the execution of giving a view or IActionResult

## Security of Web API
* [JWT](https://jwt.io/introduction): 
    * Secure way of transmitting information between 2 parties in a secure way using JSON object.
    * JWt Structure
        * Header
        * Payload
        * Signature
* [IDaaS](https://www.okta.com/identity-101/idaas/#:~:text=Identity%20as%20a%20Service%2C%20or,technology%20is%20easy%20to%20understand.)
* Identity as a Service, or IDaaS is cloud-based authentication built and operated by a third-party provider. 
* IDaaS companies supply cloud-based authentication or identity management to enterprises who subscribe. 
* It means some feature is being delivered or served to a company through a remote connection from a third-party provider, as opposed to a feature being managed on site and by in-house personnel alone. 
* Its like sign on with Google, facebook, linkedIn they all are Identity providers.
* The goal of an Identity Service is to ensure users are who they claim to be, and to give them the right kinds of access to software applications, files, or other resources at the right times.
* Vendors helping you to achieve it Eg [okta](https://www.okta.com/), [auth0](https://auth0.com/) etc...


## OpenAPI (Swagger)
* Just the fancy technical term for Swagger
* Swagger is a tool pre-built in our ASP.NET project with the sole purpose of checking if our rest api is definitely working
* As you have guess, we don't really have a console app so we can visually see that our app is working so they created swagger just for the purpose
* It will show you every action inside of a controller and also test them
    * It can check what http response body it gave
    * It can check what http request the client needs to give to make it work and so on
* Really useful debugging tool for our api

## Reporting on Delegates, anonymous methods, lambda expression and LINQ
- help links (feel free to do self research)   
    - [Delegates, anonymous methods and lamdba](https://www.tutorialsteacher.com/csharp/csharp-delegates): 
        - Group A - Blake, Daniel, Emeka, Jermaine, Jamaal
        - Group B - Brice, Edith, Marcos, Gabriel, Rahelly
    - [Linq](https://www.tutorialsteacher.com/linq)
        - Group C - Leo, Kevin, Randy, Vlad
        - Group D - Steve, Sean Osman, James, Harsh 

# Some good reads:
1. SOA:
    - https://www.ibm.com/cloud/learn/soa
    - https://martinfowler.com/bliki/ServiceOrientedAmbiguity.html
2. HTTP:
    - https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP
3. REST conceptual:
    - https://martinfowler.com/articles/richardsonMaturityModel.html
4. REST implementation in ASP.NET Core:
    - Basic for QC and Quiz: https://www.tutorialsteacher.com/webapi
    - https://docs.microsoft.com/en-us/aspnet/core/web-api
    - https://docs.microsoft.com/en-us/azure/architecture/best-practices/api-design
    - https://docs.microsoft.com/en-us/azure/architecture/best-practices/api-implementation
5. SOAP vs REST:
    - https://octoperf.com/blog/2018/03/26/soap-vs-rest/
6. Swagger implementation with ASP.NET Core:
    - https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle
7. Filters in Asp.Net:
    - https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/filters?view=aspnetcore-6.0
8. More on security:
    - [OWASP top 10](https://www.hacksplaining.com/owasp):The OWASP Top 10 is a standard awareness document for developers and web application security. It represents a broad consensus about the most critical security risks to web applications.
    - [Role based access to .Net 6 apps](https://jasonwatmore.com/post/2022/02/26/net-6-boilerplate-api-tutorial-with-email-sign-up-verification-authentication-forgot-password)
