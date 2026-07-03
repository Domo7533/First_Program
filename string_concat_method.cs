using System;

class Program
{
    static string ConcatenateStrings(string firstString, string secondString)
    {
        return $"{firstString} {secondString}";
    }

    static void Main()
    {
        Console.WriteLine(ConcatenateStrings("Good", "Morning"));
    }
}




using System;

class Program
{
    // Method to concatenate two strings with a space
    static string ConcatenateStrings(string firstString, string secondString)
    {
        return firstString + " " + secondString;
    }

    static void Main()
    {
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        string fullName = ConcatenateStrings(firstName, lastName);

        Console.WriteLine($"Full Name: {fullName}");
    }
}