# Data Binding

In Angular, Data binding provides the communication between a component and the Dom

Angular supports 1 way and 2 way data binding

## 1-way data binding

1-way data binding allows us to manipulate views through models, and its achieved through:

-   String interpolation: binding data from a typescript class to the template using the double curly braces {{}}

-   Property binding: allows us to bind values to the attributes of HTML elements

-   Event binding: allows us to bind DOM events such as keystrokes, button clicks, etc to a function in the component

# One way databinding example

## 2-way data binding

In 1-way data binding changes in the template are not reflected in the component, to solve this we use 2-way data binding

This is achieve by combining property binding and event binding

This is useful for gathering user input

Forms Module Information found [here](https://angular.io/api/forms/FormsModule)

# Event Emitters

EventEmitters are used to emit custom events, synchronously or asynchronously, and register handlers for those events by subscribing to an instance

You use the @Input and @Output decorators to flow data between components

-   If we have to flow data into a component you use @Input
-   If we have to emit the event or data from a component we use @Output

# Two way databinding example

# Structural Directives

Directives are markers on a DOM element that tells Angular to change the appearance, behavior, and/or layout of the Dom element and its children

Structural diectives are used to manipulate and change the structure of DOM elements

There are three built-in structural directives:

ngIf: allows us to add or remove DOM elements based upon a Boolean expression

-   you can also add an #elseBlock

ngFor: allows us to repeat a part of the HTML template once per each item from an iterable list

ngSwitch: allows us to switch betwen different elements depending on the expression. It is used with the following directives

-   ngSwitchCase
-   ngSwitchDefault

`<ng-template>` is designed to hold some template code

# Attribute Directives

Attribute Directives are used to change the look and behavior of the DOM element

There are two built in attribute directives:

ngClass: used for adding or removing CSS classes on an HTML element. It can allow us to apply CSS classes dynamically based on expression evaulation

ngStyle: allows you to dynamically change the style of an HTML element based on an expression

You can also create your own custom directives using the Angular CLI command `ng generate directive name`

-   This will create a name.directive.ts file, and automatically declares it in the AppModule file

# Directives example

# Services and Dependency Injection

Services are used to organize and share business logic, modeles, data or functions with different components of an Angular Application

Each service is a singleton instance that can be injected into multiple components. Essentially creating reusable code

In Angular a service is a class that is used to share data across multiple components, and they live in a file with .services.ts extension

We use Dependency Injection to inject services into components of our application

Dependency Injection allows a class to receive its dependencies from an outside source, instead of creating them itself

-   This helps decouple our code

The framework uses an Injector where we register all the dependencies to me managed, it is repsonisble for creating service instances and injectsing them into components

The Injector holds all the services, registers them with the NgModule or if otherwise specified wiht their provider

-   The provider tells where it the application to register the service
-   The registered services can be accessed via Depenency Injection token, which is a lookup key

## Creating/Using a service

To create a service use `ng g s name` this will create a name.service.ts file with the @Injectable decorator on the class

@Injectable marks a class as a service that can be injected

-   The proviedIn property allows you to set the service class, it also declares where it can be used
-   The Injector provides the single instance of our service
-   A hierarchy of injectors at the NgModule and component level can provide different instances of a service to their own compoents and child components

# Service example

# Hands On:
- Take the code you wrote yesterday
- Create an array of people objects with
    - Name
    - Background
    - Something interesting
- Using Angular components and directives, dynamically create components with the array above
- Style Points for making it look nice