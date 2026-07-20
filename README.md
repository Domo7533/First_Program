\# Simple C# Console Application



\## Overview

This is a basic C# console application that demonstrates how to display text output to the console using the `Console.WriteLine()` method.



\## Source Code



```csharp

using System;



class Program

{

&#x20;   static void Main()

&#x20;   {

&#x20;       Console.WriteLine("my name is Domo and i'm 70 years Old");

&#x20;   }

}

```



\## Purpose

The program prints a simple introduction message to the console when executed.



\### Expected Output



```text

my name is Domo and i'm 70 years Old

```



\## Requirements



\- .NET SDK (version 6.0 or later recommended)

\- A code editor such as:

&#x20; - Visual Studio

&#x20; - Visual Studio Code

&#x20; - JetBrains Rider



\## How to Run



\### Using the .NET CLI



1\. Open a terminal or command prompt.

2\. Create a new console application:



```bash

dotnet new console -n MyFirstApp

```



3\. Replace the contents of `Program.cs` with the provided source code.

4\. Navigate to the project directory:



```bash

cd MyFirstApp

```



5\. Run the application:



```bash

dotnet run

```



\## Code Explanation



\### `using System;`

Imports the `System` namespace, which contains fundamental classes and methods used by C# applications.



\### `class Program`

Defines a class named `Program` that contains the application's entry point.



\### `static void Main()`

The `Main()` method is the entry point of the application. Execution begins here.



\### `Console.WriteLine()`

Outputs the specified text to the console window.



\## Author



\*\*Domo Ereku\*\*



\## License



This project is provided for educational and learning purposes.




## Control Flow in C#

Control flow determines the order in which statements are executed in a program. C# provides conditional statements and loops to control program execution.

### Conditional Statements

#### `if` Statement
Executes a block of code when a condition is true.

```csharp
int age = 18;

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
```

#### `if-else` Statement
Provides an alternative block of code when the condition is false.

```csharp
int age = 16;

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a minor.");
}
```

### Loops

Loops allow code to be executed repeatedly.

#### `for` Loop
Used when the number of iterations is known.

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

#### `while` Loop
Executes while a condition remains true.

```csharp
int i = 1;

while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
```

#### `do-while` Loop
Executes at least once before checking the condition.

```csharp
int i = 1;

do
{
    Console.WriteLine(i);
    i++;
}
while (i <= 5);
```

### Difference Between `for`, `while`, and `do-while`

| Loop Type | Best Used When | Condition Check |
|------------|---------------|-----------------|
| `for` | Number of iterations is known | Before execution |
| `while` | Iterations depend on a condition | Before execution |
| `do-while` | Code must run at least once | After execution |

### AI Explanation

Think of climbing stairs:

- **for loop**: You know there are exactly 10 steps, so you count each step.
- **while loop**: You keep climbing while there are stairs ahead.
- **do-while loop**: You take one step first, then check whether there are more steps.

# Advanced Control Flow in C

This README contains C# examples demonstrating nested loops in
real-world scenarios.

## Examples

1.  Cinema seating (rows and seats)
2.  Classroom attendance
3.  Weekly sales report
4.  Hotel room listing
5.  School timetable
6.  Restaurant tables and chairs
7.  Employee monthly attendance
8.  Multiplication table
9.  Parking lot layout
10. Examination scores
11. Warehouse inventory
12. Online store categories

## Sample: Cinema Seating

``` csharp
for (int row = 1; row <= 5; row++)
{
    for (int seat = 1; seat <= 6; seat++)
    {
        Console.Write($"R{row}S{seat} ");
    }
    Console.WriteLine();
}
```

## Why Nested Loops?

Nested loops are useful whenever one collection contains another, such
as:

-   Rows → Seats
-   Floors → Rooms
-   Days → Periods
-   Categories → Products
-   Students → Subjects

## Best Practices

-   Keep nesting shallow when possible.
-   Use descriptive variable names.
-   Use `break` and `continue` appropriately.
-   Extract repeated logic into methods.
-   Consider time complexity (`O(n²)` for two nested loops).

