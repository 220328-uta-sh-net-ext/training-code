## Testing 
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

## References
- [TDD](https://en.wikipedia.org/wiki/Test-driven_development)
- [Unit Testing](https://docs.microsoft.com/en-us/visualstudio/test/unit-test-basics?view=vs-2022)
- [xUnit](https://xunit.net/docs/getting-started/netcore/cmdline)
- [Code Coverage basics](https://www.atlassian.com/continuous-delivery/software-testing/code-coverage)
- [Code coverage](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=windows)
- [Unit Testing Best practices](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)
