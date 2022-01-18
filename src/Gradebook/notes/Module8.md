# Module 8: Building Types

### Overloading Methods
Classes have members (fields, methods). Methods can have the same name, but the parameter has to be different. However, two identical methods with the same parameters but different return type will fail to compile.

### Defining Properties
Another type of member is a property. A property is similar to a field in that it can encapsulate state and it can store data for an object.

### Defining Propery Getters and Setters
What is the different between a field and a propety?
* There are a couple having to do with how code gets compiled at runtime, however & more importantly, you can apply different access modifiers to `get` and `set`.
* For example, a `private set` tells the compiler that any operation that wants to write to this property from outside of the class (`Book.cs`), will not have access to write to this property.

### Defining readonly Members
* Having a property with `private set;` is essentially reado nly. What else can we do to make a variable or field read only or constant (it cannot change)?
* `readonly` - the readonly keyword gives a field that can only initialize or change or write to in the *constructor*.

> Constructors, like methods, can also be overloaded.

### Defining const Members
*  `const` has even stronger semantics than `readonly`.
* You cannot change a `const` value, even from a constructor
* Like `readonly`, but rules are even more strict. For example, if you make a `const int x = 3;` later you can't even do `x++` (add to it) because its value never changes.
* `const` fields are treated like static members (cannot access a static memnber via an object reference, can only reference vai type name) of the class. This makes sense because the value never changes.

### Events
* Another member that you can add to a class.
* Events are not commonly used, and are hard to understand, but we'll still cover it.  
* Before we can just into events, we have to understand a new type known as a delegate.

### Defining a Delegate
* Delegates describe and build a new type for .NET, but delegates are very different than a `class` or `struct`
* Classes describe members like fields, properties, methods, etc. Delegates describe what a method will look like.
* A delegate allows me to **define a variable that can point and invoke different methods**. But it's not just any method, it needs to have a specific shape and structure.
* You define what a method looks like, i.e. the return type, parameter types and numbers. That's what we define with a delegate.
* A delegate can be intiantionated like a class using the `new` keyword.

### Using Multi-cast Delegates
* Delegates can invole multiple methods.
* Delegates give me the ability to declare a variable that I can use like a method.
    * In a nutshell, delegates allow you to have a variable type of type method? Revisit delegates and events again.