## Summary

Nested loops allow you to process two-dimensional and hierarchical data
efficiently and are commonly used in scheduling, reporting, seating,
inventory, and matrix-style problems.
# Advanced Methods in C#

Methods are reusable blocks of code that perform specific tasks. They help make programs more organized, readable, and easier to maintain. C# supports several advanced method features that improve code flexibility and reusability.

---

## Method Parameters

Methods can accept one or more parameters.

```csharp
static void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

Greet("Domo");
```

**Output**

```text
Hello, Domo!
```

---

## Return Values

Methods can return a value to the caller.

```csharp
static int Square(int number)
{
    return number * number;
}

int result = Square(6);
Console.WriteLine(result);
```

**Output**

```text
36
```

---

## Methods with Multiple Parameters

A method can accept multiple arguments.

```csharp
static int Add(int a, int b)
{
    return a + b;
}

Console.WriteLine(Add(15, 25));
```

**Output**

```text
40
```

---

## Method Overloading

Method overloading allows multiple methods to have the same name but different parameter lists.

```csharp
class Calculator
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static string Add(string a, string b)
    {
        return a + b;
    }
}
```

### Example

```csharp
Console.WriteLine(Calculator.Add(5, 10));
Console.WriteLine(Calculator.Add(5.5, 2.5));
Console.WriteLine(Calculator.Add("Hello ", "World"));
```

**Output**

```text
15
8
Hello World
```

### Rules of Method Overloading

- Methods must have the same name.
- Methods must differ in:
  - Number of parameters
  - Parameter data types
  - Order of parameters
- Methods **cannot** be overloaded by changing only the return type.

---

## Optional Parameters

Optional parameters provide default values when no argument is supplied.

```csharp
static void Welcome(string name = "Guest")
{
    Console.WriteLine($"Welcome, {name}!");
}

Welcome();
Welcome("Alice");
```

**Output**

```text
Welcome, Guest!
Welcome, Alice!
```

---

## Named Arguments

Named arguments improve readability by specifying parameter names.

```csharp
static void Student(string name, int age)
{
    Console.WriteLine($"{name} is {age} years old.");
}

Student(age: 22, name: "David");
```

**Output**

```text
David is 22 years old.
```

---

## Recursive Methods

A recursive method calls itself until a stopping condition is reached.

```csharp
static int Factorial(int n)
{
    if (n <= 1)
        return 1;

    return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(5));
```

**Output**

```text
120
```

---

# Understanding Variable Scope

Scope determines where a variable can be accessed in a program.

## 1. Local Scope

Variables declared inside a method exist only within that method.

```csharp
static void Display()
{
    int age = 25;
    Console.WriteLine(age);
}
```

```
Program
│
├── Display()
│     age ✓
│
└── Main()
      age ✗
```

---

## 2. Block Scope

Variables declared inside a block (`if`, `for`, `while`, etc.) exist only within that block.

```csharp
int number = 10;

if (number > 5)
{
    int value = 20;
    Console.WriteLine(value);
}

// value cannot be accessed here.
```

```
Main()
│
├── number ✓
│
├── if
│     value ✓
│
└── value ✗
```

---

## 3. Parameter Scope

Method parameters exist only inside the method.

```csharp
static int Multiply(int x, int y)
{
    return x * y;
}
```

```
Multiply(x, y)

x ✓
y ✓

Outside Method

x ✗
y ✗
```

---

## 4. Class Scope (Fields)

Variables declared inside a class but outside methods are available to all methods in the class.

```csharp
class Student
{
    string school = "ABC Academy";

    void Display()
    {
        Console.WriteLine(school);
    }
}
```

```
Student
│
├── school ✓
│
├── Display()
│     school ✓
│
└── OtherMethod()
      school ✓
```

---

## Scope Summary

| Scope | Declared In | Accessible From |
|--------|-------------|-----------------|
| Local | Method | That method only |
| Block | `{ }` block | That block only |
| Parameter | Method parameters | That method only |
| Class | Class | All methods in the class |

