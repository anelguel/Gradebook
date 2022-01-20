# Catching up with the Latest in C#

### Working with Non-nullable Reference Types
* Add addition to the C# language is an addition that is designed to help prevent `NullReferenceException` at runtime. It allows us to work with non-nullable reference types. The C# compiler can now look aggressively through our program to try to find places where we might have a `NullReferenceException` at runtime.

* If you run into this, it will provide a warning such as:

```
warning CS0649: Field 'InMemoryBook.grades' is never assigned to, and will always have its default value null
```
I never initialized or assigned to this, hence the error.