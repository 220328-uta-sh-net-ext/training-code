# HTML
* Hypertext Markup Language
* Another markup language so that means it is just telling the computer what to do and not compiling it into machine code
* Very similar to xml (our .csproj files) but HTML is used to define the structure of our webpages
* Our browsers are essentially experts at reading this files and interpreting it to display something on the browser
* We are currently on version HTML 5

## HTML elements
* so like XML, it uses tags to define what something should be displayed and instead of calling them "tags" we also call them HTML elements
* They are, for the most part, a basic graphical unit of something you want to display/structure on your web page

## HTML attributes
* They are used to provide extra information that the tag can use
* Ex: img tag using src attribute to find a specific image to display

## Web Accessiblity
* In the past only a computer has access to a website and so usually websites are created for a pc only. That's not the case anymore.
* So Web accessiblity is configuring your website in a way so it is also readable beyond pc users such as phone, tablets, gaming consoles, etc. 
* This is usually done by manipulating CSS 

# CSS
* Cascading Style Sheets
    * Cascading is in the name because it uses a cascading algorithm to determine what style it should apple (more on this later)
* A way to stop making your website looking like it came from the 90s

## CSS Selectors
* Before applying styles everywhere, we need a way to select specific or group of HTMl elements first so we give them their own type of look
* There are three basic fundamental selectors we should keep in mind:
1. Element selector - When you want to select multiple elements of the same tag
2. Class selector - When you want to select multiple elements of differing tag by using the class attribute
3. Id selector - When you want to select one (mostly) or a couple elements using the id attribute

## Different ways to include CSS
* Inline CSS
    * Applies CSS to a single element
    * It uses the style attribute
    * Has the highest priority
* Internal CSS
    * Applies CSS by using the style tag inside of a HTML doc
    * Used to apply multiple css to multiple elements
    * Second priority
* External CSS
    * Creating an external .css file to apply css to multiple HTML docs (you can just apply it to one HTML but that kind of defeats the purpose of using an external css)
    * HTML doc must use the link tag to reference the external css
    * Used to apply multiple css to multiple elements in multiple HTML docs
        * So useful to create a universal theme of your website
    * Least priority

# Responsive Web Design
* Making your elements not have rigid in size but changes its size based on the viewport
    * Viewport is just how big the window of the browser is (small for phones, big for computers)
* Useful to accomodate for every devices out there that might access your website
* We will leverage Bootstrap libraries for pre-made css files to implement this design
    * Click [here](https://getbootstrap.com/docs/5.1/getting-started/introduction/) for Bootstrap documentation

# JavaScript
* Best way to make your website dynamically changed
* It is both a functional language and object-oriented programming language (ever since ES6)
    * Functional language just means that it uses a lot of functions and you can also use them as variables, parameters inside of other functions and it makes things look... very complicated
    * You can think of functions as methods in C# just with a different name and doesn't need a class attached to it to make one
* Key difference with C# is that it is **loosely typed**
    * Meaning every variable you create can hold any datatype and will have no issues switching between datatypes (Remember cannot implicity convert blah blah exception on C#? That's gone in JavaScript)
* Interesting enough JavaScript is both compiled and interpreted
    * It used to be just interpreted (like SQL) but with introduction to more modern tools that uses JavaScript they improved it to also be compiled
    * Essentially, if a function keeps getting called multiple times, it will compile that code into an optimized native machine code to be more efficient 
* We are currently in EcmaScript 6 version
    * It introduced many wonderful things but for the most part confused a ton of people who use JS often in the past since this is when classes are introduced.

# Datatypes
* QC might ask a list of datatypes from JS so here are a couple most used ones
* Numbers
* Boolean
* Strings
* Objects
* Null - Lack of value meaning this variable doesn't have any information at the moment
* Undefined - no value was set meaning you just created a variable and didn't set it with any value

# Prototype
* It is like a field in C# in a form of a key-value pair
* Every function (and other things) have prototypes and you can add prototypes as well
## Prototypal Inheritance
* The technical name that says you can inherit other prototypes so you have code re-usability

# Classes
* As you know, templates for creating objects
* Didn't use to exist which made things weird and divided some communities in JS
    * Essentially some people say to never use it because it's inefficient or error prone
    * Some people say to use it because it makes looking at your code easier to read (you should see example of how JS used to implement class-like things using just functions (spoiler alert: it looks gross))
* Has most of the OOP pillars we discussed and implements them easily except abstraction

# JS HTML DOM
* Allows JavaScript to specifically pick certain elements in the HTML and change/manipulate them somehow based on whatever function you created
* This is what makes JS a powerful tool to making your html page dynamically change based on whatever the user is doing

# Introduction to sending and receiving data in JS
## AJAX
* Asynchronous JS and XML
* Used to grab information only with XML type backend server hence the name
    * But they want ahead and updated the object to also include JSON to be relevant
## Fetch
* Similar to AJAX except less syntaxes or prepping needed to call on backend
* Main difference from AJAX is it uses promises to achieve asynchrnous operations
### Promises
* Represents either the completion or failure of an asynchronous operation
* Allows you to "setup" what to do after a completion of a promise and get its result and also account for a failure of a promise and what to do using "then()".

## Nice to know with JS
### Scopes
* The scope of a variable determines where it has access to
* Block
    * Cannot be access from outside {}
    ```JS
    {
        let x = 2;
    }
    //Anything outside cannot see that x variable
    ```
* Function
    * Each function you create is a new scope
    * Kinda like methods in C# in that variables created in the function only stays in that function
* Global
    * Can be access anywhere in JS
    * Var keyword that will give variable a global scope
    ```JS
    {
        var x = 2;
    }
    //Anything outside this block scope still has access to x because it is global
    ```
* let keyword limits the scope of the variable depending on where it was declared
    * Mostly use "let" to try your best to avoid conflicting variable names

### Truthy and Falsey
* In JS, all values have Boolean equivalent to it
* Meaning you can do "hello"==97.6 perfectly just fine in JS
#### What counts as false values?
* FUN0NE - Acryonym to remember it
* False
* Undefined
* Null
* 0 (-0 and +0 as well)
* NaN (Not A Number)
* Empty String

# Security w/ HTTP
## CORS
* Cross Origin Resource Sharing
* It is a way for you to share your resource to other people
* It is a mechanism that checks the current origin of where that request comes from and see if they have permission to access your resource
* General workflow: a user will send a request and the browser will send a mini request to first check if you have access, the backend server will recognize the CORS check and will send a response if you do have permission. If so, your browser will send the real request. If not, you will have a CORS error

## CSRF
* Cross-Site Request Forgery and it is a web security vulnerability that attackers use
* It bypasses CORS by using you as a user to essentially do a request (usually on a bank account website) to ask to withdraw money from your account and send it they want.
* Tokens are a way to combat CSRF

## XSS
* Cross-Site Scripting
* Some hidden segment of JS coupled with HTML and CSS to emulate a harmless website
    * Hidden in a way that JS is within HTML doc and this is done through a bunch of tools
* In its essence, the script’s job is to grab any tokens, cookies, or other session information from the user
* There are so many ways to achieve XSS that the best way to avoid it is to follow a bunch of rules to prevent it
    * [OWASP](https://cheatsheetseries.owasp.org/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.html) Documentation to prevent XSS
    * You don't need to know all/any the rules but just know there is a free resource called OWASP to check the rules and other vulnerabilities