---

## Best Practices

- Keep methods short and focused on a single task.
- Use meaningful method names.
- Reuse code through methods instead of duplication.
- Use method overloading when similar operations differ only by parameter types.
- Minimize variable scope by declaring variables as close as possible to where they are used.
- Return values instead of relying on global variables whenever possible.

---

## Summary

Advanced methods make C# programs modular, reusable, and easier to maintain. Features such as parameterized methods, return values, method overloading, recursion, optional parameters, and proper variable scope are fundamental concepts that every C# developer should master before moving on to object-oriented programming.
# Common Exceptions and Debugging Strategies in C#

## Overview

Exceptions are runtime errors that interrupt the normal flow of a program. C# provides a robust exception handling mechanism using the `try`, `catch`, `finally`, and `throw` keywords. Understanding common exceptions and effective debugging techniques helps developers build reliable and maintainable applications.

---

# Common Exceptions in C#

## 1. DivideByZeroException

**Description**

Occurs when attempting to divide a number by zero.

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 20;
            int b = 0;

            int result = a / b;

            Console.WriteLine(result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero.");
            Console.WriteLine(ex.Message);
        }
    }
}
```

---

## 2. NullReferenceException

**Description**

Occurs when trying to access an object that has not been initialized.

### Example

```csharp
using System;

class Student
{
    public string Name;
}

class Program
{
    static void Main()
    {
        Student student = null;

        try
        {
            Console.WriteLine(student.Name);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Object reference is null.");
            Console.WriteLine(ex.Message);
        }
    }
}
```

---

## 3. IndexOutOfRangeException

**Description**

Occurs when accessing an invalid array index.

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numbers = {10, 20, 30};

        try
        {
            Console.WriteLine(numbers[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Invalid array index.");
            Console.WriteLine(ex.Message);
        }
    }
}
```

---

## 4. FormatException

**Description**

Occurs when converting improperly formatted data.

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        try
        {
            int age = int.Parse("Twenty");

            Console.WriteLine(age);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid number format.");
            Console.WriteLine(ex.Message);
        }
    }
}
```

---

## 5. OverflowException

**Description**

Occurs when a numeric calculation exceeds the allowed range.

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        try
        {
            checked
            {
                byte number = 255;
                number++;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Numeric overflow occurred.");
            Console.WriteLine(ex.Message);
        }
    }
}
```

---

## 6. InvalidOperationException

**Description**

Occurs when a method is called in an invalid object state.

### Example

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();

        try
        {
            Console.WriteLine(queue.Dequeue());
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Queue is empty.");
            Console.WriteLine(ex.Message);
        }
    }
}
```

---

## 7. FileNotFoundException

**Description**

Occurs when the specified file cannot be located.

### Example

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string text = File.ReadAllText("student.txt");
            Console.WriteLine(text);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found.");
            Console.WriteLine(ex.Message);
        }
    }
}
```

---

## 8. UnauthorizedAccessException

**Description**

Occurs when the application lacks permission to access a resource.

### Example

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            File.WriteAllText(@"C:\Windows\system.txt", "Hello");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("Access denied.");
            Console.WriteLine(ex.Message);
        }
    }
}
```

---

## 9. ArgumentException

**Description**

Occurs when an invalid argument is supplied to a method.

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        try
        {
            string name = null;

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");

            Console.WriteLine(name);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
```

---

## 10. General Exception

**Description**

Used to catch unexpected exceptions that are not handled specifically.

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        try
        {
            int number = int.Parse("ABC");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine(ex.Message);
        }
    }
}
```

> **Best Practice:** Always catch specific exception types before using a general `Exception` catch block.

---

# Debugging Strategies in C#

Debugging is the process of locating and fixing errors in your application.

---

## 1. Read Exception Messages

Exception messages usually describe the problem clearly.

Example:

```text
System.FormatException:
Input string was not in a correct format.
```

---

## 2. Use Breakpoints

Breakpoints pause execution and allow inspection of program state.

Example:

```csharp
int a = 10;
int b = 0;

