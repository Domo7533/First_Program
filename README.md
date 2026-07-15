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
