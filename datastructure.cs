using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		int[] numbers = new int[5]; 
		numbers[0] = 10; 
		numbers[1] = 20;
		numbers[2] = 30;
		numbers[3] = 20;
		numbers[4] = 20;
		Console.WriteLine(numbers[0]);
		
		for (int i = 0; i < numbers.Length; i++) { 
			Console.WriteLine(numbers[i]);
		}
		List<string> names = new List<string>();
		names.Add("Domo");
		names.Add("Belema");
		names.Add("omela");
		Console.WriteLine(names[1]);
		foreach (string item in names) {
			Console.WriteLine(item);
		}
	}
		
}