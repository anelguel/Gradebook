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

