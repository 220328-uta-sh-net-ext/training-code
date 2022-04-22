## SDLC
- Phases of SDLC -> Requirement Analysis, Design, Development, Testing, Deployment, Maintainence 
- Waterfall, Bing Bang Model, RAD, Spiral Model, Iterative, Agile (Scrum), TDD

## Testing 
- Black-box, white-box testing
- Performance Testing, Load Testing, Smoke testing, Integration Testing, Penetration Testing, Unit Testing.
- **Unit Testing** is important component of developer testing which is heavily used in TDD.
  - In.Net/.Net Core supports multiple frameworks for testing 
  - MSTest, NUnit, xUnit.
- Test-driven development (TDD) is a software development process relying on software requirements being converted to test cases before software is fully developed, and tracking all software development by repeatedly testing the software against all test cases. This is as opposed to software being developed first and test cases created later.
- Mantra: Red, Green, Refactor
- Structure: Arrange, Act, Assert
- Process:
    - Start with degenerate test cases first
    - As the tests get more specific the code becomes more generic

## The flow of TDD
1. Create a test case - What you expect the feature is suppose to do
2. Running the test case will fail the first time - obviously since you haven't created the actual implementation details to make it pass
3. Write code so the new test case will pass
4. Make sure old test cases won't fail because of the new feature (probably the biggest thing as to why we do unit testing so anything new added will also test our old functionalities to make sure everything is working as intended)
5. Clean up the code and have proper documentation for other developers

## Unit testing
* Like the word "Unit", you will test a small portion of your code to ensure it is working
* Helpful to check that particular section of your code is working

## Arrange, Act, and Assert (The 3 good ole As)
* Arrange
    * This is where you initiliaze objects or some values you will need for the test
* Act
    * Invokes the method/function under the test with the arranged objects/values
* Assert
    * Verifies that the action of the method under the tests behaves as expected

## Code Coverage
* It is the percentage given to you on how much lines of your code is actually covered by unit testing
* Ex: Lets say you have a total of 200 lines of code and your unit testins only covers 70 lines of code. That means you have 35% code coverage (Fancy math - 70/200*100 = 35%)
### Generally Supported Code Coverage Formats
- Supported code coverage report format types include all test coverage reports we've seen in the wild so far, including:
    - Most of .xml format types (Cobertura XML, Jacoco XML, etc.)
    - Most of .json format types (Erlang JSON, Elm JSON, etc.)
    - Most of .txt format types (Lcov TXT, Gcov TXT, Golang Txt)

