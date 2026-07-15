using System;

// Custom Exception
public class InvalidGPAException : Exception
{
    public InvalidGPAException()
        : base("GPA must be between 0.0 and 4.0.")
    {
    }

    public InvalidGPAException(string message)
        : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter your GPA (0.0 - 4.0): ");
            double gpa = double.Parse(Console.ReadLine());

            ValidateGPA(gpa);

            Console.WriteLine($"Your GPA is: {gpa:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a numeric GPA.");
        }
        catch (InvalidGPAException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    static void ValidateGPA(double gpa)
    {
        if (gpa < 0.0 || gpa > 4.0)
        {
            throw new InvalidGPAException(
                $"Invalid GPA ({gpa}). GPA must be between 0.0 and 4.0."
            );
        }
    }
}