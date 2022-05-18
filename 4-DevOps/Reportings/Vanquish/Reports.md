# <strong>VANQUISH REPORT</strong>

# Static Code Analysis

Static Code Analysis is a method of debugging code without executing it. It is usually performed as part of a Code Review (also known as white-box testing) and is carried out at the implementation phase of a Security Development Lifecycle (SDL) to highlight possible vulnerabilities within ‘static’ (non-running) source code by using techniques such as Taint Analysis and Data Flow Analysis.

## Advantages of Static Code Analysis
  1. Helps identify software quality issues during development
  2. Detects the codes than need to be simplified
  3. Detects coding error
  4. Improves communications between development teams to produce high quality code


## Techniques
There are various techniques to analyze static source code for potential vulnerabilities that may be combined into one solution. These techniques are often derived from compiler technologies. They are as follows...

### Data Flow Analysis
Data flow analysis is used to collect run-time (dynamic) information about data in software while it is in a static state.

There are three common terms used in data flow analysis. They are...
  1. Basic block (the code)
  2. Control Flow Analysis (the flow of data)
  3. Control Flow Path - (the path the data takes)

## Taint Analysis
These are attempts to identify variables that have been ‘tainted’ with user controllable input and traces them to possible vulnerable functions also known as a ‘sink’.

## Lexical Analysis
Converts source code syntax into ‘tokens’ of information in an attempt to abstract the source code and make it easier to manipulate.

## Strengths and Weaknesses of Static Code Analysis

**Strengths:** 

  1. Scales well (Can be run on lots of software, and can be repeatedly (like in nightly builds))

  2. For things that such tools can automatically find with high confidence, such as buffer overflows, SQL Injection Flaws, etc, they are great.

**Weaknesses**

  1. Many types of security vulnerabilities are very difficult to find automatically, such as authentication problems, access control issues, insecure use of cryptography, etc.

  2. Other weaknesses include high numbers of false positives.

  3. Frequently can’t find configuration issues, since they are not represented in the code.

  4. Difficult to prove that an identified security issue is an actual vulnerability.







# <strong>Benefits of Clean Code</strong>
1. Is obvious for other programmers
2. Doesn't contain duplication
3. Contains a minimal number of classes and other moving parts
4. Passes all tests
5. Easier and cheaper to maintain


# <strong>Technical Debt</strong>
<strong>Describes what results when development teams take actions to expedite the delivery of a piece of functionality or a project which later needs to be refactored</strong>

## Reasons for technical debt
* <strong>Business Pressure:</strong> Sometimes business circumstances might force you to roll out features before they’re completely finished. In this case, patches and kludges will appear in the code to hide the unfinished parts of the project.
* <strong>Lack of understanding of the consequences of technical debt:</strong> Sometimes your employer might not understand that technical debt has “interest” insofar as it slows down the pace of development as debt accumulates. This can make it too difficult to dedicate the team’s time to refactoring because management doesn’t see the value of it.
* <strong>Failing to combat the strict coherence of components:</strong> This is when the project resembles a monolith rather than the product of individual modules. In this case, any changes to one part of the project will affect others. Team development is made more difficult because it’s difficult to isolate the work of individual members.
* <strong>Lack of tests:</strong> The lack of immediate feedback encourages quick, but risky workarounds or kludges. In worst cases, these changes are implemented and deployed right into the production without any prior testing. The consequences can be catastrophic. For example, an innocent-looking hotfix might send a weird test email to thousands of customers or even worse, flush or corrupt an entire database.
* <strong>Lack of documentation:</strong> This slows down the introduction of new people to the project and can grind development to a halt if key people leave the project.
* <strong>Lack of interaction between team members:</strong> If the knowledge base isn’t distributed throughout the company, people will end up working with an outdated understanding of processes and information about the project. This situation can be exacerbated when junior developers are incorrectly trained by their mentors.
* <strong>Long-term simultaneous development in several branches:</strong> This can lead to the accumulation of technical debt, which is then increased when changes are merged. The more changes made in isolation, the greater the total technical debt.
* <strong>Delayed refactoring:</strong> The project’s requirements are constantly changing and at some point it may become obvious that parts of the code are obsolete, have become cumbersome, and must be redesigned to meet new requirements. On the other hand, the project’s programmers are writing new code every day that works with the obsolete parts. Therefore, the longer refactoring is delayed, the more dependent code will have to be reworked in the future.
* <strong>Lack of compliance monitoring:</strong> This happens when everyone working on the project writes code as they see fit (i.e. the same way they wrote the last project).
* <strong>Incompetence:</strong> This is when the developer just doesn’t know how to write decent code.


# <strong>Code Smells</strong>

<strong>According to Martin Fowler</strong>, <i>"a code smell is a surface indication that usually corresponds to a deeper problem in the system."</i>