int result = a / b; // Place breakpoint here
```

Useful shortcut:

* **F5** – Start Debugging

---

## 3. Step Through Code

Visual Studio provides several debugging commands:

| Shortcut    | Action    |
| ----------- | --------- |
| F10         | Step Over |
| F11         | Step Into |
| Shift + F11 | Step Out  |

---

## 4. Inspect Variables

Use debugging windows to inspect values during execution.

* Locals
* Autos
* Watch
* QuickWatch

Example:

```csharp
int age = int.Parse(userInput);
```

Inspect `userInput` before parsing.

---

## 5. Display Variable Values

Use console output to verify program behavior.

```csharp
Console.WriteLine($"Age = {age}");
Console.WriteLine($"Total = {total}");
Console.WriteLine($"Counter = {counter}");
```

---

## 6. Validate User Input

Avoid exceptions by validating input.

Instead of:

```csharp
int age = int.Parse(Console.ReadLine());
```

Use:

```csharp
if (int.TryParse(Console.ReadLine(), out int age))
{
    Console.WriteLine($"Age: {age}");
}
else
{
    Console.WriteLine("Invalid number.");
}
```

---

## 7. Check the Call Stack

The Call Stack window shows the sequence of method calls that resulted in the exception.

Example:

```text
Main()
    ↓
CalculateSalary()
    ↓
