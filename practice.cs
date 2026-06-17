using System;
					
public class Program
{
	public static void Main()
	{
		int a = 10, b = 5;
		Console.WriteLine (a + b); 
		Console.WriteLine(a > b); 
		Console.WriteLine(a - b);
		Console.WriteLine(a % b);
		Console.WriteLine(a += b);
		Console.WriteLine(a);
		
		double price = 19.99;
		int wholeNumber = (int)price;

		Console.WriteLine(wholeNumber);
	}