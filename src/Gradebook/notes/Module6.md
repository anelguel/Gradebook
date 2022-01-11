## Working with Reference Types and Value Types

### Reference Types and Value Types
* Reference types point to another location while a value type holds the value itself
* Intergers, floats, doubles are all value types

![](src\Gradebook\notes\images\Module6ReferenceVsValueTypes.png)
![](https://github.com/anelguel/Gradebook/blob/main/src/Gradebook/notes/images/Module6ReferenceVsValueTypes.png?raw=true)

### Creating a Solution File
* To make the work easier, especially if you are working with building more than one project (like GradeBook and GradeBook.Tests), you should build a solution file. Instead of building Gradebook and Gradebook.Tests individually changing the path between the two in the CLI, you can create a solution file to build both at the same time. A solution file is a file that keeps track of multiple projects.

* `dotnet build` looks for a `.sln` file in current directory. If there is no `.sln` file it will build `.csproj` files. When you add a `.sln` file it will restore and build BOTH `.csproj` files in the folder?

> Basically we created a `.sln` file in the folder so that we can build both Gradebook and Gradebook.Tests at the same time. This makes things easier and faster.

### Testing Object References
* No access modifier on members means that they are private by default.

### Referencing Different Objects
* Two values can reference the same object. 
![](D:\src\Personal\gradebook\src\Gradebook\notes\images\Module6ReferenceVsValueTypes.png)
![](https://github.com/anelguel/Gradebook/blob/main/src/Gradebook/notes/images/Module6ReferencingDifferentObjects.png?raw=true)

### Returning Object References
***In C# when you pass a parameter to a method, you're always passing a parameter by value.***

### Passing Parameters by Reference
![](D:\src\Personal\gradebook\src\Gradebook\notes\images\Module6PassingParametersByReference.png)
In C# when you pass a parameter to a method, you're always passing a parameter by value.

![](D:\src\Personal\gradebook\src\Gradebook\notes\images\Module6PassingParametersByReference2.png)
In day to day programming, you do not pass parameters by reference often, but it is possible by using the `ref` or `out` keyword. The difference is that with `out` you're forced to initialize the output parameter.

### Working with Value Types
Value types: int, float, DateTime, bools. What you see is what you get! With value types, the value is what you get, unlike references where you get pointers or the address location, etc.

### Value Type Parameters
You can also change value types to be passed in by reference by using the `ref` keyword.