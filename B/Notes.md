# Welcome to .NET

## What is .NET?
- .NET is an open source developer platform created by Microsoft. It's for building many different types of apps, such as web apps, desktop apps, games, api, smart phones apps....
- In short, .NET Platform is a collection of **languages**, **libraries**, and **frameworks** to make various applications, developed under one common standard.
- With .Net platform you can build your app, test app, deploy the app and maintain. This is why .Net caters mostly all phases of SDLC.

## Supported Programming Languages
- Dozens of programming languages are supported by .Net provided they are compatible with the platform, [listed.](https://en.wikipedia.org/wiki/List_of_CLI_languages)
- 3 different languages which are by default supported by .Net are
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/): Features are: 
    - Object oriented, type safe language and is case sensitive
        - object oriented means, that everything is an object. These objects are further organized with classes
        - Type-safe means that once you declare a type of a variable, you can't really change it. 
    - Component-oriented 
    - Lambda Expression, LINQ (Language Integrated Query), asynchronous operations ...
- Visual Basic : Supports UI and component oriented language.
- F#: F# is a functional programming language supported by .NET
- All .Net compliant languages ahve to follow a Standard. These standard are defined by CLS (Common Language Specification).
  - CLS gives a set of rules and regulation a .Net compliant language should follow. Ex all .Net compliant languages should be OOP languages, Array index should start from 0 etc...

## Technologies we'll be using during this training
- .NET 6 and C#
- SQL (Sql Server)
- ASP.NET Core for creating web applications
- Azure Cloud Service for hosting
- Javascript, Typescript, HTML, CSS, jQuery and Angular for frontend

## [History of .Net](https://docs.microsoft.com/en-us/dotnet/core/porting/versioning-sdk-msbuild-vs)
- Microsoft introduced .Net 1.0 (deprecated) in 2002. It was known as .Net Framework
  
## .NET Implementation
4 main implementation of .NET 
- **.NET Framework**: first implementation of .NET, only works on windows, and it is shipped with every windows.
- **.NET / .NET Core**: .NET Core is the cross-platform implemtation of .NET, and is a successor of .NET Framework. 
    - This is a primary implementation of .NET and is the focus of ongoing development effort. This what we'll be using.
    -.NET 5
- **Mono**
    - .NET runtime that power Xamarin application. 
    - useful when small footprint is needed
    - also powers games built with Unity
- **Universal Windows Platform (UWP)**
    - Used for building modern, touch-enabled Windows applications and software for the Internet of Things (IoT). 
    - It's designed to unify the different types of devices that you may want to target, including PCs, tablets, phones, and even the Xbox.

## Components of .NET Implementation
    - One or more runtime: Example, .NET Framework CLR, .NET 5 CLR
        - CLR stands for *Common Language Runtime* and it's a runtime environment provided by .NET
    - A class library, for example, .NET Framework Base Class Library, or .NET 5 Base Class Library.
    - Optionally, we have one or more application frameworks, such as ASP.NET Core for web application development, Windows Forms, etc.
    - Optionally, development tools. Some are shared among multiple implementations.

#### CLR? SDK?
- CLR Stands for Common Language Runtime, and it's runtime environment. It is also know as main execution Engine and is used to run any .Net application.
- SDK stands for Software Development Kit.
- CLR comes included in SDK

## .NET Standard
- .NET Standard is a base set of API's that are common to all .NET implementation.

### Additional Frameworks
These are frameworks that extend .NET platform to provide additional functionalities.
- **ASP.NET Core**: Open source framework for building web apps and web services
    - it's a redesign on ASP.NET 4.x with architectural changes that result in a lener, more modular framework
- **Unity**: Real-time 3D development platform
- **UWP (Universal Windows Platform)**: for developing various windows applications
- **Xamarin**: for mobile development
- **ML.NET**: machine learning
- and more..

### Other Niceties..
- **Nuget**: a package manager for .NET

.NET 5
ASP.NET: ASP.NET Core to match with .NET Core 


## [C#](https://docs.microsoft.com/en-gb/users/dotnet/collections/yz26f8y64n7k07?WT.mc_id=dotnet-35129-website) 
### Anatomy of C# program
- namespace -> Types -> Type members
    - Namespace
        - Types
                - Members (Methods, variables, properties)
- Types (Classes, Enums, Structs, Interface, Delegates)
    -   All types in  C# are inherited directly or indirectly Sytem.Object
        - **[Value Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)** - which has the direct value, stored in memory Stack, fast to access.
            Structs, Enums. Predefined (int, long, short, byte, DateTime, char)
        - **[Reference Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types)** - it stores the reference to that value, value is stored in heap, expensive retrieval process.
            Classes, interface, Delegates. Predefined -> string, arrays, collections etc.
- **[Type Conversion](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/conversions)** : conversion of 1 type into another 
    - Implicit type conversion : no need to type cast. Ex byte value can be placed in int. No data loss.
    - Explicit type conversion : type cast it using `<datatype>.Parse(value)`, `Convert.<datatype>(value)`. You can have a data loss if its not fitting in the type.
        - The `Parse` method returns the converted number; the `TryParse` method returns a boolean value that indicates whether the conversion succeeded, and returns the converted number in an `out` parameter.
- **Boxing**- refers to conversion Value type to reference types.
- **Unboxing**- refers to conversion of reference types to value types.

- **[Expressions](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/)**
  - An expression is a sequence of operators and operands.
    - Ex int c = a + b;
    ```
    [(6/2)+2*3-1]
    - 3 + 2 * 3 - 1
    - 3 + 6 - 1
    - 9 - 1
    - 8
    ```
 
- **[Recursion](https://www.codeproject.com/Articles/142292/Recursive-methods-in-Csharp)** - It is a process of repetitiion own its own. A recursive function is a function that calls itself.
    - A function that calls another function is normal but when a function calls itself then that is a recursive function.

### Additional Resources
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/core/introduction)
- [.NET Glossary](https://docs.microsoft.com/en-us/dotnet/standard/glossary)
- [Introducing .NET 5](https://devblogs.microsoft.com/dotnet/introducing-net-5/)
- [What is .NET?](https://www.codecademy.com/articles/what-is-net)
- [.Net CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/)