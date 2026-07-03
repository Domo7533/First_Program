using System;

class Program
{
    // Method to calculate the square of a number
    static int Square(int number)
    {
        return number * number;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int result = Square(num);

        Console.WriteLine($"The square of {num} is {result}.");
    }
}