DivideHours()
```

---

## 8. Examine the Stack Trace

Every exception contains a stack trace.

```csharp
catch (Exception ex)
{
    Console.WriteLine(ex.StackTrace);
}
```

This helps identify the exact line where the error occurred.

---

## 9. Use Logging

Log errors instead of allowing applications to fail silently.

```csharp
try
{
    // Code
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
```

Production applications should use a logging framework such as **Microsoft.Extensions.Logging**, **Serilog**, or **NLog**.

---

## 10. Reproduce the Bug

A consistent process for fixing bugs:

1. Identify the steps that cause the problem.
2. Reproduce the issue consistently.
3. Set breakpoints.
4. Inspect variables.
5. Fix the code.
6. Test both normal and edge-case inputs.

---

# Best Practices

* Handle only exceptions you can recover from.
* Catch specific exceptions before general ones.
* Use `TryParse()` instead of `Parse()` for user input.
* Avoid empty `catch` blocks.
* Release resources using `finally` or `using`.
* Validate all external input.
* Log exceptions in production applications.
* Use the Visual Studio debugger instead of guessing.
* Throw meaningful exceptions in custom methods.

---

# Summary

Understanding common C# exceptions and using structured debugging techniques significantly improves software quality. By combining proper exception handling, input validation, logging, and Visual Studio's debugging tools, developers can efficiently identify and resolve runtime issues while creating more robust and maintainable applications.


# Custom Exceptions and Logging in C#

## Overview

Exception handling is an essential part of building reliable C# applications. While .NET provides many built-in exceptions (such as `FormatException` and `NullReferenceException`), applications often require **custom exceptions** to represent business-specific errors. Logging complements exception handling by recording application events, errors, and diagnostic information, making troubleshooting and maintenance significantly easier.

---

## What are Custom Exceptions?

A **custom exception** (also called a domain-specific exception) is a user-defined exception that represents an error unique to your application's business logic.

Examples include:

* `InsufficientFundsException`
* `OutOfStockException`
* `InvalidNationalIdException`
* `CourseCapacityExceededException`
* `PolicyExpiredException`

Creating meaningful exceptions improves code readability and makes error handling more expressive.

### Creating a Custom Exception

```csharp
using System;

public class InsufficientFundsException : Exception
{
    public InsufficientFundsException()
        : base("Insufficient funds for this transaction.")
    {
    }

    public InsufficientFundsException(string message)
        : base(message)
    {
    }
}
```

---

## Throwing a Custom Exception

```csharp
public void Withdraw(decimal amount)
{
    if (amount > Balance)
    {
        throw new InsufficientFundsException(
            $"Withdrawal of ₦{amount} failed. Available balance is ₦{Balance}."
        );
    }

    Balance -= amount;
}
```

---

## Catching a Custom Exception

```csharp
try
{
    account.Withdraw(10000);
}
catch (InsufficientFundsException ex)
{
    Console.WriteLine(ex.Message);
}
```

---

## Why Use Custom Exceptions?

* Improve code readability.
* Represent business rules clearly.
* Simplify debugging.
* Enable targeted exception handling.
* Make applications easier to maintain.

---

# Logging in C#

## Why Logging Matters

Logging records important application events and errors, allowing developers to:

* Debug problems quickly.
* Monitor application health.
* Audit important operations.
* Track unexpected failures.
* Diagnose production issues.

---

## Common Log Levels

| Level       | Description                                   |
| ----------- | --------------------------------------------- |
| Trace       | Very detailed diagnostic information.         |
| Debug       | Information useful during development.        |
| Information | Normal application events.                    |
| Warning     | Recoverable or unexpected conditions.         |
| Error       | Operation failed.                             |
| Critical    | Severe failure requiring immediate attention. |

---

## Simple Logger Example

```csharp
using System;
using System.IO;

public static class Logger
{
    private static readonly string logFile = "application.log";

    public static void Log(string level, string message)
    {
        string entry =
            $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";

        File.AppendAllText(logFile, entry + Environment.NewLine);
    }
}
```

Usage:

```csharp
Logger.Log("INFO", "Application started.");
Logger.Log("WARNING", "Inventory is running low.");
Logger.Log("ERROR", "Database connection failed.");
```

---

## Logging Exceptions

```csharp
try
{
    account.Withdraw(10000);
}
catch (InsufficientFundsException ex)
{
    Logger.Log("WARNING", ex.Message);
}
catch (Exception ex)
{
    Logger.Log("ERROR", ex.ToString());
}
```

---

## Sample Log Output

```text
2026-07-15 09:00:15 [INFO] Application started.
2026-07-15 09:02:11 [WARNING] Withdrawal denied. Available balance is ₦5000.
2026-07-15 09:03:45 [ERROR] Database connection timeout.
```

---

## Logging Best Practices

* Use the appropriate log level.
* Include timestamps.
* Log useful context (user ID, transaction ID, request ID).
* Record complete exception details for unexpected errors.
* Never log passwords, authentication tokens, or other sensitive information.
* Rotate and archive log files.
* Review logs regularly to identify recurring issues.
* Use structured logging for production applications.

---

## Popular Logging Frameworks

| Framework                    | Description                                                                           |
| ---------------------------- | ------------------------------------------------------------------------------------- |
| Microsoft.Extensions.Logging | Built-in logging abstraction for modern .NET applications.                            |
| Serilog                      | Structured logging with support for files, databases, cloud services, and dashboards. |
| NLog                         | Highly configurable logging framework supporting multiple output targets.             |
| log4net                      | Mature enterprise logging framework with flexible configuration options.              |

---

## Summary

Custom exceptions make your applications easier to understand by representing business-specific errors instead of relying solely on generic exceptions. Logging provides visibility into application behavior by recording events, warnings, and errors. Together, exception handling and logging form the foundation of robust, maintainable, and production-ready C# applications.


# Arrays and Lists in C#

## Overview

Arrays and Lists are two of the most commonly used collection types in C#. Both store multiple values of the same data type, but they differ significantly in how they manage data and memory.

* **Array (`T[]`)**: A fixed-size collection whose length is determined when it is created.
* **List (`List<T>`)**: A dynamic collection that can automatically grow or shrink during program execution.

Understanding when to use each collection type is essential for writing efficient and maintainable C# applications.

---

## Arrays

An array stores a fixed number of elements of the same type.

### Syntax

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
```

Or

```csharp
int[] numbers = new int[5];
```

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        string[] fruits =
        {
            "Apple",
            "Banana",
            "Orange"
        };

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
```

### Common Array Properties and Methods

| Property/Method   | Description                                  |
| ----------------- | -------------------------------------------- |
| `Length`          | Returns the number of elements in the array. |
| `Array.Sort()`    | Sorts the array in ascending order.          |
| `Array.Reverse()` | Reverses the order of elements.              |
| `Array.IndexOf()` | Finds the index of an element.               |
| `Array.Clear()`   | Sets all elements to their default values.   |

Example:

```csharp
int[] numbers = { 5, 3, 8, 1 };

Array.Sort(numbers);

Console.WriteLine(numbers[0]); // 1
```

---

## Lists

A `List<T>` is a dynamic collection that automatically resizes as items are added or removed.

### Namespace

```csharp
using System.Collections.Generic;
```

### Syntax

```csharp
List<int> numbers = new List<int>();
```

### Example

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>();

        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Orange");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
```

---

## Common List Methods

| Method       | Description                           |
| ------------ | ------------------------------------- |
| `Add()`      | Adds an item to the end of the list.  |
| `Remove()`   | Removes the first matching item.      |
| `RemoveAt()` | Removes an item by index.             |
| `Insert()`   | Inserts an item at a specified index. |
| `Contains()` | Checks whether an item exists.        |
| `IndexOf()`  | Returns the position of an item.      |
| `Sort()`     | Sorts the list.                       |
| `Clear()`    | Removes all items.                    |
| `Count`      | Returns the number of elements.       |

Example:

```csharp
List<int> numbers = new List<int>();

numbers.Add(10);
numbers.Add(20);
numbers.Add(30);

numbers.Remove(20);

Console.WriteLine(numbers.Count);
```

---

## Arrays vs Lists

| Feature                  | Array    | List<T>                         |
| ------------------------ | -------- | ------------------------------- |
| Size                     | Fixed    | Dynamic                         |
| Namespace                | System   | System.Collections.Generic      |
| Length/Count             | `Length` | `Count`                         |
| Add New Items            | ❌ No     | ✅ Yes                           |
| Remove Items             | ❌ No     | ✅ Yes                           |
| Insert Items             | ❌ No     | ✅ Yes                           |
| Built-in Utility Methods | Limited  | Extensive                       |
| Memory Usage             | Lower    | Slightly Higher                 |
| Performance              | Faster   | Slightly Slower due to resizing |

---

## Converting Between Arrays and Lists

### Array to List

```csharp
using System.Linq;

int[] numbers = { 1, 2, 3, 4 };

List<int> list = numbers.ToList();
```

### List to Array

```csharp
List<int> list = new List<int>
{
    1, 2, 3, 4
};

int[] numbers = list.ToArray();
```

---

## Real-World Examples

### Array Example – Days of the Week

The number of days in a week never changes.

```csharp
string[] days =
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};
```

---

### List Example – Student Registration

Students can enroll or withdraw throughout the semester.

```csharp
List<string> students = new List<string>();

students.Add("Alice");
students.Add("Bob");
students.Add("Charles");

students.Remove("Bob");

students.Add("David");
```

---

## Best Practices

* Use **arrays** when the number of elements is fixed.
* Use **List<T>** when the collection size changes during execution.
* Prefer **foreach** when you only need to read elements.
* Use **for** loops when you need the element index.
* Avoid converting repeatedly between arrays and lists unless necessary.
* Choose the collection type based on your application's requirements rather than habit.

---

## Common Beginner Mistakes

### Accessing an Invalid Index

```csharp
int[] numbers = { 10, 20, 30 };

// Throws IndexOutOfRangeException
Console.WriteLine(numbers[5]);
```

Always ensure the index is within the valid range:

```csharp
if (index >= 0 && index < numbers.Length)
{
    Console.WriteLine(numbers[index]);
}
```

---

### Forgetting the Namespace

```csharp
using System.Collections.Generic;
```

Without this namespace, `List<T>` cannot be used.

---

### Confusing `Length` and `Count`

Arrays use:

```csharp
numbers.Length
```

Lists use:

```csharp
numbers.Count
```

---

## Summary

* Arrays are fixed-size collections that offer fast access and lower memory overhead.
* Lists are flexible, dynamically sized collections with many built-in methods for managing data.
* Arrays are ideal for fixed datasets, while `List<T>` is preferred when data changes over time.
* Both support indexing and iteration, making them fundamental collection types in C#.
* Choosing the right collection improves performance, readability, and maintainability.

# Dictionaries in C#

## Overview

A **Dictionary** in C# is a generic collection that stores data as **key-value pairs**. Each key is **unique** and is used to quickly retrieve its corresponding value.

The `Dictionary<TKey, TValue>` class is part of the `System.Collections.Generic` namespace and provides fast lookup, insertion, and deletion of data.

---

# Why Use a Dictionary?

Use a Dictionary when:

- Each item has a unique identifier.
- You need fast data retrieval.
- You want to map one value to another.
- Searching by key is more efficient than searching through a list.

### Real-World Examples

| Key | Value |
|------|-------|
| Student ID | Student Name |
| Product Code | Product Price |
| Country | Capital |
| Username | User Information |
| Account Number | Account Balance |
| Course Code | Course Name |
| ISBN | Book Title |

---

# Syntax

```csharp
Dictionary<TKey, TValue> dictionaryName = new Dictionary<TKey, TValue>();
```

Example:

```csharp
Dictionary<int, string> students = new Dictionary<int, string>();
```

- **TKey** → Type of the key
- **TValue** → Type of the value

---

# Creating a Dictionary

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(101, "John");
        students.Add(102, "Mary");
        students.Add(103, "David");

        Console.WriteLine(students[102]);
    }
}
```

**Output**

```
Mary
```

---

# Initializing a Dictionary

```csharp
Dictionary<string, string> capitals = new Dictionary<string, string>()
{
    {"Nigeria", "Abuja"},
    {"Ghana", "Accra"},
    {"Kenya", "Nairobi"}
};
```

---

# Accessing Values

Use the key to retrieve a value.

```csharp
Console.WriteLine(capitals["Nigeria"]);
```

Output

```
Abuja
```

---

# Adding Items

```csharp
Dictionary<int, string> employees = new Dictionary<int, string>();

