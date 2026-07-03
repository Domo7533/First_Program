//Count Prime Numbers in a Range
using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter the starting number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number: ");
        int end = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
                count++;
        }

        Console.WriteLine($"There are {count} prime numbers between {start} and {end}.");
    }
}

//Display All Prime Numbers Within a Range


using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter the starting number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime numbers:");

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
                Console.Write(i + " ");
        }
    }
}

// Find the Next Prime Number

//Objective: Find the first prime number greater than the user's input.

using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        number++;

        while (!IsPrime(number))
        {
            number++;
        }

        Console.WriteLine($"Next prime number: {number}");
    }
}


// Determine Whether Two Numbers Are Both Prime

//Objective: Use the prime-checking method twice.

using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter the first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int second = int.Parse(Console.ReadLine());

        if (IsPrime(first) && IsPrime(second))
            Console.WriteLine("Both numbers are prime.");
        else
            Console.WriteLine("At least one number is not prime.");
    }
}


//Count the Factors of a Number

//Objective: Reinforce the concept behind prime numbers by counting factors.

using System;

class Program
{
    static int CountFactors(int number)
    {
        int count = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        return count;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Number of factors: {CountFactors(number)}");
    }
}

// Check Whether a Number Is Even, Odd, or Prime

// Objective: Combine methods and conditional statements.

using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine("Prime number");
        }
        else if (number % 2 == 0)
        {
            Console.WriteLine("Even but not prime");
        }
        else
        {
            Console.WriteLine("Odd but not prime");
        }
    }
}
// Prime Number Quiz

// Objective: Let the user guess whether a number is prime.

using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Is it prime? (yes/no): ");
        string answer = Console.ReadLine().ToLower();

        bool prime = IsPrime(number);

        if ((prime && answer == "yes") || (!prime && answer == "no"))
            Console.WriteLine("Correct!");
        else
            Console.WriteLine("Incorrect.");
    }
}

// . Return the Smallest Prime Greater Than a Number

Objective: Create a reusable method that returns the next prime.

using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static int NextPrime(int number)
    {
        number++;

        while (!IsPrime(number))
        {
            number++;
        }

        return number;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Next prime is {NextPrime(number)}");
    }
}


