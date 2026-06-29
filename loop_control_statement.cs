//loop control statement
using System;
					
public class Program
{
	public static void Main()
	{
		 // Get the user's age
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        // Check membership status
        Console.Write("Do you have a membership card? (yes/no): ");
        string membership = Console.ReadLine().ToLower();

        // Determine discount eligibility
        if (age >= 18 && membership == "yes")
        {
            Console.WriteLine("Discount applied.");
        }
        else
        {
            Console.WriteLine("No discount.");
        }
	}
}