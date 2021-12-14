# Module 3: Learning the C# Syntax

## Reviewing Your Assignment
**Assignment**: We need an electronic grade book to read the scores of an indivudual student and then compute some simple statistics from the scores.
The grades are entered as floating point numbers from 0 to 100, and the statistics should show us the highest grade, the lowest grade, and the average grade.

## Working with Code Blocks and Statements
`;` - tells the compiler where one statement starts and another ends
When debugging, skip problems in `.csproj` and instead see errors in `.cs` files. Start with first/earliest errors and work down, as some errors are caused by previous errors. You can see what lines the errors occured in the debug console.

## Adding numbers and Creating Arrays
`var`: implicit typing

## Looping through Arrays
`+=`: Add AND assignment operator. It adds the right operand to the left operand and assign the result to the left operand.	C += A is equivalent to C = C + A

REMEMBER: it is `+=` NOT `=+`

## Using a List
There is a namespace called System.Collections.Generic. That namespace has classes we can use that are data structures, data structures like a stack and a queue or a LIST!

Shortcut: `CTRL + .` to bring up Intellisense error suggestions in Visual Studio Code.

Arrays and Lists are pretty much the same thing, except a List is dynamic, I can add new values to it.

## Computing and Formatting the Result
Formatting specifiers. In this example, we called `result` (a double) and added `:N1` to it. In other words, `result:N1`. This outputted 17.9 instead of 17.9237940999.