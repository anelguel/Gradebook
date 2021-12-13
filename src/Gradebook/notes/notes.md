# C# Fundamentals

## Module 1 & 2
Intro and downloading .NET for Windows
___

## Module 2 – Understanding .NET and .NET Core

.NET - Framework that takes C# code and tells the computer what to do 

.NET Framework – Windows only, been around since 2001. Comes pre-installed on Windows.

.NET Core – newer; works on various platforms (Linux, Mac, Windows, etc.). Open source.

.NET Framework & .NET Core both support the C# language. Use .NET Core in any new projects.
___
 
## Module 3 – Understanding the .NET Runtime
What's in .NET?  that executes
.NET is a software that execute the instructions that you're writing in C#

.NET broken into two pieces:
Common Language Runtime (CLR) - .NET provides a Runtime or a space for you to run your programs in C#. The CLR in .NET knows how to bring project to life, manage memory, etc.

Framework Class Library (FCL) or Base Class Library – A library. Code already written and tested by other developers that you can use in your program.

SDK – software development kit - .NET Core.
___

## Module 4 – Using the .NET Command Line
CLI- Command Line Interface. Interacting with .NET via the command prompt.

In the command prompt, type `dotnet` to open options.
___

## Module 5 – Creating the First C# Project
Console application - is an application that can run in the command prompt.

*command prompt is called the terminal or shell in other systems

ASP.NET Core – web programming framework built on top of .NET Core for web applications

.csproj - this is a C# project, can contain info about my application. Project.

.cs - contain some C# code that is already part of my application. Source.

`dotnet run` will run a project in a given folder (the .csproj file)

`dotnet new console` – creates a new .NET project
___
## Module 7 - Running and Building You Project
*What really happens when you execute dotnet run?* 

1. Implicitly, you run dotnet restore. So in .NET there is a package system, called NuGet. A package system allows my application to take advantage of features and functionality that are in other bits of code that other developers have written, and these bits of code live inside of files known as NuGet packages. So the library that .NET Core provides has a lot of features, features that allow me to open files, do cryptography and talk over the network, but it doesn't cover everything that I could possibly want inside of .NET application. So other developers will place code inside of NuGet packages and make these packages available from what is known as a package feed somewhere on the internet. You can always let .NET know if you want more NuGet packages, that fact will always be recorded in the .csproj file

>So under the hood, dotnet restore is looking through the .csproj file to see if I have any of these external dependencies. If there are any new ones, it grabs them.

>This is the same for Node and npm, Python is pip.
		
2. After dotnet restore is a dotnet build. Dotnet build sees the full picture of the application. But the main job of dotnet build is that it compiles the source code.
**Fun fact – a compiler is a tool that can analyze code and transform or translate into an efficient binary format that is faster to execute when I need to run my application. In .NET, the compiler takes ALL your files (project.cs, etc.) and outputs a single file that is a binary representation of my source code. In C#, that is a dll (dynamic link library). This is an assembly of the compiler or the output of dotnet build. It contains my code in binary format.

> **bin folder stands for binary

This is what the DLL file looks like, fascinating! 

(this file then given to the .NET Core runtime to execute).

* Obj file stand for object. This contains temporary files that are put together during the restore and build process.
* The compiler runs and if there are no syntax errors, it creates a DLL file which is a binary representation of the source code. Then .NET CORE has  (or is also ) a runtime.

Summary:
* Under the hood, when you run `dotnet run` you're first invoking `dotnet restore` (retrieves NuGet packages), then `dotnet build` (compiles source code i.e. analyzes code and translate code into an efficient binary format that is faster to execute when running application). It takes all `.cs` files and produce a single output file that is a binary representation of source code. This file is the `.DLL` file. This is the assembly or the output of `dotnet build`.

 * `bin`: short for binary
 * `obj`: holds temp files that are put together in restore and build process. You can safetly delete this and the `bin` folder. When you `dotnet build` it will recreate these files. All you need to keep around is the source code (`.cs`) and .`csproj`.

 ____
 ## Saying Hello with C#
 An exception represents an error condition. 

Exceptions either:
1. say, "my program says yes, I expected this error to occur and I'll handle it"
2. The exception goes unhandled, in which case it's going to halt/crash the process. 

In the project, you'll see another folder called .vscode. In it are two JSON files, and these JSON files control what VSCode will do when I wanna so something like debug or build project

Launch.json - shows the arguments that the debugger will pass to my application when it launches it under the debugger or even when we launch the program without the debugger. 



