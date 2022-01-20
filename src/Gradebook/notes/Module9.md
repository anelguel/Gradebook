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
* `Dervied Class? : Base Class`

### Deriving from System.Object
* In .NET, every class has a base class.
* There is no limit to how far the inheritance heirarchy can go. In practice, inheritance can make code difficult to follow, so it's best not to have deep inheritance heirarchies.
* In .NET everything will derive from `System.Object` (or also `object`), this has many types that pop up in intellisense including `ToString()`, `Equals()`, etc. Anything in .NET (int, double, `Book`, or `Book : NameObject` derives from this).
