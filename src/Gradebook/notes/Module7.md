# Module 7: Controlling the Flow of Execution

### Branching with if Statements
* `&&` and
* `||` or
* `==` equal, compares if two things are equal, different than assigning with `=`

### Looping with for, foreach, do, and while
 * `index += 1;` is the same thing as `index++;`

 The difference between `do-while` and `while`:
    * A `do{} while{}` loop will always execute atleast one time through, because we do not check the condition until we reach the end of the block of code (the while).
     * A `while{}` statement will first check if the statement is true. If so, then it will execute the proceeding logic, otherwise it will not.

`for`:
    * The first part is the initialization expression. You can declare or initialize a variable, or declare AND initialize a variable that I'm going to be using throughout the rest of the loop.
    * The second part is the condition to check before the runtime enters the loop.
    * The third part is the operation I want to perform after each iteration of the loop.

### Jumping with break and continue
Jumping statements allow me to jump over code to reach some other line of code that's in a method. In general, be careful with them because it can be hard to follow the logic within a jumping statment.

* `break`, `continue` are the main jumping statements. The last uncommon one is `goto` (rarely used)

### Switching with the switch Statement
* `char` type will take in a single character, it is a value type
* `switch` statement have been around in C# since the very beginning. First use the keyword `switch` followed by the variable the switch statement is going to operate on. Next are the `case`s that express a character or *constant*; these are in single quotes as they are not strings. Include break statments after each case.
    * If you want a case to execute when none of the others execute, then use `default`.

### Pattern Matching with switch
* In C# 7, `switch` statments were given the ability to do pattern matching. Pattern matching is used to match some variable against a certain type.
* New `switch` features include being able to declare a variable in my case statement as well as using the `when` keyword. If `when` is true, then the code will execute that is associated with this case statement. 

### Challenge: Taking User Input from the Console
> var input = Console.ReadLine();

> var grade = double.Parse(input);