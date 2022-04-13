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
- .NET 6 SDK (Runtime, toolkit to devlop apps, .Net CLI) and C#
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


# [Basics of C#](https://docs.microsoft.com/en-gb/users/dotnet/collections/yz26f8y64n7k07?WT.mc_id=dotnet-35129-website) 
- C# is Case-Sensitive, Object-Oriented, Component Oriented language
    - Object-oriented means everythign is based on objects and classes and the relationships between them
- C# has coding syntax resembling other programming languages like C, C++, Java. Not that they wanted to copy them but for ease of developers to adopt this programming language.
- It is a type safe language. Type Safety is because of component of .Net known as **CTS** (Common Type System).
    - Type-safe meaning once you set a datatype you can't change the datatype (unless you use certain techniques to do it)
## Anatomy of C# program
- namespace -> Types -> Type members
- Namespaces are used to organize C#'s many classes and to control scope of class and methods in large programming project
    - Namespace
        - Types
                - Members (Methods, variables, properties)
- Types (Classes, Enums, Structs, Interface, Delegates)
    -   All types in  C# are inherited directly or indirectly **System.Object**
        - **[Value Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)** 
            - which stores the direct value, 
            - stored in memory Stack,
            - Stack is always faster to retrieve data than heap
            - Every value type has a set of memory set aside for it to occupy (Ex: int can only store 32-bits while a double can store 64-bits) and stack memory is all about structure for efficiency and how data cannot be dynamically changing in size
            - Ex Predefined (int, long, short, byte, DateTime, char)
                - Structs - like a class but gets stored in the stack for memory retrieval efficiency
                - Enums - defines a set of named integral constants
        - **[Reference Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types)** 
            - They are datatypes that are stored in the heap and reference variables that are stored in the stack
            - Think of reference variables as having the address of a house since an address only holds the info on where the house is and not the actual house itself
            - When you declare a variable of a reference type and not have it point to anything in the beginning, it will have a null value
                - Null in the coding world means lack of value or there isn't any value at all
            - Reference variables are stored in the stack while the actual object itself is stored in the heap
            - retrieval a value from heap is an expensive process.
            - Why the heap? since memory in the heap can be dynamically changing
            - Ex Predefined -> string, arrays, collections etc, Classes, interface, Delegates.  
## Conversion
- C# is statically typed at compiled time. Meaning after a variable is declared, it cannot be declared again.
- However, it is possible to change the variable type
- **[Type Conversion](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/conversions)** : conversion of 1 type into another 
    - **Implicit type conversion** : 
        - Generally, it is when you can convert the type without any data loss
        - Mostly used with numerical datatypes
        - No special syntax needed to write and compiler will do it for you
        - no need to type cast manually/explicitly. 
        - Ex byte value can be placed in int; converting an int into a double

    - **Explicit type conversion** : 
        - If there is a risk of losing information, you must perform a **Cast**
        - Special syntax is needed to write to tell the compiler to do it anyway
        - Casting is denoted with (datatype)
        - type cast it using `<datatype>.Parse(value)`, `Convert.<datatype>(value)`. You can have a data loss if its not fitting in the type.
        - The `Parse` method returns the converted number; the `TryParse` method returns a boolean value that indicates whether the conversion succeeded, and returns the converted number in an `out` parameter.
- **Boxing**- refers to conversion Value type to reference types.
- **Unboxing**- refers to conversion of reference types to value types.

 ### [Expressions](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/)
- An expression is a sequence of operators and operands.
    - Ex int c = a + b;
    ```
    [(6/2)+2*3-1]
    - 3 + 2 * 3 - 1
    - 3 + 6 - 1
    - 9 - 1
    - 8
    ```
## What is Object-Oriented programming?
- It is a methodology we use to design our programs just using classes and objects
- It makes it a lot easier to develop and maintain your project as it gets bigger

### Classes
- They are templates that are used to create objects and define the object's functions and current state (essentially what information they currently store)

### Objects
- It is any entity that has a state and behavior
- They are made from classes and will copy whatever state and behavior the class has defined

### Overall
- Classes are blueprints and Objects is the actual object from the blueprint
- Ex: A blueprint of a car, tells you how to make a car but it isn't the car itself (The Class) The multiple cars you make from same blueprint (The Objects of that Class)
### Methods
- A method is a member that implements the behaviour or action or computation that can be performed by an object or class. 
    - static methods - they accessed through class 
    - instance methods - they are accessed through instance of the class

### Arrays
- Used to store a datatype and have fixed sizes
- Zero-based index
    - 0 is the starting position of the array
- Other arrays you can make:
    - Multidimensional arrays - int[,] ex = new int[4,2]; would create [ [0, 0], [0, 0], [0, 0], [0, 0] ]
    - Jagged arrays - arrays inside of an array are different sizes [ [0, 0, 0], [0, 0], [0, 0, 0], [0, 0 , 0, 0] ]

### [Collections](https://docs.microsoft.com/en-us/dotnet/standard/collections/)
- Similar data can often be handled more efficiently when stored and manipulated as a collection. 
- You can use arrays, non-generic or generics.
- Arrays have fixed size and every element must have a value if no value is provided it contains the default.
- Arrays cannot be grown or shrinked. This where collection solves the problem.
- C# offers 2 categories of Collections:
    - non-generics
    - generics
