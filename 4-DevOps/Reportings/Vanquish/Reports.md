
# <strong>Benefits of Clean Code</strong>
1. Clean code is obvious for other programmers
2. Clean code doesn't contain duplication
3. Clean code contains a minimal number of classes and other moving parts
4. Clean code passes all tests
5. Clean code is easier and cheaper to maintain


# <strong>Technical Debt</strong>
<strong>Describes what results when development teams take actions to expedite the delivery of a piece of functionality or a project which later needs to be refactored</strong>

# Reasons for technical debt
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

# <strong>Refactoring</strong>
# Refactoring Checklist
- The code should become cleaner.
- New functionality should not be created
- All existing tests must pass after refactoring


# <strong>Code Smells</strong>

<strong>According to Martin Fowler</strong>, <i>"a code smell is a surface indication that usually corresponds to a deeper problem in the system."</i>

# Types of Code Smells
1. Bloaters: Bloaters are code, methods and classes that have increased to such gargantuan proportions that they are hard to work with. Usually these smells do not crop up right away, rather they accumulate over time as the program evolves (and especially when nobody makes an effort to eradicate them).
    * Long Methods
    * Large Class
    * Primitive Obsession
    * Long Parameter List
    * Data Clumps
2. Object-Oriented Abusers: All these smells are incomplete or incorrect application of object-oriented programming principles.
    * Alternative Classes with Different Interfaces
    * Refused Request
    * Temporary Field
    * Switch Statements
3. Change Preventers: These smells mean that if you need to change something in one place in your code, you have to make many changes in other places too. Program development becomes much more complicated and expensive as a result.
    * Divergent Change
    * Parallel Inheritance Hierarchies
    * Shotgun Surgery
4. Dispensables: A dispensable is something pointless and unneeded whose absence would make the code cleaner, more efficient and easier to understand.
    * Comments
    * Duplicate Code
    * Data Class
    * Dead Code
    * Lazy Class
    * Speculative Generality
5. Couplers: 
All the smells in this group contribute to excessive coupling between classes or show what happens if coupling is replaced by excessive delegation.
    * Feature Envy
    * Incomplete Library Class
    * Middle Man
    * Inappropriate Intamacy 
    * Message Chains


