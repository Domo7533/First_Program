//Student ID → Student Name
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(101, "John");
        students.Add(102, "Mary");
        students.Add(103, "David");

        Console.WriteLine("Student 102: " + students[102]);
    }
}

//Product Code → Product Price
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, double> products = new Dictionary<string, double>()
        {
            {"P001", 2500.50},
            {"P002", 1800.00},
            {"P003", 3500.75}
        };

        Console.WriteLine("Price of P003: ₦" + products["P003"]);
    }
}

//Country → Capital
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> capitals = new Dictionary<string, string>()
        {
            {"Nigeria", "Abuja"},
            {"Ghana", "Accra"},
            {"Kenya", "Nairobi"}
        };

        Console.WriteLine(capitals["Nigeria"]);
    }
}

//Employee ID → Department

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> employees = new Dictionary<int, string>()
        {
            {1001, "Finance"},
            {1002, "Human Resources"},
            {1003, "IT"}
        };

        foreach (var employee in employees)
        {
            Console.WriteLine($"ID: {employee.Key}, Department: {employee.Value}");
        }
    }
}

//Course Code → Course Name

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> courses = new Dictionary<string, string>()
        {
            {"CSC101", "Introduction to Computing"},
            {"CSC201", "Data Structures"},
            {"CSC301", "Operating Systems"}
        };

        foreach (var course in courses)
        {
            Console.WriteLine($"{course.Key} - {course.Value}");
        }
    }
}

//Username → Password (Simple Example)
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> users = new Dictionary<string, string>()
        {
            {"admin", "Admin123"},
            {"john", "John456"},
            {"mary", "Mary789"}
        };

        Console.Write("Enter username (username must start with an UPPERCASE):";
        string username = Console.ReadLine();

        if (users.ContainsKey(username))
            Console.WriteLine("User exists.");
        else
            Console.WriteLine("User not found.");
    }
}
//Bank Account Number → Balance

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, decimal> accounts = new Dictionary<string, decimal>()
        {
            {"0012345678", 250000.50m},
            {"0012345679", 150000.00m}
        };

        string account = "0012345678";

        if (accounts.ContainsKey(account))
        {
            Console.WriteLine($"Balance: ₦{accounts[account]}");
        }
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary to store student IDs and names
        Dictionary<int, string> students = new Dictionary<int, string>();

        // Add student records
        students.Add(101, "John");
        students.Add(102, "Mary");
        students.Add(103, "David");
        students.Add(104, "Grace");
        students.Add(105, "Samuel");

        // Display all student records
        Console.WriteLine("Student Records");
        Console.WriteLine("---------------------------");

        foreach (KeyValuePair<int, string> student in students)
        {
            Console.WriteLine($"Student ID: {student.Key}, Name: {student.Value}");
        }
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary of student IDs and names
        Dictionary<int, string> students = new Dictionary<int, string>()
        {
            {101, "John"},
            {102, "Mary"},
            {103, "David"},
            {104, "Grace"},
            {105, "Samuel"}
        };

        // Prompt the user to enter a student ID
        Console.Write("Enter Student ID: ");
        int studentId = Convert.ToInt32(Console.ReadLine());

        // Check if the student ID exists
        if (students.ContainsKey(studentId))
        {
            Console.WriteLine($"Student Name: {students[studentId]}");
        }
        else
        {
            Console.WriteLine("Student ID not found.");
        }
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>()
        {
            {101, "John"},
            {102, "Mary"},
            {103, "David"},
            {104, "Grace"},
            {105, "Samuel"}
        };

        Console.Write("Enter Student ID: ");
        int studentId = Convert.ToInt32(Console.ReadLine());

        if (students.TryGetValue(studentId, out string studentName))
        {
            Console.WriteLine($"Student Name: {studentName}");
        }
        else
        {
            Console.WriteLine("Student ID not found.");
        }
    }
}