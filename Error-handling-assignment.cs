using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"You entered: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input! Please enter a valid whole number.");
        }

        Console.WriteLine("Program finished.");
    }
}
Sample Output

Valid Input

Enter a number: 25
You entered: 25
Program finished.

Invalid Input

Enter a number: abc
Error: Invalid input! Please enter a valid whole number.
Program finished.
Explanation
int.Parse() converts the user's input to an integer.
If the input is not a valid integer (e.g., "abc" or "12.5"), int.Parse() throws a FormatException.
The catch (FormatException) block catches the exception and displays a user-friendly error message instead of crashing the program.
Alternative (Best Practice)

Although this example demonstrates FormatException, in production code it's generally better to use int.TryParse() because it avoids exceptions for expected invalid input.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine($"You entered: {number}");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid whole number.");
        }
    }
}