employees.Add(1001, "James");
employees.Add(1002, "Grace");
```

---

# Updating Values

```csharp
employees[1002] = "Grace Wilson";
```

---

# Removing Items

```csharp
employees.Remove(1001);
```

---

# Checking if a Key Exists

```csharp
if (employees.ContainsKey(1002))
{
    Console.WriteLine("Employee Found");
}
```

---

# Checking if a Value Exists

```csharp
if (employees.ContainsValue("Grace Wilson"))
{
    Console.WriteLine("Value Exists");
}
```

---

# Looping Through a Dictionary

```csharp
foreach (var employee in employees)
{
    Console.WriteLine($"{employee.Key} : {employee.Value}");
}
```

Output

```
1002 : Grace Wilson
```

---

# Getting the Number of Items

```csharp
Console.WriteLine(employees.Count);
```

---

# Clearing a Dictionary

```csharp
employees.Clear();
```

---

# Dictionary Methods

| Method | Description |
|---------|-------------|
| Add() | Adds a new key-value pair |
| Remove() | Removes an item by key |
| Clear() | Removes all items |
| ContainsKey() | Checks if a key exists |
| ContainsValue() | Checks if a value exists |
| TryGetValue() | Retrieves a value safely |
| Count | Returns the number of items |

---

# Using TryGetValue()

Instead of directly accessing a key, use `TryGetValue()` to avoid exceptions if the key does not exist.

```csharp
Dictionary<int, string> students = new Dictionary<int, string>()
{
    {101, "John"},
    {102, "Mary"}
};

