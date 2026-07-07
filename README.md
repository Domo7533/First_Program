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