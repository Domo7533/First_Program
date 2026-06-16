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

