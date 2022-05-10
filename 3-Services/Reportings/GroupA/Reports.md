# Delegates, Anonymous Method, And Lambda Expressions?

## Delegates 

### What are Delegates?

- A delegate is a type that represents references to methods with a particular parameter list and return type. You are also able to define variables of delegates.
- Delegates are type-safe, object oriented and secure because we are referencing methods which prevents incorrect coding from happening.
- Delegates allow you to assign a method to the delegate and the method will be called each time the delegate is called.

Delegate declaration  code:

```text
public delegate int PerformCalculation(int x, int y);
```

### Why are Delegates used?

- Allows programmers to pass methods as arguments to other methods. Delegates make implementing events and call-back methods easier than other possible solutions.
- Delegates provide flexibility to your code because you can easily add the new code into existing classes or change the method call.
- Delegates can also be more general since the comparison code is separate from the library.

### Code Example of Delegates

This code applies delegates:
Allowing us to call another method as parameters and allowing for better separation of concerns.

```text
public delegate void MyDelegare(string var);  
protected void Page_Load(object sender, EventArgs e)  
  
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
namespace DelegatesDemo {  
    class Program {  
        static void Display(string S) {  
            Console.WriteLine("My Name is :" + S);  
        }  
        delegate void X(string a);  
        static void Main(string[] args) {  
            X objD = new X(Display);  
            objD("Rathrola Prem Kumar");  
            Console.Read();  
        }  
    }  
}    
```

## Func Delegate, What are they?

- [Func] is a generic delegate that is part of the System namespace.
This delegate encapsulates a method that has no parameter or more parameters and returns a value of the type specified.
- This allows you to minimize the amount of code required for methods

