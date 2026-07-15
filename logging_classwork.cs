using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int result = 100 / number;

            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            LogException(ex);

            Console.WriteLine("An error occurred.");
            Console.WriteLine("The error has been logged to errors.txt");
        }
    }

    static void LogException(Exception ex)
    {
        string fileName = "errors.txt";

        string logEntry =
            $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]" + Environment.NewLine +
            $"Exception Type: {ex.GetType().Name}" + Environment.NewLine +
            $"Message: {ex.Message}" + Environment.NewLine +
            $"Stack Trace:" + Environment.NewLine +
            $"{ex.StackTrace}" + Environment.NewLine +
            new string('-', 60) + Environment.NewLine;

        File.AppendAllText(fileName, logEntry);
    }
}