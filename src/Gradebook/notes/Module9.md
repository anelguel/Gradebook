# Object-oriented Programming with C#

### The Pillars of OOP
* Encapsulation - allows us to hide details about our code (methods and properties), and access modifier give us control over encapsulation and who sees the members of a class
* Inheritance - gives us the ability to reuse code across similar classes
* Polymorphism - allows us to have objects of the same type that can behave differently

### Deriving from a Base Class
* Inheritance allows you to define a base class. Any members that I write in a base class, I can inherit into a dervied class and allow those base class members to effectively be members of my derived class.
* DRY principle= Don't Repeat Yourself

### Chaining Constructors
* When you have a base class that inherits from a derived class, you create two different objects.
* `base()` refers to the object that I'm interacting with. It's accessing a constructor on my base class.
* `Dervied Class : Base Class`

### Deriving from System.Object
* In .NET, every class has a base class.
* There is no limit to how far the inheritance heirarchy can go. In practice, inheritance can make code difficult to follow, so it's best not to have deep inheritance heirarchies.
* In .NET everything will derive from `System.Object` (or also `object`), this has many types that pop up in intellisense including `ToString()`, `Equals()`, etc. Anything in .NET (int, double, `Book`, or `Book : NameObject` derives from this).

### Setting up a Scenario
* Highlight code > Click light bulb to the left > Extract Method. Extract Method is one refactoring technique that you use to rearrange code.
    * What that does is take all the code that I've highlighted, analyzed the return type, analyze what parameters are needed, and it will place all that code inside of a new method. It encapsulates all the operations inside of this `NewMethod()`
* Polymorphism is in a way a form of encapsulation because it is another technique that hides the underlying details and the implementations of what's really happening behind this object I'm working with.
* Polymorph - an object or material which takes various forms, and polymorphic behavior would be behavior that can change. How that happens and the details are encapsulated from me, but polymorhpism is useful because I can write methods and I can write code that is very generic and doesn't have a dependency on a specific implementation (I can work with books that store info on the harddrive or the network), I can work with all of that from inside of this method, just give me that `Book` object.

### Defining an Abstract Class
* An abstract class is a class that looks just like a regular class definition except it uses the `abstract` keyword. Abstract classes can have abstract methods. 
* When you write an `abstract` method it tells the C# compiler that I want anything that is a `BookBase` (abstract object), to have an `AddGrade` (abstract method), but at this level, I cannot provide an implementation. Let the derived types that inherit from this class figure out the implementation. 
* In C#, you can only have a single inheritance
* Anytime you inherit an abstract member (like a class), you're going to have to provide an implementation for that abstract member. You do this by calling it using the `override` keyword.

### Defining an Interface
* Another way to achieve polymorphism and encapsulation is to define an interface type. An interface definition looks very much like a class definition, but an interface is pure. That is, an interface contains no implementation details. An interface will only describe the members that should be available on a specific type.
* Naming convention, start an interface with an I (i.e., "`IBook`")
* Interfaces are far more common than abstract classes
* `virtual` keyword in C# is a way of saying, here's a method that is in this class, but a derived class might choose to override the implementation details for this method.
* An `abstract` method is implicitly `virtual` because someone needs to provide an implementation and override the abstract method
* Events, properties and methods can be virtual

### Writing Grades to a File
```
var writer = File.AppendText($"{Name}.txt");
writer.WriteLine(grade);
```

### Using IDisposable
* `using` is a keyword that can also be used in code, not just when bringing in/calling a namespace (like `using System;`). When you're working with an object that works with things like files or sockets and has some underlying resource, we typically wrap those with a `using` statement so that we can create and dispose those objects as soon as we are finished working with them,