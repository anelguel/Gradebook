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
* `readonly` - the readonly keyword gives a fields that can only initialize or change or write to in the *constructor*.

> Constructors, like methods, can also be overloaded.