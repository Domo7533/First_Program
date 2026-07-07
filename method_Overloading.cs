using System;

class Calculator
{
    // Method for integers
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Method for doubles
    public static double Add(double a, double b)
    {
        return a + b;
    }

    // Method for floats
    public static float Add(float a, float b)
    {
        return a + b;
    }

    // Method for decimal numbers
    public static decimal Add(decimal a, decimal b)
    {
        return a + b;
    }

    // Method for strings
    public static string Add(string a, string b)
    {
        return a + b;
    }

    static void Main()
    {
        Console.WriteLine(Add(10, 20));                 // int
        Console.WriteLine(Add(5.5, 4.5));               // double
        Console.WriteLine(Add(3.2f, 1.8f));             // float
        Console.WriteLine(Add(10.5m, 5.5m));            // decimal
        Console.WriteLine(Add("Hello ", "World"));      // string
    }
}