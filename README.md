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
