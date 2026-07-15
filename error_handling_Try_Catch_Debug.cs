using System;
					
public class Program
{
	public static void Main()
	{
		try {
			int[]Scores ={5,7,18};
			Console.WriteLine (Scores [5]);
		} catch (IndexOutOfRangeException ex){
				Console.WriteLine($"Index Error: {ex.Message}");
		} finally {
				Console.WriteLine("Program Ended");
				}
	}
}

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

Use Breakpoints

A breakpoint pauses program execution so you can inspect variables and execution flow.

Steps

Click in the left margin beside a line of code.
Run the program in Debug mode (F5).
Execution stops at the breakpoint.
Inspect variable values before continuing.

Example:

int a = 10;
int b = 0;

int result = a / b; // Set breakpoint here

Use Console Output

Print variable values to verify logic during execution.

Console.WriteLine($"Age = {age}");
Console.WriteLine($"Total = {total}");
Console.WriteLine($"Counter = {counter}");

Use Logging
try
{
    // Code
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
    // In production, use a logging framework such as Microsoft.Extensions.Logging,
    // Serilog, or NLog instead of only writing to the console.
}