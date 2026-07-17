using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

//Example 2: Accessing Elements
using System;

class Program
{
    static void Main()
    {
        string[] fruits = { "Apple", "Banana", "Orange" };

        Console.WriteLine(fruits[0]);
        Console.WriteLine(fruits[2]);
    }
}

//Example 3: Updating an Array Element
using System;

class Program
{
    static void Main()
    {
        int[] scores = { 70, 80, 90 };

        scores[1] = 95;

        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }
    }
}

//Example 4: Finding the Length
using System;

class Program
{
    static void Main()
    {
        char[] grades = { 'A', 'B', 'C', 'D' };

        Console.WriteLine("Total Grades: " + grades.Length);
    }
}