if (students.TryGetValue(102, out string student))
{
    Console.WriteLine(student);
}
else
{
    Console.WriteLine("Student not found.");
}
```

Output

```
Mary
```

---

# Example 1: Student Records

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>()
        {
            {101, "John"},
            {102, "Mary"},
            {103, "David"}
        };

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key} : {student.Value}");
        }
    }
}
```

---

# Example 2: Product Prices

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, double> products = new Dictionary<string, double>()
        {
            {"Laptop", 550000},
            {"Mouse", 8000},
            {"Keyboard", 15000}
        };

        Console.WriteLine($"Laptop costs ₦{products["Laptop"]}");
    }
}
```

---

# Example 3: Inventory Management

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>()
        {
            {"Laptop", 20},
            {"Mouse", 150},
            {"Keyboard", 75}
        };

        inventory["Laptop"]--;

        foreach (var item in inventory)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
```

---

# Example 4: Country and Capital

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> countries = new Dictionary<string, string>()
        {
            {"Nigeria", "Abuja"},
            {"Canada", "Ottawa"},
            {"Japan", "Tokyo"}
        };

        Console.WriteLine(countries["Japan"]);
    }
}
```

---

# Example 5: Word Frequency Counter

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string sentence = "apple orange apple banana apple orange";

        Dictionary<string, int> frequency = new Dictionary<string, int>();

        foreach (string word in sentence.Split(' '))
        {
            if (frequency.ContainsKey(word))
                frequency[word]++;
            else
                frequency[word] = 1;
        }

        foreach (var item in frequency)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
```