![](https://www.tutorialsteacher.com/Content/images/csharp/func-delegate.png)

### Code Example of Func

This code uses two parameters and returns a value in Int

```text
class Program
{
    static int Sum(int x, int y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        Func<int,int, int> add = Sum;

        int result = add(10, 10);

        Console.WriteLine(result); 
    }
}
```

## Action Delegate, What are they?

- An [Action] is a generic delegate and is like the Func Delegate but it does not ruturn a value.
- The Action delegates can be used with methods that have a void return type.
- Able to remove the declared delegate.
- Requires more code to implement Action than Func.

### Code Example of Action

You are able to remove the delegate and add an action delegate instead.

```text
public delegate void Print(int val);
```

Code that uses Action delegate and it does not require you to define the parameter:

```text
static void ConsolePrint(int i)
{
    Console.WriteLine(i);
}

static void Main(string[] args)
{
    Action<int> printActionDel = ConsolePrint;
    printActionDel(10);
}
```

### Predicate delegate, What are they?

- [Predicate] is a generic delegate and this method contains a set of criteria and checks if the parameter meets the conditions.
- Predicate can only take one parameter and will return a Boolean value.

Predicate code:

```text
public delegate bool Predicate<in T>(T obj);
```

### Example of Predicate Code

This code defines the delegate named predicate and assigns it to a method named IsUpperCase. This will Return False because the string is lower case:

```text
static bool IsUpperCase(string str)
{
    return str.Equals(str.ToUpper());
}

static void Main(string[] args)
{
    Predicate<string> isUpper = IsUpperCase;

    bool result = isUpper("hello world!!");

    Console.WriteLine(result);
}
```

## Anonymous Method, What are they?

- [Anonymous] methods are methods that do not have a name and invoked directly by delegate keyword.
- When the delegate keyword is used you can remove the parameter list, this allows the anonymous method to convert a delegate type with any list of parameters.
- This associates the method definition to a delegate, when you bind with a callback this anonymous method will be called. Which ensures that this delegate is called at a particular event.
- You cannot use Lambda Expressions unlike other delegates.
//  An anonymous method is a method without a name. Anonymous methods in C# can be defined using the delegate keyword and can be assigned to a variable of delegate type.

## Anonymous Method, Continued - Jamaal Fisher
public delegate void Print(int value);

static void Main(string[] args)
{
    Print print = delegate(int val)
	{ 
        Console.WriteLine("Inside Anonymous method. Value: {0}", val); 
    	};

    print(100);
}
Output
Inside Anonymous method. Value: 100

Anonymous methods can access variables defined in an outer function.


public delegate void Print(int value);

static void Main(string[] args)
{
    int i = 10;

Print prnt = delegate(int val)
{
        val += i;
        Console.WriteLine("Anonymous method: {0}", val); 
    	};

    prnt(100);
}
 Output
Anonymous method: 110

Anonymous methods can also be passed to a method that accepts the delegate as a parameter.


public delegate void Print(int value);

class Program
{
    public static void PrintHelperMethod(Print printDel,int val)
    { 
        val += 10;
        printDel(val);
    }

    static void Main(string[] args)
    {
        PrintHelperMethod(delegate(int val) { Console.WriteLine("Anonymous method: {0}", val); }, 100);
    }
}

Output
Anonymous method: 110

 Anonymous methods can be used as event handlers.


saveButton.Click += delegate(Object o, EventArgs e)
{ 
    System.Windows.Forms.MessageBox.Show("Save Successfully!"); 
};

The delegate operator creates an anonymous method that can be converted to a delegate type:

Func<int, int, int> sum = delegate (int a, int b) { return a + b; };
Console.WriteLine(sum(3, 4));

Console.WriteLine();

When you use the delegate operator, you might omit the parameter list.
If you do that, the created anonymous method can be converted to a delegate type with any list of parameters.
That's the only functionality of anonymous methods that is not supported by lambda expressions.

Action greet = delegate { Console.WriteLine("Hello!"); };
greet();

Action<int, double> introduce = delegate { Console.WriteLine("This is world!"); };
introduce(42, 2.7);

/*

Benefits of Anonymous Methods:
Anonymous methods are used to define delegates and to write inline functions.
The benefit of anonymous methods is, improve development experience over using delegates. The main benefits of anonymous methods is to implement delegates with less code.

Limitations:
- It cannot contain jump statement like goto, break or continue.
- It cannot access ref or out parameter of an outer method.
- It cannot have or access unsafe code.
- It cannot be used on the left side of the is operator.
- A static anonymous method can't capture local variables or instance state from enclosing scopes.

*/

##  **Lambda Expressions** - Blake

### **Lambda Expressions Definition**
####  
- Lambda Expressions are an abbreviated way of writing anonymous methods.
- Depending on the Lambda Expression you use, you either have to implicitly express your return value, or explicitly express it. 


### **What are Lambda Expressions?**
#### 
- They are anonymous methods written using a different syntax that does not use the delegate keyword. They also utilize the lambda operator, which looks like this: => 
- To the left of the lambda operator is the input (typically parameters), and to the right, is the statement/expression (the body of the method).
- There are two types: Expression Lambda, which will return the value implicitly and Statement Lambda, which you’d have to explicitly state the return value


### **Why use Lambda Expressions?**
#### 
 - Much like traditional anonymous methods, you use lambdas when you only plan to use the method one time.
 - It is quicker to write a lambda than a traditional or anonymous method.
 - It is also helpful to see what the method does in the same location where you want to use said method, which would most likely not be the case if you were just calling a regular named method. 
 - Due to parameter type inference, if the compiler can infer what type your parameters are, you don't need to specify those types in your lambda expression.  


### **Code Example of Lambda Expressions**

#### var kantopoke = starter.Where(p => p.region == "Kanto").Select(p => p.name);

#### suggestedpoke = starter.Where(p => p.type == "Fire" && p.trainer == "Ash").Select(p => p.name);

#### var allpoke = starter.Select(p => p.name);

#### Func<int, int, int> add = (x, y) => x + y;

####     Func<int, int, int> add2 = (x, y) =>
            {
                var sum = x + y;
                return sum;
            };

## Lambda Expressions -Jermaine Williams

### Lambda Expressions Definition
#### 
Lambda Expressions are an abbreviated way of writing anonymous methods. What makes them different from anonymous methods is that with using them, you don’t have to specify the type of value that you use for the input, which makes it more flexible to be used. Depending on the kind of Lambda Expression you use, you either have to implicitly express your return value, or explicitly express it. 


### What are Lambda Expressions?
#### 
They are anonymous methods written using a different syntax that does not use the delegate keyword. They also utilize the lambda operator, which looks like this: => 
To the left of the lambda operator is the input (typically parameters), and to the right, is the statement/expression (the body of the method).
There are two types: Expression Lambda, which will return the value implicitly and Statement Lambda, which you’d have to explicitly state the return value


### Why use Lambda Expressions?
#### 
Much like traditional anonymous methods, you use lambdas when you only plan to use the method one time. It is quicker to write a lambda than a traditional or anonymous method. It is also helpful to see what the method does in the same location where you want to use said method, which would most likely not be the case if you were just calling a regular named method.  


### Code Example of Lambda Expressions

#### var kantopoke = starter.Where(p => p.region == "Kanto").Select(p => p.name);

#### suggestedpoke = starter.Where(p => p.type == "Fire" && p.trainer == "Ash").Select(p => p.name);

#### var allpoke = starter.Select(p => p.name);

#### Func<int, int, int> add = (x, y) => x + y;

####        Func<int, int, int> add2 = (x, y) =>
            {
                var sum = x + y;
                return sum;
            };

## References/Links
-Delegate Links:

[Microsoft-Delegates](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/),

[C-Sharpcorner](https://www.c-sharpcorner.com/UploadFile/8911c4/simple-delegates-with-examples-in-C-Sharp/)

[Microsoft-Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2?view=net-6.0)

[Microsoft-Action](https://docs.microsoft.com/en-us/dotnet/api/system.action?view=net-6.0)

[Microsoft-Predicate](https://docs.microsoft.com/en-us/dotnet/api/system.predicate-1?view=net-6.0)

[Anonymous](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/delegates-with-named-vs-anonymous-methods)

[TutorialsTeacher](https://www.tutorialsteacher.com/csharp/csharp-delegates)
#### https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

#### https://www.youtube.com/watch?v=DSxjciDUBdw&t=548s

#### https://weblogs.asp.net/dixin/understanding-csharp-features-5-lambda-expression

#### https://www.youtube.com/watch?v=kYeKFMf2mO8&t=183s

#### https://www.youtube.com/watch?v=xev-kNmz_a0&list=WL&index=2&t=1254s