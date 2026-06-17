\# Variables and Operators Demo in C#



\## Overview



This project demonstrates the use of \*\*variables\*\*, \*\*data types\*\*, and \*\*operators\*\* in C#. The program performs arithmetic calculations, comparison operations, assignment operations, and type casting.



\## Source Code



```csharp

using System;



public class Program

{

&#x20;   public static void Main()

&#x20;   {

&#x20;       int a = 10, b = 5;

&#x20;       Console.WriteLine(a + b);

&#x20;       Console.WriteLine(a > b);

&#x20;       Console.WriteLine(a - b);

&#x20;       Console.WriteLine(a % b);

&#x20;       Console.WriteLine(a += b);

&#x20;       Console.WriteLine(a);



&#x20;       double price = 19.99;

&#x20;       int wholeNumber = (int)price;



&#x20;       Console.WriteLine(wholeNumber);

&#x20;   }

}

```



\---



\## Variables



A variable is a named storage location used to hold data in memory.



\### Integer Variables



```csharp

int a = 10;

int b = 5;

```



\* `int` is a value type used to store whole numbers.

\* `a` stores the value `10`.

\* `b` stores the value `5`.



\### Double Variable



```csharp

double price = 19.99;

```



\* `double` stores decimal numbers.

\* `price` contains the value `19.99`.



\### Integer Variable with Type Casting



```csharp

int wholeNumber = (int)price;

```



\* Converts the decimal value `19.99` to the integer value `19`.

\* The decimal portion is discarded during conversion.



\---



\## Operators Used



\### 1. Addition Operator (`+`)



```csharp

a + b

```



Adds two values together.



\*\*Output:\*\*



```text

15

```



\---



\### 2. Greater Than Operator (`>`)



```csharp

a > b

```



Checks whether `a` is greater than `b`.



\*\*Output:\*\*



```text

True

```



\---



\### 3. Subtraction Operator (`-`)



```csharp

a - b

```



Subtracts one value from another.



\*\*Output:\*\*



```text

5

```



\---



\### 4. Modulus Operator (`%`)



```csharp

a % b

```



Returns the remainder after division.



\*\*Output:\*\*



```text

0

```



\---



\### 5. Addition Assignment Operator (`+=`)



```csharp

a += b;

```



Equivalent to:



```csharp

a = a + b;

```



Updates the value of `a`.



\*\*Output:\*\*



```text

15

```



The new value of `a` becomes:



```text

15

```



\---



\### 6. Type Casting Operator (`(int)`)



```csharp

(int)price

```



Converts a `double` value into an `int`.



\*\*Example:\*\*



```csharp

double price = 19.99;

int wholeNumber = (int)price;

```



\*\*Output:\*\*



```text

19

```



\---



\## Expected Output



```text

15

True

5

0

15

15

19

```



\## Concepts Learned



\* Declaring variables

\* Using integer and double data types

\* Arithmetic operators (`+`, `-`, `%`)

\* Comparison operators (`>`)

\* Assignment operators (`+=`)

\* Type casting (`(int)`)

\* Displaying output using `Console.WriteLine()`

# Variables and Operators in C#

## Variables

Variables are named storage locations used to hold data in memory.

```csharp
int a = 10;
int b = 5;
double price = 19.99;

\## How to Run



1\. Save the file as `Program.cs`.

2\. Open a terminal in the project directory.

3\. Compile the program:



```bash

csc Program.cs

```



4\. Run the executable:



```bash

Program.exe

```



\## Author



Domo Ereku