# [Logging](https://en.wikipedia.org/wiki/Logging_(software))
* The systematically way to record a series of events depending on what exactly you are trying to capture
* Ex: Logging user events - you will record every single page they went through, every single customer they have added, every single orders they have made
* The main purpose is for debugging potential bugs since the main problem with debugging is trying to re-create that bug again just to see what exactly did the user did to even get that bug
* Asking for feedback from a user as to what they did is incredibly unreliable so we have a robot to essentially record everything they do
* OF COURSE, that is only limited to what are they doing in the application and highly unethical (maybe illegal I'm not a lawyer) to record everything they do beyond that
## Serilog
* A library we will utilize to add logging functionality with our application
* There are more libraries out there that can accomplish the same task such as NLog but we will stick with Serilog
### [Steps to start Serilog](https://github.com/serilog/serilog/wiki/Getting-Started)
1. Make sure you add the package from Nuget
```
dotnet add package Serilog
dotnet add package Serilog.Sinks.File
```
2. create a Logger using LoggerConfiguration class provided by Serilog
3. Start logging!

# [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries)
* Language-Integrated Query
* It is a query language that is very similar to our SQL but we can use it in C# or VB
* So like any query langauge, it is incredibly useful for filtering/acquiring/aggregating data
* Very useful documentation click [here](https://www.tutorialsteacher.com/linq)
## Method syntax
* It is more like C# in that you use methods to perform the queries
* For simeple filtering, I would use method syntaxes
## Query syntax
* It is more like SQL in that you create a statement-like operation using keywords
* I would use joins with query syntax since it is easier to understand

# [SOLID Principles](https://medium.com/backticks-tildes/the-s-o-l-i-d-principles-in-pictures-b34ce2f1e898)
* They are five design principles intended to make software designs more understandable, flexible, and maintainable
    * Kinda like the OOP pillars, but it is just rules to follow to write better code
## Single Responsible Principle
* A class should have one and only one reason to change
* If one class has more responsibility, just segregate them into many classes 
* Ex: Software Engineer class should just manage anything related to creating a program and shouldn't also have the responsiblity to manage financial forms. Instead, segragate the two class and create a Accountant class that will hold that responsiblity
## Open/Closed Principle
* A class should be open for extensions but closed for modification
* It just means you can add new functionality without changing existing code
* A great way to do this is using interfaces
    * Or using Imenu interface and all our code we wrote in program.cs works just fine with any of our new C# classes
## Liskov Substitution Principle
* Derived class should be substitutable for their base class implementation
* It just means derived classes should not behave in such a way that it will not cause problems when used instead of a base class
* One way to avoid breaking is using the base class implementation as well as your derived class implementation
## Interface Segregation Principle
* You should not be forced to implement methods that you don't need in an interface
* Just segregate the interface into multiple interfaces
## Dependency Inversion Principle
* High and low level modules should depend on abstractions but not on each other
* If a class uses the design and implementation of another class, it raises the risk that change one class could break the other class
* To fix, we must both let them depend on abstractions 

# [Design Patterns](https://sourcemaking.com/design_patterns)
* They are reusable solution that will solve the problems that occurs pretty frequently while coding
* Essentially, some people saw that problem keeps happening across multiple coders and decided to standardize a solution every time you come across to that problem to make your life easier
* They are some of the best practice a programmer can do to solve common problems while designing your application
- **History and evolution of design Patterns**
  - The four authors of the book famously know as Gang of four are the ones who brought the concepts of design patterns in their book “Elements of reusable Object-Oriented software” . 
  - Gang of Four has divided the book into two parts with first part explaining about the pros and cons of object oriented programming and the second part describes the evolution of 23 classic software design patterns.
- **Types of Design Patterns**
    - Gang of Four have categorised the design patterns in to 3 types based on different problems encountered in the real world applications. They are **Creational, Structural** and **Behavioural**. 
      - **Creational design patterns**: These patterns deal with object creation and initialization. Creational pattern gives the program more flexibility in deciding which objects need to be created for a given case.
        - Examples of Creational design patterns category : Singleton , Factory and Abstract Factory etc.
      - **Structural design patterns** : This pattern deals with class and object composition. In simple words, This pattern focuses on decoupling interface, implementation of classes and its objects. 
        - Examples of Structural design patterns category : Adapter,  Facade and Bridge etc.
      - **Behavioural design patterns** : These patterns deal with communication between Classes and objects.
        - Examples of Behavioural design patterns : Chain of Responsibility, Command and Interpreter etc.

## Singleton Pattern
- Singleton Pattern belongs to Creational type pattern which means creational pattern explain us the creation of objects in a manner suitable to a given situation.
- This pattern revolves around creating one concurrent object of a class (So only one object exists while the application runs)
- This singleton class provides a way to let other classes have direct access to the single object
- Just think of a universal object that gives access to everyone
- Singleton design pattern is used when we need to ensure that only one object of a particular class is Instantiated. 
- That single instance created is responsible to coordinate actions across the application.
- Why Singleton: Concurrent access to the resource is well managed by singleton design pattern.
- As part of the Implementation guidelines we need to ensure that only one instance of the class exists by declaring all constructors of the class to be private.  Also, to control the singleton access we need to provide a static property that returns a single instance of the object.
### Real world examples of Singleton : 
- Exception/Information logging
- Connection pool management 
- File management
- Device management such as printer spooling
- Application Configuration management
- Cache management
- And Session based shopping cart are some of the real world usage of singleton design pattern
### Static classes vs Singleton
- Static is a keyword and Singleton is a design pattern
- Static classes can contain only static members
- Singleton is an object creational pattern with one instance of the class
- Singleton can implement interfaces, inherit from other classes and it aligns with the OOPS concepts
- Singleton object can be passed as a reference
- Singleton supports object disposal
- Singleton object is stored on heap
- Singleton objects can be cloned
### Advantage
* Provides a global point of access from multiple classes
* It is easy to maintain since there is only one instance of that class
### Disadvantage 
* Very difficult to unit testing since it has global access
* Definitely do not put any security sensitive information in a singleton
## References
- [TDD](https://en.wikipedia.org/wiki/Test-driven_development)
- [Unit Testing](https://docs.microsoft.com/en-us/visualstudio/test/unit-test-basics?view=vs-2022)
- [xUnit](https://xunit.net/docs/getting-started/netcore/cmdline)
- [Code Coverage basics](https://www.atlassian.com/continuous-delivery/software-testing/code-coverage)
- [Code coverage](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=windows)
- [Unit Testing Best practices](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)
- [All about LINQ](https://www.tutorialsteacher.com/linq/why-linq) 
- [Design Patterns](https://en.wikipedia.org/wiki/Design_Patterns)
- [Design Patterns video series](https://www.youtube.com/playlist?list=PL6n9fhu94yhUbctIoxoVTrklN3LMwTCmd)