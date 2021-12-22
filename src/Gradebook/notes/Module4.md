## Module 4: Working with Classes and Objects
### Creating a Class
Talked about namespace, and mentioned that a class defines a new type (just like a list, array, Console, etc.)

## Adding State and Behavior
You can have as many classes as you want in a namespace, but the convention is to add *one* class per file (in this case, Program.cs or namespace)
A class consists two things: the state or data it holds (property), and then there is the behavior (method) which acts on that state

## Defining a Method
*void*: Method is not going to return a value

## Defining a Field
* Field definition - Adding state to a class definition
* Looks like a variable declaration in a class (like `<data_type> <variable_name>`)
* In a field, you cannot use implicit typing (like var), instead you need to be explicit, like List<double>
* Should be inside of class, but outside of any methods so that it's public
* When you add a field, it means that every method in that class will have access and can interact with that field.

## Adding a Constructor
* Null Reference Exception = you're using a field or variable that has not been properly initialized
* Think of a class like a blueprint, it's going to describe how I'm going to build objects. Every class is like a cookie cutter. Every cookie I stamp out is an object. 
* Instantiate a class = creating an object

* A Constructor is just another method in your class, but it has some special conventions:
    * It has to have the same name as your class. 
    * It cannot have a return type.
    * And any code that I write is guaranteed to execute when I use the `new` keyword against this class. It will execute before invoking any methods in the class.

## Requiring Constructor Parameters
* Encapsulation – is hiding complexities and details that are unimportant at a certain level
* Access modifies (public, private, etc.)
* Public – code outside of this class can have access to this particular method/member. This can be added to methods, fields.
* Private – I only want this method/field to be available to code inside of this class 
* The `this.` keyword: This is an implicit variable that is always available inside of *methods* and inside of  *constuctors*. You use it when you want to refer to the object that is currently being operated on. *On THIS object*.

## Working with Static Members
* The opposite of static is to have a method that does not use the static keyword, and this is what we call an instance member of a class. And that means that whenever I have an object of type book, the public method will be available.
* Statics are not associated with an object instance. Statics are associated with the TYPE they are defined inside of.
    * You cannot reach it (a static method) through an object. It is not associated with a specific object, instead, it is associated with a class (in the default case, named Program). 
* The only way to reach (for example, in the default case, Main) is to use the class name/type where Main is defined (Program.Main(args)).