# Types of Code Smells
1. <strong>Bloaters:</strong> Bloaters are code, methods and classes that have increased to such gargantuan proportions that they are hard to work with. Usually these smells do not crop up right away, rather they accumulate over time as the program evolves (and especially when nobody makes an effort to eradicate them).
    * Long Methods
        * A method contains too many lines of code. Generally, any method longer than ten lines should make you start asking questions.
    * Large Class
        *  A class contains many fields/methods/lines of code.
    * Primitive Obsession
        * Use of primitives instead of small objects for simple tasks (such as currency, ranges, special strings for phone numbers, etc.)
        * Use of constants for coding information (such as a constant USER_ADMIN_ROLE = 1 for referring to users with administrator rights.)
        * Use of string constants as field names for use in data arrays.
    * Long Parameter List
        * More than three or four parameters for a method.
    * Data Clumps
         * Sometimes different parts of the code contain identical groups of variables (such as parameters for connecting to a database). These clumps should be turned into their own classes.
2. <strong>Object-Oriented Abusers:</strong> All these smells are incomplete or incorrect application of object-oriented programming principles.
    * Alternative Classes with Different Interfaces
        * Two classes perform identical functions but have different method names.
    * Refused Request
        * If a subclass uses only some of the methods and properties inherited from its parents, the hierarchy is off-kilter. The unneeded methods may simply go unused or be redefined and give off exceptions.
    * Temporary Field
        * Temporary fields get their values (and thus are needed by objects) only under certain circumstances. Outside of these circumstances, they’re empty.
    * Switch Statements
        * You have a complex switch operator or sequence of if statements.
3. <strong>Change Preventers:</strong> These smells mean that if you need to change something in one place in your code, you have to make many changes in other places too. Program development becomes much more complicated and expensive as a result.
    * Divergent Change
        * You find yourself having to change many unrelated methods when you make changes to a class. For example, when adding a new product type you have to change the methods for finding, displaying, and ordering products.
    * Parallel Inheritance Hierarchies
        * Whenever you create a subclass for a class, you find yourself needing to create a subclass for another class.
    * Shotgun Surgery
        * Making any modifications requires that you make many small changes to many different classes.
4. <strong>Dispensables:</strong> A dispensable is something pointless and unneeded whose absence would make the code cleaner, more efficient and easier to understand.
    * Comments
        * A method is filled with explanatory comments.
    * Duplicate Code
        * Two code fragments look almost identical.
    * Data Class
        * A data class refers to a class that contains only fields and crude methods for accessing them (getters and setters). These are simply containers for data used by other classes. These classes don’t contain any additional functionality and can’t independently operate on the data that they own.
    * Dead Code
        * A variable, parameter, field, method or class is no longer used (usually because it’s obsolete).
    * Lazy Class
        * Understanding and maintaining classes always costs time and money. So if a class doesn’t do enough to earn your attention, it should be deleted.
    * Speculative Generality
        * There’s an unused class, method, field or parameter.
5. <strong>Couplers:</strong> All the smells in this group contribute to excessive coupling between classes or show what happens if coupling is replaced by excessive delegation.
    * Feature Envy
        * A method accesses the data of another object more than its own data.

    * Middle Man
        * If a class performs only one action, delegating work to another class, why does it exist at all?
    * Inappropriate Intamacy 
        * One class uses the internal fields and methods of another class.
    * Message Chains
        * In code you see a series of calls resembling $a->b()->c()->d()


# Sonar Cloud
## What is SonarCloud
- SonarCloud is a cloud-based code analysis service designed to detect code quality issues.
- continuously ensuring the maintainability, reliability and security of your code.
- supports 25 different programming languages (Java, JavaScript, TypeScript, Python, C# and C/C++)

## What Does SonarCloud Do
- SonarCloud uses state-of-the-art techniques in static code analysis to find problems, and potential problems.
- **state-of-the-art** - The level of development reached at any particular time
- helps to find error in early stages that will ultimately increase the overall quality of your production code. 

##  DevOps platform
- GitHub
- Bitbucket Cloud
- Azure DevOps
- GitLab

## What Does SonarCloud Detect
- Issues
- Security Hotspots
	
## Types of Issues
- Code Smells
- Bugs: errors in the code that can prevent the program from operating as intended. They affect code reliability.
- Vulnerabilities: problems in the code that could be exploited by a bad actor to compromise the security of the application.

## Security Hotspots
- Security hotspots are areas of the code that may cause security issues and therefore need to be reviewed. 
- By separating hotspots from issues, SonarCloud maintains the accuracy of its issue detection while still providing developers with useful warnings under the less strict 	   criteria of the hotspot.

## Where SonarCloud Fits In
- In the Editor
- In the Pull Request
- In the Codebase

- Code analysis at the editor and pull request level helps to find problems occured while merging codes.
- To find these types of problems, SonarCloud needs to analyze the entire codebase as a single unit and (in the case of some languages) also analyze the results of compiling the code. 

## To do this SonarCloud offers two approaches: 
- Automatic analysis  
- CI-based Analysis

## Automatic analysis:
-  SonarCloud detects problems every time that a pull request is merged and analyzes the new state of the code in your repository. 
- It only works with GitHub.
- it does not work with compiled languages such as Java and C/C++.

## CI-based Analysis
- CI-based analysis refers to the configuration of SonarCloud so that it performs analysis as part of your regular continuous integration (CI) process, in other words, your build process.

# References 
 https://docs.sonarcloud.io/
 <br>
 https://owasp.org/www-community/controls/Static_Code_Analysis
 <br>
 https://refactoring.guru/refactoring/what-is-refactoring
