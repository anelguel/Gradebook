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