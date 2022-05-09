
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

## References/Links

#### https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

#### https://www.youtube.com/watch?v=DSxjciDUBdw&t=548s

#### https://weblogs.asp.net/dixin/understanding-csharp-features-5-lambda-expression

#### https://www.youtube.com/watch?v=kYeKFMf2mO8&t=183s

#### https://www.youtube.com/watch?v=xev-kNmz_a0&list=WL&index=2&t=1254s