Output

```
apple: 3
orange: 2
banana: 1
```

---

# List vs Dictionary

| Feature | List | Dictionary |
|---------|------|------------|
| Stores | Values | Key-Value Pairs |
| Access | Index | Key |
| Duplicate Values | Allowed | Allowed |
| Duplicate Keys | Not Applicable | Not Allowed |
| Search Speed | Linear | Fast by Key |
| Best Use | Ordered Collections | Fast Lookups |

---

# Common Exceptions

### Duplicate Key

```csharp
students.Add(101, "John");
students.Add(101, "Mary");
```

Throws:

```
ArgumentException
```

Reason:

```
A key already exists.
```

---

### Key Not Found

```csharp
Console.WriteLine(students[999]);
```

Throws:

```
KeyNotFoundException
```

Use:

```csharp
ContainsKey()
```

or

```csharp
TryGetValue()
```

instead.

---

# Best Practices

- Use meaningful and unique keys.
- Prefer `TryGetValue()` for safe retrieval.
- Avoid storing duplicate keys.
- Choose the correct key and value data types.
- Use dictionaries for fast lookups instead of repeatedly searching through lists.
- Keep keys immutable whenever possible.

---

# Practice Exercises

## Beginner

1. Create a dictionary of five students and their ages.
2. Store five countries and their capitals.
3. Create a phonebook using names and phone numbers.
4. Store employee IDs and departments.
5. Display all key-value pairs using `foreach`.

---

## Intermediate

6. Update a student's age.
7. Remove an employee from the dictionary.
8. Check if a course code exists.
9. Count the frequency of each word in a sentence.
10. Build a simple inventory system that updates stock quantities.

---

## Advanced

11. Build a student grade management system using a dictionary.
12. Create a library catalog mapping ISBNs to book titles.
13. Store usernames and user profiles using custom objects as values.
14. Read a text file and count the occurrence of each word.
15. Create a menu-driven console application to add, update, search, and delete dictionary entries.

---

# Summary

- A **Dictionary** stores **key-value pairs**.
- Keys must be **unique**.
- Values can be duplicated.
- Dictionaries provide **fast retrieval** using keys.
- Common methods include `Add()`, `Remove()`, `ContainsKey()`, `ContainsValue()`, `TryGetValue()`, and `Clear()`.
- Dictionaries are ideal for applications such as student records, product catalogs, inventories, banking systems, and lookup tables.

Mastering dictionaries will help you build efficient C# applications that require quick and reliable data access.
