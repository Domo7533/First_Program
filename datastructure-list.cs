//Example 1: Creating a List
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> students = new List<string>
        {
            "John",
            "Mary",
            "Peter"
        };

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}
//Example 2: Adding Items
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

//* Output

10
20
30
*//

//Example 3: Removing Items
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> cities = new List<string>
        {
            "Lagos",
            "Abuja",
            "Port Harcourt"
        };

        cities.Remove("Abuja");

        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }
    }
}

//*Output

Lagos
Port Harcourt
*//
//Example 4: Inserting an Item
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> colors = new List<string>
        {
            "Red",
            "Blue"
        };

        colors.Insert(1, "Green");

        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }
    }
}

//*Output

Red
Green
Blue*//

//Example 5: Counting Items
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> ages = new List<int> { 18, 20, 25, 30 };

        Console.WriteLine("Total Ages: " + ages.Count);
    }
}

//Output

//Total Ages: 4


//Using a List

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> scores = new List<int>();

        scores.Add(78);
        scores.Add(85);
        scores.Add(92);
        scores.Add(66);
        scores.Add(88);

        int total = 0;

        foreach (int score in scores)
        {
            total += score;
        }

        Console.WriteLine("Average = " + (double)total / scores.Count);
    }
}


//Hotel Management Example
//Array (Fixed Number of Rooms
using System;

class Program
{
    static void Main()
    {
        string[] rooms = { "101", "102", "103", "104" };

        foreach (string room in rooms)
        {
            Console.WriteLine("Room: " + room);
        }
    }
}
//List (Guests Check In and Out)
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> guests = new List<string>();

        guests.Add("James");
        guests.Add("Sarah");
        guests.Add("Michael");

        guests.Remove("Sarah");

        Console.WriteLine("Current Guests:");

        foreach (string guest in guests)
        {
            Console.WriteLine(guest);
        }
    }
}


