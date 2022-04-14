# .NET Architecture Components
* There are many frameworks included in .NET 6.0
    * A framework are just predefined classes and libraries to help us start an application
    * One framework we will be using in the future is ASP.NET (Used to create Web Apis)
## SDK vs Runtime
### SDK
* Software Development Kit
* Includes everything we need to build and run a .NET application
    * Such as Command-Line interface commands to create our projects as well as a bunch of other functionalities
* SDK includes Runtime as well why? Well when you develop an application you of course need to run it to be able to test if everything is working properly
### Runtime
* It includes all the resources we need to run existing .NET application
* A lot less storage required to download and install
* Mostly useful for end-users (people who will be using our application)

# Common Language Infrastructure (CLI)
* This is the  infrastructure of .NET on how it is able to write your application in numerous programming language beyond C# and for your application to be run on any operating system
## General structure of the .Net
* .Net
    * CLR
        * CLI
            * CLS
            * CTS
        * Garbage Collector
        * JIT Compiler
    * Libraries
## CLS
* Common Language Specification
* It has defined rules and restrictions that every langauge must follow for it to be able to run the .NET framework
* Essentially a standardization to make sure a language won't do anything that will make it incompatible with .NET framework
## CTS
* Common Type System
* Provides a library of the basic value data types
* It is a standardization of data types to ensure every language will follow the same datatype
    * Ex: int in C# is the same 32-bit memory as the int in Visual Basic
* Helps create **Language Interoperability**
    * Fancy way of saying .NET has the capability to develop application using two or more programming languages
    * You can create apps using Visual Basic, C#, J# (Java-like language that can run in .NET), etc.
        * NEVER SAY JAVA ITSELF J# IS NOT JAVA
## VES
* Run-time system of CLI that provides all the tools it needs to be able to execute your application
### CLR
* Common Language Runtime implements VES so anything in VES, CLR also has it plus more
* Essentially, it is .NET's version of VES
* Run-time environment that provides services that make the development process easier
* Some servies it includes:
    * Automatic memory management (older languages you ahve to manually release unused resources)
    * JIT compilation (Just-inTime compilation that involves compliation during execution for optimization)
        * It just means any new compile code gets executed immediately, it doesn't have to wait until your entire code has been compiled to run your app
    * Exception handling support
    * Security

# Application Architecture
* A way for us to group our code just like how we group our files by putting them in folders
## Separation of Concern
* The fancy way of saying it is a concept of organizing our code
* We want our code to follow a certain theme and all the code are grouped together to do a certain functionality
* We do this by leveraging classes and other grouping mechanisms to group code and logic together
* This is a first but **important** step to writing readable, extendable, and maintainable code
## Classes
* They are the building blocks of your code
* They are the blueprints to creating objects that you process in your program
## Namespace
* Logical grouping of classes that follow a certain theme of functionality
* To utilize the classes located in a different namespace, you must use the 'using' keyword
## Project
* They contain all the files that are compiled into an executable, library, website, etc.
* There are different types of projects that are responsible at creating one thing like how a console project is a great starting point of your application while class library projects are great at adding more customize functionalities you want in your application
* A way you know a folder is a project if you notice an important file usually dictated as **(folder name).csproj** they contain key information that will configures your project and also what your project will depend on
## Assembly
* They contain all the files that are actual executables
* These files will differ depending on what operating system you are using but as for windows, it will be .exe and .dll files
* If you open the auto-generated bin folders, you can file the assembly files located there
* **So main difference with projects are that projects are the .cs files and .csproj and other configurations while assembly is the actual files that gets run since that is what your operating system understands**
## Solution
* The final grouping mechanism in that it will group multiple projects as one application
* They are the final packaging of your application

# Non-access modifiers
## Abstract
* Enables you to create incomplete implementation of whatever you applied it to and it must be implemented in a derived class
* Implicitly used by interfaces
* Explicitly used by abstract classes

## Static
* Static classes cannot be instantiated or inherited, its members must also be static
* Static class members belongs to the class itself rather than to a specific object
    * Allows you to use those class members without instantiating an object from that class
    * If a static field changes, every object will reflect that change (think of it as a federal law that every state must follow)

## Readonly
* Readonly fields cannot change its value once it is set
* **They can be initialized at a later time** like in a constructor
* "Read only" meaning you can only read the value and not write it

## Override
* Override methods must do method overriding or the compiler will notify you that it isn't
* Essential for method overriding for polymorphism

## Virtual
* Allows the method for the base class to be overriden
* Essential for method overriding for polymorphism
* Virtual methods doesn't allow methods to be private (I'm sure you can figure out why that is the case *cough* private methods cannot be inherited *cough*)

# Quick More Datatypes
## Nullable
* Makes datatypes optional and it is denoted by using '?'
* Hence the name nullable, it makes whatever datatype have an option to also hold a null value
* Just useful for the compiler to help you out and telling you that something might give a null and you might have to take that into account
```
//This means x variable can hold either true, false, or null
bool? x
//This means y can hold numbers or a null
int? y
//This means i can hold characters or a null I'm sure you get what it means
string? i
```
## Struct
* Unlike classes, struct gets stored in the stack memory so they are more optimized and efficient
* But since they are stored in the stack memory, they are only used for encapsulating simple data and have little to no behavior (so generally have simple datatype for properties and very simple functions of methods)

## Conversion
### User-defined conversion
* Gives you the capabilities to convert other datatypes into a class either implicitly or explicitly
* You must use the **operator** keyword followed by either **implicit** or **explicit** keyword

### Boxing and Unboxing
* Boxing
    * It is when a value type gets casted into an object
    * Useful if you want a value type to have reference type like functionalities
    * It is implicit conversion
* Unboxing
    * When you extract the value from an object and convert it into a value type instead
    * It is explicit conversion
```
Console.WriteLine("==== Boxing and Unboxing ====");
            
            //Value type
            //You get the value directly
            int num = 123;

            //Boxing example
            //When a value type gets casted into an object
            //What happens is that the value is wrapped to give it a reference type behavior
            //No other syntax is needed
            //It is implicit conversion
            object obj = num;
            Console.WriteLine(obj);

            //Unboxing example
            //When you extract the value type from the object and just get the value directly instead
            //A syntax is needed (dataType)Object
            //It is explicit converion
            int num2 = (int)obj;
            Console.WriteLine(num2);
```


## References
- [C# Program Structure](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/)
- [Namespace](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/members)
- [Types](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/members)
- [Members of Types](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/members)