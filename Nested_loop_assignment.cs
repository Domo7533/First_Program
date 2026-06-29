//Seating Arrangement (Rows and Columns)
using System;

class Program
{
    static void Main()
    {
        for (int row = 1; row <= 5; row++)
        {
            for (int seat = 1; seat <= 6; seat++)
            {
                Console.Write($"R{row}S{seat} ");
            }

            Console.WriteLine();
        }
    }
}
// Weekly Sales Report
using System;


class Program
{
    static void Main()
    {
        for (int day = 1; day <= 7; day++)
        {
            Console.WriteLine($"Day {day}");

            for (int product = 1; product <= 3; product++)
            {
                Console.WriteLine($"Product {product}: Sales Recorded");
            }

            Console.WriteLine();
        }
    }
}
// Hotel Room Listing
using System;

class Program
{
    static void Main()
    {
        for (int floor = 1; floor <= 4; floor++)
        {
            Console.WriteLine($"Floor {floor}");

            for (int room = 1; room <= 10; room++)
            {
                Console.Write($"Room {floor}{room:D2} ");
            }

            Console.WriteLine("\n");
        }
    }
}

//Senior Citizen Discount

Condition:

Age 60 or above → "Senior discount applied."
Otherwise → "No senior discount."
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 60)
        {
            Console.WriteLine("Senior discount applied.");
        }
        else
        {
            Console.WriteLine("No senior discount.");
        }
    }
}

// Student Discount
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Are you a student? (yes/no): ");
        string student = Console.ReadLine().ToLower();

        if (age < 25 && student == "yes")
        {
            Console.WriteLine("Student discount applied.");
        }
        else
        {
            Console.WriteLine("No student discount.");
        }
    }
}