- **Non-generic** collections store items as Object, require casting. Performance concerns were arised due to this casting and also Garbage Collection.
- **Generic collections** are type-safe at compile time. Because of this, generic collections typically offer better performance. 
    - Generic collections accept a type parameter when they are constructed and do not require that you cast to and from.
    - The "T" you see in documentation is where you put what data type that collection will hold
- All collections provide methods for adding, removing, or finding items in the collection.
- All collections can be **enumerated** by virtue of **Enumerator**.
- An enumerator can be thought of as a movable pointer to any element in the collection.
- Types of Generic Collections:
    - Stack<T>
        - LIFO - It is a Last-in, First-out list
        - Major Operations 
            - Push - Add element into stack
            - Pop - Remove an element from TOP
            - Peek - Retrieve the TOP element 
    - Queue<T>
        - FIFO - A first-in, first-out list
        - Major Operations
            - Enqueue - Add element into Queue
            - Dequeue - Remove element from Queue
            - Peek - Retrieve the TOP element 
    - List<T> 
        - Like any array which can grow and shrink dynamically.
        - Items in the list can be accessed by index.
        - It can accept null as a valid value for reference types and it also allows duplicate elements.
        - List<T> class is not sorted by default and elements are accessed by zero-based index.
        - Properties
            - Capacity - Gets or sets the total number of elements the internal data structure can hold without resizing.
            - Count - Gets the number of elements contained in the List<T>
        - Methods:
            - Add(T) - Adds an object to the end of the List<T>
            - Clear() - Removes all elements from the List<T>
            - Insert(index, T) - Inserts an element into the List<T> at the specified index
            - Remove(T) -	Removes the first occurrence of a specific object from the List<T>
            - RemoveAt(index) - Removes the element at the specified index of the List<T>
            - Reverse() -	Reverses the order of the elements in the List<T> or a portion of it
    - HashSet<T>
        - It is an unordered collection of the unique elements. 
        - It prevent duplicates from being inserted in the collection.
    - Dictionary<Tkey,TValue> 
        - It stores key/value pairs
        - Keys must be Unique
    - SortedList<TKey,TValue>
        - It is a sorted list of key/value pairs 
    - LinkedList<T> 
        - It allows fast inserting and removing of elements. It implements a classic linked list.
        - Each element is separately allocated.
        - Properties:
            - Count -	Gets the number of nodes actually contained in the LinkedList.
            - First -	Gets the first node of the LinkedList.
            - Last - Gets the last node of the LinkedList.
        - Methods:
            - AddFirst - Adds a new node or value at the start of the LinkedList.
            - AddLast -	Adds a new node or value at the end of the LinkedList.
            - Clear() -	Removes all nodes from the LinkedList.
            - Contains(T) -	Determines whether a value is in the LinkedList.
            - Remove(LinkedListNode) - Removes the specified node from the LinkedList.
            - Remove(T) - Removes the first occurrence of the specified value from the LinkedList.
            - RemoveFirst() - Removes the node at the start of the LinkedList.
            - RemoveLast() - Removes the node at the end of the LinkedList.
### Exceptions
- An exception is an event that occurs during the execution of a program that distrupts the normal flow of instructions
    - Horrible to encounter when presenting your program (When it is expected to work perfectly fine)
    - Great when trying to find bugs in your program
- They are not Errors!
#### Errors
- A serious problem that for the most part cannot be handled by the developer
    -They are fatal to the program at runtime
    - Ex: A stack overflow error and that usually occurs when your computer has run out of memory to store information
- 3 types of errors
    - Usage error - error in your program logic and can be solve by modifying/restructuring your code
    - Program Error - run-time error that cannot be avoided even with a bug-free code (Ex: Your SDK is corrupt and can't compile or translate it to machine code properly)
    - System Failures - run-time error that cannot be handled programmatically in a meaninful way (Ex: your ram hardware is faulty)
#### Exception Handling
- Using a try-catch block and optionally finally block
- If you know the block of code you will run will have a risk of throwing an exception, you should put it in the try block
- The catch block will then "catch" that exception and will run instead its block of code
    - Once an exception occurs in the try block, the flow of control jumps to the first associated exception handler that is present anywhere in the call stack. In C#, the catch keyword is used to define an exception handler.
    - If no exception handler for a given exception is present, the program stops executing with an error message.
    - Don't catch an exception unless you can handle it and leave the application in a known state. 
- Optionally, you can add a finally block that will run regardless if your code throws an exception or not
    - Mostly used to clean up any resources you used in the try blcok
#### Throwing Exception
- You can throw an exception yourself in your code by using the throw keyword
- Useful for enforcing certain rules/logic in your program
#### Exception Heirarchy
- Certain exceptions are more specific than other exceptions
- General rule is the most specific exception should be the very first catch block and the least specific exception is at the very last catch block
    - Why? Well if you made the least specific the first catch block then it will always run if any exception is thrown making your other catch blocks useless
### Additional Resources
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/core/introduction)
- [.NET Glossary](https://docs.microsoft.com/en-us/dotnet/standard/glossary)
- [Introducing .NET 5](https://devblogs.microsoft.com/dotnet/introducing-net-5/)
- [What is .NET?](https://www.codecademy.com/articles/what-is-net)
- [.Net CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/)