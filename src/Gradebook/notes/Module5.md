## Module 5: Testing Your Code

### The Many Benefits of Unit Testing
* Verifies your code is working as intended, including edge cases
* What is a unit? Small units of code we want to test (for example, a method. Although it is part of a larger abstraction, we want to make sure this small piece is working as intended).
* xUnit is not a part of .NET, it is a separate library that works with .NET

### Creating a Unit Test Project
Run `dotnet new xunit` within `D:\gradebook\test\GradeBook.Tests`. This creates a `UnitTest1.cs` as well as the `GradeBook.Tests.csproj`. The `.cs` file contains the source code and the `.csproj` contains the project info.

### Writing and Running a Test
* `[Fact]` - this is an attribute in C#. In xUnit, an attribute is a little piece of data that is attached to the symbol that follows it. In the case of `[Fact]`, it is a little piece of data that is attached to the following method, `Test1`. 
* You can have multiple methods in the `Test1` class, but only the ones that are "decorated" with the `[Fact]` attribute are actual tests.  The compiler goes to `[Fact]` and executes those tests, but ignores all the other methods.
* `dotnet test` runs the tests. .NET will run and execute the tests in the folder. 

*Tests have three sections:*

1. Arrange – where you set up your test data and organize objects/etc. that you are going to use 

2. Act – invoke a method to perform a calculation that produces a result, the actual result

3. Assert – where you assert something about the value that was computed inside of Act

### Referencing Projects and Packages
How to do project references: I used it because my tests project did not directly reference my book project. I kept getting errors when trying to create an object of type book in my tests project:

`dotnet add reference ..\..\src\Gradebook\Gradebook.csproj` to reference tests to the actual project. You can now see that effect on `GradeBook.Tests.csproj` with the following syntax:
```
<ItemGroup>
    <ProjectReference Include="..\..\src\Gradebook\Gradebook.csproj" />
</ItemGroup> 
```
If you don’t give a class an access modifier, under the hood, you will be given an access modifier of `internal`. Internal means that this class can only be used inside of the same project. So I can only use `Book.cs` under the `Gradebook` project.