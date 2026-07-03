using System;

class Program
{
    // Method to check if a number is prime
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (IsPrime(num))
        {
            Console.WriteLine($"{num} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{num} is not a prime number.");
        }
    }
}
Sample Output 1
Enter a number: 13
13 is