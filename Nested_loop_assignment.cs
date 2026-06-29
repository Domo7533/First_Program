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